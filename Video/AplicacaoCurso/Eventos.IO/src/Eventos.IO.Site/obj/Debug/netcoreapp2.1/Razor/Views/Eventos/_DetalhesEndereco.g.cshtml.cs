#pragma checksum "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894b624c6ce28cce610e78d1953914c561014ab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos__DetalhesEndereco), @"mvc.1.0.view", @"/Views/Eventos/_DetalhesEndereco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/_DetalhesEndereco.cshtml", typeof(AspNetCore.Views_Eventos__DetalhesEndereco))]
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
#line 1 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
using Eventos.IO.Application.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894b624c6ce28cce610e78d1953914c561014ab1", @"/Views/Eventos/_DetalhesEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742d3e1e35673a62823951f98bdb533bb24d7e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos__DetalhesEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncluirEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 129, true);
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <strong>Endereço do Evento</strong>\r\n    </div>\r\n\r\n");
            EndContext();
#line 10 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
     if (Model.Endereco != null){

#line default
#line hidden
            BeginContext(233, 103, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(337, 55, false);
#line 14 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(392, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(460, 51, false);
#line 17 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(511, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(579, 56, false);
#line 20 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(635, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(703, 51, false);
#line 23 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(754, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(822, 48, false);
#line 26 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(870, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(938, 51, false);
#line 29 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(989, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1057, 51, false);
#line 32 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 133, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1242, 51, false);
#line 39 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1361, 47, false);
#line 42 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1476, 52, false);
#line 45 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1596, 47, false);
#line 48 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1711, 44, false);
#line 51 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1823, 47, false);
#line 54 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1938, 47, false);
#line 57 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 98, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2083, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11402a105ca54fb0ba5165c2f112132d", async() => {
                BeginContext(2180, 119, true);
                WriteLiteral("\r\n                            <span title=\"Editar\" class=\"glyphicon glyphicon-pencil\"></span>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-modal", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2303, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 68 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
    }else{

#line default
#line hidden
            BeginContext(2405, 77, true);
            WriteLiteral("        <table>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2482, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b976a09c2740de9820f4a3f7477bab", async() => {
                BeginContext(2574, 133, true);
                WriteLiteral("\r\n                        <span title=\"Editar\" class=\"glyphicon glyphicon-plus-sign\"></span> Adicionar Endereço\r\n                    ");
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
#line 72 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
                                                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-modal", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2711, 62, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 78 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_DetalhesEndereco.cshtml"
             
    }

#line default
#line hidden
            BeginContext(2795, 45, true);
            WriteLiteral("</div>\r\n<script>\r\n    ajaxModal();\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
