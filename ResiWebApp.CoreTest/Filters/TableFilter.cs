using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Bimorph.WebApi.Core;
using Microsoft.AspNetCore.Components;

namespace ResiWebApp.CoreTest
{
    /// <summary>
    /// A class which filters data from a table.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TableFilter<T> where T: IBimorphObject
    {
        private string _valueToFilterBy;

        /// <summary>
        /// A value to filter by in a table
        /// </summary>
        [Parameter]
        public string ValueToFilterBy
        {
            get => _valueToFilterBy;

            set
            {
                _valueToFilterBy = value;

                this.Filter();
            }
        }

        /// <summary>
        /// The category the value used to filter the data
        /// from a table belongs to.
        /// </summary>
        [Parameter]
        public string CategoryToFilterBy { get; set; }

        /// <summary>
        /// A cache storing all the original data
        /// used to build the table.
        /// </summary>
        public IList<T> BimorphObjectCache { get; set; }

        /// <summary>
        /// The data that is dynamic in the table.
        /// </summary>
        //[Parameter]
        public IList<T> LiveBimorphObjects { get; set; }

        /// <summary>
        /// Construct a <see cref="TableFilter"/>.
        /// </summary>
        public TableFilter()
        {
            this.BimorphObjectCache = new List<T>();

            this.LiveBimorphObjects = new List<T>();
        }

        /// <summary>
        /// Filter and select a piece of data
        /// from a table.
        /// </summary>
        public void Filter()
        {
            var filteredObjects = new List<T>();

            bool isValueToFilterByValid = this.ValueToFilterBy != null && this.ValueToFilterBy != " " && this.ValueToFilterBy != "";

            foreach (var bimorphArea in this.BimorphObjectCache)
            {
                if (!isValueToFilterByValid)
                {
                    this.LiveBimorphObjects = this.BimorphObjectCache;

                    break;
                }

                var parameters = bimorphArea.Parameters;

                var selectedCategoryParams = parameters
                    .Where(p => p.Name == this.CategoryToFilterBy);

                var paramsWithDesiredValues = selectedCategoryParams
                    .Where(p => (string)p.Value == this.ValueToFilterBy);

                if (paramsWithDesiredValues.Any())
                    filteredObjects.Add(bimorphArea);
                
            }

            if (isValueToFilterByValid)
                this.LiveBimorphObjects = filteredObjects;

        }
    }
}
