#pragma checksum "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ebe01dc793e5035c70330356297fad99fb2ddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Migrante.Pages_Migrante_DetailsMigrante), @"mvc.1.0.razor-page", @"/Pages/Migrante/DetailsMigrante.cshtml")]
namespace Frontend.Pages.Migrante
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
#line 1 "/home/oscar/Hackaton/Frontend/Pages/_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ebe01dc793e5035c70330356297fad99fb2ddb", @"/Pages/Migrante/DetailsMigrante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78308cacdb586f5ac717f874f2f6b3fcbcc26aa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrante_DetailsMigrante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListMigrante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Detalle de Informacion Personal</h1>\n<small>\n</small>\n<div>\n    <div class=\"row\">\n        <dt class=\"col-md-2\">\n            ");
#nullable restore
#line 11 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 14 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \n        </dd>\n    </div>\n    <div class=\"row\">\n        <dt class=\"col-md-2\">\n            ");
#nullable restore
#line 19 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 22 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \n        </dd>\n    </div>\n    <div class=\"row\">\n        <dt class=\"col-md-2\">\n            ");
#nullable restore
#line 27 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => model.migrante.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 30 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => model.migrante.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </div>\n    <div class=\"row\">\n        <dt class=\"col-md-2\">\n            ");
#nullable restore
#line 35 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => Model.migrante.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 38 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => Model.migrante.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </div>\n    <div class=\"row\">\n        <dt class=\"col-md-2\">\n            ");
#nullable restore
#line 43 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => model.migrante.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 46 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => model.migrante.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </div>\n    <div class=\"row\">\n        <dt class=\"col-md-2\">\n            ");
#nullable restore
#line 51 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayNameFor(model => model.migrante.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </dt>\n        <dd class=\"col-md-10\">\n            ");
#nullable restore
#line 54 "/home/oscar/Hackaton/Frontend/Pages/Migrante/DetailsMigrante.cshtml"
       Write(Html.DisplayFor(model => model.migrante.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </div>\n</div>\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6ebe01dc793e5035c70330356297fad99fb2ddb7572", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>Informacion Personal");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsMigranteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsMigranteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsMigranteModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsMigranteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
