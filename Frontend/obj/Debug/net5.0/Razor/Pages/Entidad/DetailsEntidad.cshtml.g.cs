#pragma checksum "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f09abafd32dd403a4d2e6f90f0a95f17b870681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Entidad.Pages_Entidad_DetailsEntidad), @"mvc.1.0.razor-page", @"/Pages/Entidad/DetailsEntidad.cshtml")]
namespace Frontend.Pages.Entidad
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f09abafd32dd403a4d2e6f90f0a95f17b870681", @"/Pages/Entidad/DetailsEntidad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Entidad_DetailsEntidad : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Listentidad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle de Informacion Entidad</h1>\r\n<small>\r\n</small>\r\n<div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 11 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => Model.entidad.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 14 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => Model.entidad.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 19 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => Model.entidad.RazonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 22 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => Model.entidad.RazonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 27 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => model.entidad.Nit));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 30 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => model.entidad.Nit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 35 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => Model.entidad.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 38 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => Model.entidad.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 43 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => model.entidad.Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 46 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => model.entidad.Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 51 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => model.entidad.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 54 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => model.entidad.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 59 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => model.entidad.PaginaWeb));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 62 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => model.entidad.PaginaWeb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 67 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => model.entidad.Sector));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 70 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => model.entidad.Sector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 75 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayNameFor(model => model.entidad.Servicios));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 78 "C:\hackaton\e-migrant-grupo25_rocket\Frontend\Pages\Entidad\DetailsEntidad.cshtml"
       Write(Html.DisplayFor(model => model.entidad.Servicios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n</div>\r\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f09abafd32dd403a4d2e6f90f0a95f17b87068110114", async() => {
                WriteLiteral("<i class=\"fas fa-angle-double-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsEntidadModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsEntidadModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsEntidadModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsEntidadModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591