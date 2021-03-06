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
#line 1 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using HBResi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using HBResi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using Bimorph.WebApi.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using Bimorph.WebApi.Core.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ResiWebApp.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using ResiWebApp.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
using System.Collections.ObjectModel;

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
#line 105 "C:\Users\nicho\Documents\Bimorph\Clients\HB\Apps\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
       

    private PieConfig _config;

    [Parameter]
    public string BimorphId { get; set; }

    [Parameter]
    public bool UseLatestStreamId { get; set; }


    IList<IBimorphObject> BimorphObjects;

    List<BimorphArea> bimorphAreaObjects = new List<BimorphArea>();

    List<double> areas = new List<double>();

    private IReadOnlyList<string> _categoryTypes;

    [Parameter]
    public string SelectedCategory { get; set; }

    public void FetchDataCollectionFromServer()
    {
        IList<string> categoryTypesTemp = new List<string>();

        string jObject;

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

                    string categoryCamelCase =  nameof(area.Block);

                    string categoryName = categoryCamelCase.SplitCamelCase();

                    if (!categoryTypesTemp.Contains(categoryName))
                    {
                        categoryTypesTemp.Add(categoryName);
                    }
                }

            }

            _categoryTypes = new ReadOnlyCollection<string>(categoryTypesTemp);
        }

        else
        {
            string urlGetBy = ApiEndPoints.GetNodeCollectionByIdEndPoint + BimorphId;

            jObject = BimorphApiClientService.GetRequest(urlGetBy);

            BimorphObjects = BimorphTypeFactory.CreateBimorphObjects(jObject);

            foreach (var bimorphObject in BimorphObjects)
            {
                if (bimorphObject is BimorphArea area)
                    bimorphAreaObjects.Add(area);
            }
        }



        this.CreateAreaPieChart();

    }



    private void CreateAreaPieChart()
    {

        this.ConfigurePiChart();

        this.CreatePieChartLabels();

        this.CreatePieChartDataSet(areas);

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

            string unitType = bimorphArea.UnitType;

            string areaValue = bimorphArea.Area;

            var areaCharArray = areaValue.ToCharArray();

            var filtered = areaCharArray.Where(c => char.IsDigit(c)).ToArray();

            if (double.TryParse(filtered, out double result))
            {
                if (unitType == null || unitType == " " || unitType == "")
                    continue;

                areas.Add(result);

                _config.Data.Labels.Add(unitType);
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

        Theme1 = new MatTheme()
        {
            Primary = MatThemeColors.DeepOrange._500.Value,
            Secondary = MatThemeColors.DeepOrange._500.Value,

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
