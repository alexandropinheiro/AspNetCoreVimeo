#pragma checksum "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Categorias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e8ee95b41507955ae3da7265b0081dc23ee3f5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos__Categorias), @"mvc.1.0.view", @"/Views/Eventos/_Categorias.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/_Categorias.cshtml", typeof(AspNetCore.Views_Eventos__Categorias))]
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
#line 1 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Site;

#line default
#line hidden
#line 3 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models;

#line default
#line hidden
#line 4 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models.ManageViewModels;

#line default
#line hidden
#line 1 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Categorias.cshtml"
using Eventos.IO.Application.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e8ee95b41507955ae3da7265b0081dc23ee3f5d", @"/Views/Eventos/_Categorias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742d3e1e35673a62823951f98bdb533bb24d7e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos__Categorias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventos.IO.Application.ViewModels.EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Categorias.cshtml"
  
    var categoriaViewModel = new CategoriaViewModel();
    var categorias = (IEnumerable<SelectListItem>)categoriaViewModel.ListarCategorias();

#line default
#line hidden
            BeginContext(254, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "789e4c6b91884a1b9b40f00610c82139", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 7 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Categorias.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoriaId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Aprendizado\Eduardo Pires\Video\AplicacaoCurso\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Categorias.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = categorias;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(338, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventos.IO.Application.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
