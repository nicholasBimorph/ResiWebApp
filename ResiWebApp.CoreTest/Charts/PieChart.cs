using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartJs.Blazor.PieChart;
using ChartJs.Blazor.Util;
using System.Drawing;
using Bimorph.WebApi.Core;
using ChartJs.Blazor.Common;
using ChartJs.Blazor.Common.Enums;
using Microsoft.AspNetCore.Components;

namespace ResiWebApp.CoreTest
{
    /// <summary>
    /// A wrapper class for colorA 
    /// </summary>
    public class PieChart
    {
        private readonly Color _colorA;
        private readonly Color _colorB;
        private readonly bool _responsive;
        private readonly string _title;

        private readonly Hashtable _skippedLabelIndices;

        /// <summary>
        /// Represents the config for this
        /// <see cref="PieChart"/>.
        /// </summary>
        public PieConfig PieConfig { get; private set;}

        /// <summary>
        /// The color to blend from
        /// </summary>
        [Parameter]
        public Color ColorA { get; set; }

        /// <summary>
        /// The color to blend to.
        /// </summary>
        [Parameter]
        public Color ColorB { get; set; }

        /// <summary>
        /// The title for this <see cref="PieChart"/>
        /// </summary>
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool Responsive { get; set; }

        public IList<IBimorphObject> BimorphObjects { get;}



        /// <summary>
        /// Construct colorA <see cref="PieChart"/>. 
        /// </summary>
        public PieChart(IList<IBimorphObject> bimorphObjects)
        {
            _skippedLabelIndices = new Hashtable();

            this.BimorphObjects = bimorphObjects;
        }

        /// <summary>
        /// Creates the data set for this <see cref="PieChart"/>.
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        private IList<double> CreateData(IList<IBimorphObject> bimorphObjects, string searchString)
        {
            IList<double> data = new List<double>(bimorphObjects.Count);

            int count = 0;

            foreach (var bimorphObject in bimorphObjects)
            {

                if (_skippedLabelIndices.ContainsKey(count)) continue;

                var parameters = bimorphObject.Parameters;

                var parameter = parameters.Find(p => p.Name == searchString);

                string value = (string)parameter.Value;

                var filteredNumericalString = value.FilterNumericString();

                if (filteredNumericalString.Length == 0) continue;

                if (double.TryParse(filteredNumericalString, out double result))
                    data.Add(result);

                count++;
            }

            return data;

        }

        /// <summary>
        /// Initializes the necessary information to
        /// configure this <see cref="PieChart"/>.
        /// </summary>
        public void InitializePieConfig()
        {
            this.PieConfig = new PieConfig
            {
                Options = new PieOptions
                {
                    Responsive = this.Responsive,

                    Legend = new Legend
                    {
                        Display = true,
                        FullWidth = false,
                        Position = Position.Left
                    },

                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = this.Title,
                        FontStyle = FontStyle.Normal,
                        FontSize = 15,
                        Position = Position.Top,
                        Padding = 70
                    }
                }
            };
        }

        /// <summary>
        /// Creates the labels for this <see cref="PieChart"/> from the <paramref name="bimorphObjects"/>.
        /// </summary>
        /// <param name="bimorphObjects"></param>
        /// <param name="searchString">
        /// The search string to use, has to exist within the parameters of every bimorph object
        /// and it cant be colorA numerical string.
        /// </param>
        public void CreateLabels( string searchString)
        {
            int count = 0;
            foreach (var bimorphObject in this.BimorphObjects)
            {
                var parameters = bimorphObject.Parameters;

                var parameter = parameters.Find(p => p.Name == searchString);

                string parameterValue = (string)parameter.Value;

                if (parameterValue == null || parameterValue == " " || parameterValue == "")
                {
                    _skippedLabelIndices.Add(count, count);

                    continue;
                }

                this.PieConfig.Data.Labels.Add(parameterValue);

                count++;

            }
        }

        /// <summary>
        /// Creates the data set for this <see cref="PieChart"/>
        /// </summary>
        /// <param name="searchString"></param>
        public void CreateDataSet(string searchString)
        {
           var data = this.CreateData(this.BimorphObjects, searchString);

            var areaDataSet = new PieDataset<double>(data);

            double totalAreaObjects = data.Count;

            var colors = new string[data.Count];

            var colorToLerpFrom = this.ColorA;

            var colorToLerpTo = this.ColorB;

            for (int i = 0; i < totalAreaObjects; i++)
            {
                double t = i / totalAreaObjects;

                var color = colorToLerpFrom.LerpTo(colorToLerpTo, t);

                string colorHex = ColorUtil.ColorHexString(color.R, color.G, color.G);

                colors[i] = colorHex;
            }

            areaDataSet.BackgroundColor = colors;

            this.PieConfig.Data.Datasets.Add(areaDataSet);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Refresh()
        {
            this.PieConfig.Data.Datasets.Clear();

            this.PieConfig.Data.Labels.Clear();

            this.CreateLabels("Unit Type");

            this.CreateDataSet("Area");
        }




        
    }
}
