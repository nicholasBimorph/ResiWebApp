#pragma checksum "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e76ceef21f96d2ab219c660952cbde408e586c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/residashboard")]
    public partial class ResiDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Get Bimorph Object Test</h1>\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>A razor component which comunicates with the Bimorph Web API.</p>\r\n\r\n<br>\r\n<br>\r\n\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatThemeProvider>(2);
            __builder.AddAttribute(3, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTheme>(
#nullable restore
#line 32 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                          Theme1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __Blazor.HBResi.Pages.ResiDashboard.TypeInference.CreateMatTextField_0(__builder2, 6, 7, "Bimorph object Id", 8, 
#nullable restore
#line 36 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                    BimorphId

#line default
#line hidden
#nullable disable
                , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BimorphId = __value, BimorphId)), 10, () => BimorphId);
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatButton>(12);
                __builder2.AddAttribute(13, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                            this.FetchDataCollectionFromServer

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "Fetch ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\r\n    ");
                __builder2.OpenElement(18, "div");
                __Blazor.HBResi.Pages.ResiDashboard.TypeInference.CreateMatCheckbox_1(__builder2, 19, 20, "Get latest stream Id", 21, 
#nullable restore
#line 43 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                   UseLatestStreamId

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UseLatestStreamId = __value, UseLatestStreamId)), 23, () => UseLatestStreamId);
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n\r\n\r\n<br>\r\n<br>\r\n<br>");
#nullable restore
#line 55 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
 if (bimorphAreaObjects.Count!=0)
{


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MatBlazor.MatThemeProvider>(25);
            __builder.AddAttribute(26, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTheme>(
#nullable restore
#line 58 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                              Theme1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.HBResi.Pages.ResiDashboard.TypeInference.CreateMatSelectItem_2(__builder2, 28, 29, 
#nullable restore
#line 61 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                                             _categoryTypes

#line default
#line hidden
#nullable disable
                , 30, "Category type", 31, 
#nullable restore
#line 61 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                    SelectedCategory

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedCategory = __value, SelectedCategory)), 33, () => SelectedCategory);
                __builder2.AddMarkupContent(34, "\r\n        \r\n        <br>\r\n        <br>\r\n        <br>\r\n\r\n\r\n        ");
                __Blazor.HBResi.Pages.ResiDashboard.TypeInference.CreateMatTable_3(__builder2, 35, 36, 
#nullable restore
#line 68 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                          bimorphAreaObjects

#line default
#line hidden
#nullable disable
                , 37, 
#nullable restore
#line 68 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                                                                   SelectedCategory

#line default
#line hidden
#nullable disable
                , 38, "Search by category value", 39, (__builder3) => {
                    __builder3.AddMarkupContent(40, "<th>Area</th>\r\n                ");
                    __builder3.AddMarkupContent(41, "<th>Plot</th>\r\n                ");
                    __builder3.AddMarkupContent(42, "<th>Level</th>\r\n                ");
                    __builder3.AddMarkupContent(43, "<th>Block</th>\r\n                ");
                    __builder3.AddMarkupContent(44, "<th>Unit Type</th>\r\n                ");
                    __builder3.AddMarkupContent(45, "<th>Area Type</th>\r\n                ");
                    __builder3.AddMarkupContent(46, "<th>Accessibility Type</th>\r\n                ");
                    __builder3.AddMarkupContent(47, "<th>Space Type</th>\r\n                ");
                    __builder3.AddMarkupContent(48, "<th>Tenure</th>");
                }
                , 49, (context) => (__builder3) => {
                    __builder3.OpenElement(50, "td");
                    __builder3.AddContent(51, 
#nullable restore
#line 82 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.Area

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, " \r\n                ");
                    __builder3.OpenElement(53, "td");
                    __builder3.AddContent(54, 
#nullable restore
#line 83 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.Plot

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\r\n                ");
                    __builder3.OpenElement(56, "td");
                    __builder3.AddContent(57, 
#nullable restore
#line 84 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.Level

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n                ");
                    __builder3.OpenElement(59, "td");
                    __builder3.AddContent(60, 
#nullable restore
#line 85 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.Block

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n                ");
                    __builder3.OpenElement(62, "td");
                    __builder3.AddContent(63, 
#nullable restore
#line 86 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.UnitType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\r\n                ");
                    __builder3.OpenElement(65, "td");
                    __builder3.AddContent(66, 
#nullable restore
#line 87 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.AreaType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                ");
                    __builder3.OpenElement(68, "td");
                    __builder3.AddContent(69, 
#nullable restore
#line 88 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.AccessibilityType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\r\n                ");
                    __builder3.OpenElement(71, "td");
                    __builder3.AddContent(72, 
#nullable restore
#line 89 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.SpaceType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n                ");
                    __builder3.OpenElement(74, "td");
                    __builder3.AddContent(75, 
#nullable restore
#line 90 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                     context.Tenure

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "<br>\r\n    <br>\r\n    <br>");
            __builder.OpenComponent<ChartJs.Blazor.Chart>(77);
            __builder.AddAttribute(78, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 100 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
                   _config

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 101 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\NicholasRawitscher\source\repos\ResiWebApp\HBResi\Pages\ResiDashboard.razor"
       

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
namespace __Blazor.HBResi.Pages.ResiDashboard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatSelectItem_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TValue> __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTable_3<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "FilterByColumnName", __arg1);
        __builder.AddAttribute(__seq2, "SearchTermFieldLabel", __arg2);
        __builder.AddAttribute(__seq3, "MatTableHeader", __arg3);
        __builder.AddAttribute(__seq4, "MatTableRow", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
