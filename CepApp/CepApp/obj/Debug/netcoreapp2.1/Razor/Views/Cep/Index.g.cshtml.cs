#pragma checksum "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451b0582e98e85271cea87ccbe06f4ede4eb99db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cep_Index), @"mvc.1.0.view", @"/Views/Cep/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cep/Index.cshtml", typeof(AspNetCore.Views_Cep_Index))]
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
#line 1 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\_ViewImports.cshtml"
using CepApp;

#line default
#line hidden
#line 2 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\_ViewImports.cshtml"
using CepApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451b0582e98e85271cea87ccbe06f4ede4eb99db", @"/Views/Cep/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee118eb73ec3d5d832f078d71fa95495609acd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cep_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CepApp.Models.CEP>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultarCep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(80, 91, true);
            WriteLiteral("<h2>Consultar e Cadastrar CEP</h2>\r\n<div style=\"margin-top: 30px;\" class=\"container\">\r\n    ");
            EndContext();
            BeginContext(171, 352, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a75e8bc80304b129109c7a3a8b1900a", async() => {
                BeginContext(203, 313, true);
                WriteLiteral(@"
        <label for=""cepNumero"">CEP</label>
        <input type=""text"" class=""text-capitalize"" name=""cepNumero"" id=""cepNumero"" placeholder=""Insira o CEP para consulta"" />
        <br />
        <br />
        <input type=""submit"" value=""Consultar e Cadastrar"" class=""btn btn-success"" />
        <hr />
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
            BeginContext(523, 94, true);
            WriteLiteral("\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(618, 39, false);
#line 20 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(657, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(713, 46, false);
#line 23 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(759, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(815, 47, false);
#line 26 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(862, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(918, 42, false);
#line 29 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(960, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1016, 46, false);
#line 32 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Localidade));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1118, 38, false);
#line 35 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Uf));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1291, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1340, 38, false);
#line 45 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1434, 45, false);
#line 48 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1535, 46, false);
#line 51 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1637, 41, false);
#line 54 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1734, 45, false);
#line 57 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Localidade));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1835, 37, false);
#line 60 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uf));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Aluno\Source\Repos\AulaPresencialAtividade2\CepApp\CepApp\Views\Cep\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1919, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CepApp.Models.CEP>> Html { get; private set; }
    }
}
#pragma warning restore 1591
