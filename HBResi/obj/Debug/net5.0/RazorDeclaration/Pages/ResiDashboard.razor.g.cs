// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HBResi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using HBResi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using HBResi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using Bimorph.WebApi.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using Bimorph.WebApi.Core.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ResiWebApp.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ResiWebApp.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using Microsoft.AspNetCore.Server.IIS.Core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/residashboard")]
    public partial class ResiDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
       

    private PieConfig _config;

    private readonly List<BimorphArea> _bimorphAreaCache = new List<BimorphArea>();

    [Parameter]
    public string BimorphId { get; set; }

    private string _valueToFilterBy;

    [Parameter]
    public string ValueToFilterBy
    {
        get => _valueToFilterBy;

        set
        {
            _valueToFilterBy = value;

            this.Filter();

            this.RefreshPieChart();
        }
    }

    [Parameter]
    public bool UseLatestStreamId { get; set; }

    IList<IBimorphObject> BimorphObjects;

    List<BimorphArea> bimorphAreaObjects = new List<BimorphArea>();

    readonly List<double> areas = new List<double>();

    private IReadOnlyList<string> _categoryTypes;

    [Parameter]
    public string SelectedCategory { get; set; }

    private void Filter()
    {
        var filteredObjects = new List<BimorphArea>();

        bool isValueToFilterByValid = ValueToFilterBy != null && ValueToFilterBy != " " && ValueToFilterBy != "";

        foreach (var bimorphArea in _bimorphAreaCache)
        {
            if (!isValueToFilterByValid)
            {
                bimorphAreaObjects = _bimorphAreaCache;

                break;
            }

            var parameters = bimorphArea.Parameters;

            var selectedCategoryParams = parameters
                .Where(p => p.Name == SelectedCategory);

            var paramsWithDesiredValues = selectedCategoryParams
                .Where(p => (string) p.Value == ValueToFilterBy);

            if (paramsWithDesiredValues.Any())
            {
                filteredObjects.Add(bimorphArea);
            }
        }

        if (isValueToFilterByValid)
            bimorphAreaObjects = filteredObjects;
    }

    public void FetchDataCollectionFromServer()
    {
        string jObject;

        bool extractedCategories = false;

        if (UseLatestStreamId)
        {
            string urlGetLatest = ApiEndPoints.GetLatestNodeCollectionEndPoint;

            jObject = BimorphApiClientService.GetRequest(urlGetLatest);

            BimorphObjects = BimorphTypeFactory.CreateBimorphObjects(jObject);

            foreach (var bimorphObject in BimorphObjects)
            {
                if (bimorphObject is BimorphArea area)
                {
                    bimorphAreaObjects.Add(area);

                    _bimorphAreaCache.Add(area);

                    if (extractedCategories) continue;

                    _categoryTypes = new ReadOnlyCollection<string>(ExtractCategoriesForTable(area));

                    extractedCategories = true;
                }
            }
        }

        else
        {
            string urlGetBy = ApiEndPoints.GetNodeCollectionByIdEndPoint + BimorphId;

            jObject = BimorphApiClientService.GetRequest(urlGetBy);

            BimorphObjects = BimorphTypeFactory.CreateBimorphObjects(jObject);

            foreach (var bimorphObject in BimorphObjects)
            {
                if (bimorphObject is BimorphArea area)
                {
                    bimorphAreaObjects.Add(area);

                    _bimorphAreaCache.Add(area);

                    if (extractedCategories) continue;

                    _categoryTypes = new ReadOnlyCollection<string>(ExtractCategoriesForTable(area));

                    extractedCategories = true;
                }
            }
        }

        CreateAreaPieChart();
    }

    /// <summary>
    /// Extracts all the column header categories that will be available
    /// </summary>
    /// <param name="bimorphObject"></param>
    /// <returns></returns>
    private IList<string> ExtractCategoriesForTable(BimorphArea bimorphObject)
    {
        IList<string> categoryTypesTemp = new List<string>();

        var parameters = bimorphObject.Parameters;

        foreach (var parameter in parameters)
        {
            string categoryNameCamelcase = parameter.Name;

            if (!categoryTypesTemp.Contains(categoryNameCamelcase))
                categoryTypesTemp.Add(categoryNameCamelcase);
        }

        return categoryTypesTemp;
    }

    private void CreateAreaPieChart()
    {
        ConfigurePiChart();

        CreatePieChartLabels();

        CreatePieChartDataSet(areas);
    }

    private void RefreshPieChart()
    {
        
        _config.Data.Datasets.Clear();

        _config.Data.Labels.Clear();

        areas.Clear();

        CreatePieChartLabels();

        CreatePieChartDataSet(areas);
    }

    private void ConfigurePiChart()
    {
        _config = new PieConfig
        {
            Options = new PieOptions
            {
                Responsive = true,
    //AspectRatio = 3,


                Legend = new Legend
                {
                    Display = true,
                    FullWidth = false,
                    Position = Position.Left
                },
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Areas by unit types",
                    FontStyle = FontStyle.Normal,
                    FontSize = 15,
                    Position = Position.Top,
                    Padding = 70
                }
            }
        };
    }

    private void CreatePieChartLabels()
    {
        foreach (var bimorphArea in bimorphAreaObjects)
        {
            var parameters = bimorphArea.Parameters;

            var unitTypeParameter = parameters.Find(p => p.Name == "Unit Type");
            string unitTypeValue = (string) unitTypeParameter.Value;

            var areaParameter = parameters.Find(p => p.Name == "Area");
            string areaValue = (string) areaParameter.Value;

            var areaCharArray = areaValue.ToCharArray();

            var filtered = areaCharArray.Where(c => char.IsDigit(c)).ToArray();

            if (double.TryParse(filtered, out double result))
            {
                if (unitTypeValue == null || unitTypeValue == " " || unitTypeValue == "")
                    continue;

                areas.Add(result);

                _config.Data.Labels.Add(unitTypeValue);
            }
        }
    }

    private void CreatePieChartDataSet(IList<double> data)
    {
        PieDataset<double> areaDataSet = new PieDataset<double>(data);

        double totalAreaObjects = data.Count;

        var colors = new string[data.Count];

        var colorToLerpFrom = Color.FromArgb(255, 170, 0, 200);

        var colorToLerpTo = Color.FromArgb(255, 8, 130, 212);

        for (int i = 0; i < totalAreaObjects; i++)
        {
            double t = i / totalAreaObjects;

            var color = colorToLerpFrom.LerpTo(colorToLerpTo, t);

            string colorHex = ColorUtil.ColorHexString(color.R, color.G, color.G);

            colors[i] = colorHex;
        }

        areaDataSet.BackgroundColor = colors;

        _config.Data.Datasets.Add(areaDataSet);
    }

    public MatTheme Theme1;

    /// <summary>
    /// Method invoked when the component is ready to start, having received its
    /// initial parameters from its parent in the render tree.
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();

        Theme1 = new MatTheme
        {
            Primary = MatThemeColors.DeepOrange._500.Value,
            Secondary = MatThemeColors.DeepOrange._500.Value
        };
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BimorphTypeFactory BimorphTypeFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BimorphAPIClientService BimorphApiClientService { get; set; }
    }
}
#pragma warning restore 1591
