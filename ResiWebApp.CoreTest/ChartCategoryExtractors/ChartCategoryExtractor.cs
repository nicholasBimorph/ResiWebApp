using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bimorph.WebApi.Core;

namespace ResiWebApp.CoreTest
{

    public class ChartCategoryExtractor
    {
        /// <summary>
        /// Extracts all the <see cref="IParameter"/> names
        /// for the <paramref name="bimorphObject"/>, which will
        /// represent the overall available categories for a
        /// chart.
        /// </summary>
        public IList<string> Extract(IBimorphObject bimorphObject)
        {
            var categoryTypesDictionary = new Dictionary<string,string>();

            var parameters = bimorphObject.Parameters;

            foreach (var parameter in parameters)
            {
                string categoryNameCamelcase = parameter.Name;

                if (!categoryTypesDictionary.ContainsKey(categoryNameCamelcase))
                    categoryTypesDictionary.Add(categoryNameCamelcase, categoryNameCamelcase);
            }

            return categoryTypesDictionary.Values.ToList();
        }
    }
}
