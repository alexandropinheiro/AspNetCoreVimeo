#pragma checksum "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a08071f393d3af0b879d2c04ca323dbb4f3b3f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_MeusEventos), @"mvc.1.0.view", @"/Views/Eventos/MeusEventos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/MeusEventos.cshtml", typeof(AspNetCore.Views_Eventos_MeusEventos))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Site;

#line default
#line hidden
#line 3 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models;

#line default
#line hidden
#line 4 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a08071f393d3af0b879d2c04ca323dbb4f3b3f6", @"/Views/Eventos/MeusEventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742d3e1e35673a62823951f98bdb533bb24d7e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_MeusEventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
  
    ViewData["Title"] = "Meus Eventos";

#line default
#line hidden
            BeginContext(119, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(126, 17, false);
#line 6 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(143, 102, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"pull-left\">\r\n            ");
            EndContext();
            BeginContext(245, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2799ca8e04c54063a3c16255ee20f59c", async() => {
                BeginContext(292, 103, true);
                WriteLiteral("\r\n                <span title=\"Novo Evento\" class=\"glyphicon glyphicon-plus-sign\"></span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(399, 124, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(524, 40, false);
#line 22 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(564, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(620, 46, false);
#line 25 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
           Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(666, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(722, 43, false);
#line 28 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
           Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(765, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(821, 41, false);
#line 31 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(862, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(918, 42, false);
#line 34 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
           Write(Html.DisplayNameFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(960, 94, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>        \r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1094, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1155, 39, false);
#line 43 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1262, 29, false);
#line 46 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
               Write(item.DataInicio.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1359, 26, false);
#line 49 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
               Write(item.DataFim.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 52 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                      
                        if (item.Gratuito)
                        {
                            

#line default
#line hidden
            BeginContext(1556, 28, false);
#line 55 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                       Write(Html.DisplayName("Gratuito"));

#line default
#line hidden
            EndContext();
#line 55 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                                                         
                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(1699, 40, false);
#line 59 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
#line 59 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                                                                     
                        }
                    

#line default
#line hidden
            BeginContext(1791, 77, true);
            WriteLiteral("                </td>            \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1869, 41, false);
#line 64 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Online));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1977, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87311f202f494043be757789e7c4e22c", async() => {
                BeginContext(2046, 97, true);
                WriteLiteral("\r\n                        <span class=\"glyphicon glyphicon-pencil\"></span> \r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2147, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2169, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35a97091a88841b0ac3fca48be39bb79", async() => {
                BeginContext(2241, 96, true);
                WriteLiteral("\r\n                        <span class=\"glyphicon glyphicon-search\"></span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2341, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2363, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c9a792d5ae42dd85801d446bc3078c", async() => {
                BeginContext(2433, 95, true);
                WriteLiteral("\r\n                        <span class=\"glyphicon glyphicon-trash\"></span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2532, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 78 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\MeusEventos.cshtml"
        }

#line default
#line hidden
            BeginContext(2587, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
