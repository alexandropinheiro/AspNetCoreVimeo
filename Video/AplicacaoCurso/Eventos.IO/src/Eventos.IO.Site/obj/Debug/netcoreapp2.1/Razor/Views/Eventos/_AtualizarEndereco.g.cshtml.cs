#pragma checksum "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_AtualizarEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd114eeaa5580674e2b5f658a0358189e72f5cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos__AtualizarEndereco), @"mvc.1.0.view", @"/Views/Eventos/_AtualizarEndereco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/_AtualizarEndereco.cshtml", typeof(AspNetCore.Views_Eventos__AtualizarEndereco))]
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
#line 1 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_AtualizarEndereco.cshtml"
using Eventos.IO.Application.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd114eeaa5580674e2b5f658a0358189e72f5cd", @"/Views/Eventos/_AtualizarEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742d3e1e35673a62823951f98bdb533bb24d7e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos__AtualizarEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventoViewModel>
    {
        private global::AspNetCore.Views_Eventos__AtualizarEndereco.__Generated__SummaryViewComponentTagHelper __SummaryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 17, false);
#line 4 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_AtualizarEndereco.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
#line 4 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_AtualizarEndereco.cshtml"
                       = "Atualizar Endereço";

#line default
#line hidden
            BeginContext(123, 214, true);
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\">\r\n        <span aria-hidden=\"true\">x</span><span class=\"sr-only\">Fechar</span>\r\n    </button>\r\n    <h4 class=\"modal-title\">");
            EndContext();
            BeginContext(338, 17, false);
#line 11 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_AtualizarEndereco.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(355, 17, true);
            WriteLiteral("</h4>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(372, 554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e57ba4e707cd4a6fa4bb8c3b50a76a87", async() => {
                BeginContext(409, 83, true);
                WriteLiteral("\r\n    <div class=\"modal-body\">\r\n        <div class=\"form-horizontal\">\r\n            ");
                EndContext();
                BeginContext(492, 14, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:summary", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed33ac523ce3477a8b5f7efce7b48b3b", async() => {
                }
                );
                __SummaryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Eventos__AtualizarEndereco.__Generated__SummaryViewComponentTagHelper>();
                __tagHelperExecutionContext.Add(__SummaryViewComponentTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(506, 16, true);
                WriteLiteral("\r\n\r\n            ");
                EndContext();
                BeginContext(523, 25, false);
#line 19 "C:\Alexandro\Aprendizado\Eduardo Pires\AspNetCoreVimeo\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_AtualizarEndereco.cshtml"
       Write(Html.Partial("_Endereco"));

#line default
#line hidden
                EndContext();
                BeginContext(548, 371, true);
                WriteLiteral(@"

            <div class=""modal-footer"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Atualizar Endereço"" class=""btn btn-success"" />
                    <input type=""button"" class=""btn btn-info"" value=""Fechar"" data-dismiss=""modal"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:summary")]
        public class __Generated__SummaryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__SummaryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Summary", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
