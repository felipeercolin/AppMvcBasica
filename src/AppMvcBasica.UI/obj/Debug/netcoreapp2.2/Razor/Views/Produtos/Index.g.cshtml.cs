#pragma checksum "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce556a288e4937775858ae83af5be1e56e37269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Index), @"mvc.1.0.view", @"/Views/Produtos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Index.cshtml", typeof(AspNetCore.Views_Produtos_Index))]
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
#line 1 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\_ViewImports.cshtml"
using AppMvcBasica.UI;

#line default
#line hidden
#line 2 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\_ViewImports.cshtml"
using AppMvcBasica.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce556a288e4937775858ae83af5be1e56e37269", @"/Views/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204892c5fae42dce007dfe644d3c1a8205e485aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppMvcBasica.UI.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
  
    ViewData["Title"] = "Lista de Produtos";

#line default
#line hidden
            BeginContext(107, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(114, 17, false);
#line 7 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(131, 18, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(149, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ce556a288e4937775858ae83af5be1e56e372696850", async() => {
                BeginContext(200, 12, true);
                WriteLiteral("Novo Produto");
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
            BeginContext(216, 105, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(322, 40, false);
#line 15 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(362, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(386, 41, false);
#line 16 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(427, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(451, 40, false);
#line 17 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(491, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(515, 41, false);
#line 18 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(556, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(580, 46, false);
#line 19 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(626, 72, true);
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(730, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(761, 39, false);
#line 26 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(800, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(824, 40, false);
#line 27 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(864, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(888, 39, false);
#line 28 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(927, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(951, 40, false);
#line 29 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(991, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1015, 50, false);
#line 30 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fornecedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 108, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">\r\n                <div class=\"btn-group-sm\">\r\n                    ");
            EndContext();
            BeginContext(1173, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ce556a288e4937775858ae83af5be1e56e3726913487", async() => {
                BeginContext(1242, 6, true);
                WriteLiteral("Editar");
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
#line 33 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
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
            BeginContext(1252, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1274, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ce556a288e4937775858ae83af5be1e56e3726915998", async() => {
                BeginContext(1343, 8, true);
                WriteLiteral("Detalhes");
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
#line 34 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1355, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1377, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ce556a288e4937775858ae83af5be1e56e3726918514", async() => {
                BeginContext(1447, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1458, 60, true);
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\AppMvcBasica\src\AppMvcBasica.UI\Views\Produtos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1521, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppMvcBasica.UI.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591