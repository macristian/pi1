#pragma checksum "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86275772de642f12e594ed6b2f3422560235779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_Listar), @"mvc.1.0.view", @"/Views/Cursos/Listar.cshtml")]
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
#nullable restore
#line 1 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\_ViewImports.cshtml"
using Scisense;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\_ViewImports.cshtml"
using Scisense.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86275772de642f12e594ed6b2f3422560235779", @"/Views/Cursos/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e223a1d3ddb8bf5551c372967df0f24321bd213c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cursos_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cursos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner-cursos.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
  

    ViewData["Title"] = "Cursos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a86275772de642f12e594ed6b2f34225602357795897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<br>\n\n");
#nullable restore
#line 13 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
Write(ViewBag.MsgExcluirC);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row d-flex justify-content-center\">\n");
#nullable restore
#line 16 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
         foreach (Cursos c in Model)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-3 mr-3\" style=\"width: 20rem;\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 421, "\"", 442, 1);
#nullable restore
#line 20 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
WriteAttributeValue("", 427, c.ThumbnailUri, 427, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 464, "\"", 483, 1);
#nullable restore
#line 20 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
WriteAttributeValue("", 470, c.NameCourse, 470, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 22 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
                                      Write(c.NameCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
                                                    Write(c.Workload);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p>Código: ");
#nullable restore
#line 23 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
                          Write(c.IdCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                    <p class=\"card-text\">");
#nullable restore
#line 25 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
                                    Write(c.DetailsCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 26 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
                     if (Context.Session.GetString("idAdm") != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 870, 2);
            WriteAttributeValue("", 834, "/Cursos/Excluir?IdCourse=", 834, 25, true);
#nullable restore
#line 28 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
WriteAttributeValue("", 859, c.IdCourse, 859, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Excluir</a>\n");
#nullable restore
#line 29 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"
                     if (Context.Session.GetString("idAdm") == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a86275772de642f12e594ed6b2f342256023577911544", async() => {
                WriteLiteral("Tenho\n                            interesse");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 35 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n");
#nullable restore
#line 39 "G:\CBS\Cursos\SENAC\Técnico em Informática para Internet\01 - IPI-M1\Módulo 1 - Atividades\Etapa 3\Scisense\Views\Cursos\Listar.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cursos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
