#pragma checksum "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a025593e57e67e6df5803c877c57c8f87baec52"
// <auto-generated/>
#pragma warning disable 1591
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
using ResiWebApp.Core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/residashboard")]
    public partial class ResiDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Get Bimorph Object Test</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>A razor component which comunicates with the Bimorph Web API.</p>\r\n\r\n\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "placeholder", "Bimorph object Id");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                              BimorphId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BimorphId = __value, BimorphId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                          this.FetchDataCollectionFromServer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Fetch ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, " \r\n\r\n<br> \r\n\r\n\r\n<br>\r\n\r\n\r\n\r\n<br>\r\n<br>\r\n<br>");
#nullable restore
#line 39 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
 if (BimorphObjects != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, @"<thead><tr><th> Area</th>
            <th> Level</th>
            <th> Block</th>
            <th> Unit Type</th>
            <th>Area Type</th>
            <th>Accessibility Type</th>
            <th>Space Type</th>
            <th>Tenure</th></tr></thead>

        ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 58 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
         foreach (var bimorphObject in BimorphObjects)
        {
            if (bimorphObject is BimorphArea area)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 63 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.Area

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 64 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.Level

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 65 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.Block

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 66 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.UnitType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 67 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.AreaType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 68 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.AccessibilityType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 69 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.SpaceType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 70 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                         area.Tenure

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<ChartJs.Blazor.Chart>(40);
            __builder.AddAttribute(41, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 80 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                   _config

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 81 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
       

    private PieConfig _config;

    [Parameter]
    public string BimorphId { get; set; }


    IList<IBimorphObject> BimorphObjects;

    List<BimorphArea> bimorphAreaObjects = new List<BimorphArea>();

    List<double> areas = new List<double>();

    public void FetchDataCollectionFromServer()
    {

        string urlGetBy = ApiEndPoints.GetNodeCollectionByIdEndPoint + BimorphId;

        string jObject = WebClientService.GetRequest(urlGetBy);

        BimorphObjects = BimorphTypeFactory.CreateBimorphObjects(jObject);


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
                AspectRatio = 3,

                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Areas by unit types"
                }
            }
        };
    }

    private void CreatePieChartLabels()
    {
        foreach (var bimorphObject in BimorphObjects)
        {
            if (bimorphObject is BimorphArea area)
            {
                bimorphAreaObjects.Add(area);

                string unitType = area.UnitType;

                string areaValue = area.Area;

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

    }


    private void CreatePieChartDataSet(IList<double> data )
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BimorphTypeFactory BimorphTypeFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebClientService WebClientService { get; set; }
    }
}
#pragma warning restore 1591
