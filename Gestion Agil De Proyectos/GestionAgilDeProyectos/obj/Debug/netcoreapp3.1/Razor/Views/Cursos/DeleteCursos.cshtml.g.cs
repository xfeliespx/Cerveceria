#pragma checksum "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d82412896c7d5db7605b66f84eec7468f8f6a1a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_DeleteCursos), @"mvc.1.0.view", @"/Views/Cursos/DeleteCursos.cshtml")]
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
#line 1 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\_ViewImports.cshtml"
using GestionAgilDeProyectos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
using GestionAgilDeProyectos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82412896c7d5db7605b66f84eec7468f8f6a1a4", @"/Views/Cursos/DeleteCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca18651170f8a18645462b77e0c7ed3d70169e00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cursos_DeleteCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cursos>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MenuSistema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCursos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
  
    ViewData["Title"] = "Eliminar Curso";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d82412896c7d5db7605b66f84eec7468f8f6a1a45694", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.11.2/css/all.css\" />\r\n    <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700&display=swap\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d82412896c7d5db7605b66f84eec7468f8f6a1a46887", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""pricing-area pt-100"">
    <div class=""container"">
        <div class=""row gx-5"">
            <aside class=""col-lg-6"">
                <div class=""border rounded-4 mb-3 d-flex justify-content-center"">
                    <a data-fslightbox=""mygalley"" class=""rounded-4"" target=""_blank"" data-type=""image""");
            BeginWriteAttribute("href", " href=\"", 690, "\"", 724, 1);
#nullable restore
#line 16 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
WriteAttributeValue("", 697, Url.Content(Model.Portada), 697, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img style=\"max-width: 100%; max-height: 100vh; margin: auto;\" class=\"rounded-4 fit\"");
            BeginWriteAttribute("src", " src=\"", 836, "\"", 869, 1);
#nullable restore
#line 17 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
WriteAttributeValue("", 842, Url.Content(Model.Portada), 842, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </a>\r\n                </div>\r\n                <div class=\"d-flex justify-content-center mb-3\">\r\n                    <a data-fslightbox=\"mygalley\" class=\"border mx-1 rounded-2\" target=\"_blank\" data-type=\"image\"");
            BeginWriteAttribute("href", " href=\"", 1104, "\"", 1135, 1);
#nullable restore
#line 21 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
WriteAttributeValue("", 1111, Url.Content(Model.Logo), 1111, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item-thumb\">\r\n                        <img width=\"200\" height=\"150\" class=\"rounded-2\"");
            BeginWriteAttribute("src", " src=\"", 1229, "\"", 1259, 1);
#nullable restore
#line 22 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
WriteAttributeValue("", 1235, Url.Content(Model.Logo), 1235, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </a>\r\n                </div>\r\n            </aside>\r\n            <main class=\"col-lg-6\">\r\n                <div class=\"ps-lg-3\">\r\n                    <h4 class=\"title text-dark\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
                   Write(Html.DisplayFor(item => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                    <div class=""d-flex flex-row my-3"">
                        <div class=""text-warning mb-1 me-2"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fas fa-star-half-alt""></i>
                            <span class=""ms-1"">
                                4.5
                            </span>
                        </div>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <span class=""text-success ms-2"">");
#nullable restore
#line 43 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
                                                   Write(Html.DisplayFor(item => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"mb-3\">\r\n                        <span class=\"h5\">");
#nullable restore
#line 46 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
                                    Write(Html.DisplayFor(item => item.ValorPeso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"text-muted\">/Por Mes</span>\r\n                    </div>\r\n                    <p>");
#nullable restore
#line 49 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
                  Write(Html.DisplayFor(item => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </br>\r\n                    <div class=\"row\">\r\n                        <dt class=\"col-3\">Nombre Curso</dt>\r\n                        <dd class=\"col-9\">");
#nullable restore
#line 53 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
                                     Write(Html.DisplayFor(item => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                        <dt class=\"col-3\">Direccion</dt>\r\n                        <dd class=\"col-9\">");
#nullable restore
#line 55 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
                                     Write(Html.DisplayFor(item => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"row mb-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d82412896c7d5db7605b66f84eec7468f8f6a1a413866", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d82412896c7d5db7605b66f84eec7468f8f6a1a414153", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 60 "C:\Users\ibane\Desktop\Gestion Agil De Proyectos\GestionAgilDeProyectos\Views\Cursos\DeleteCursos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-danger\" value=\"Eliminar\">Eliminar</button> |\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d82412896c7d5db7605b66f84eec7468f8f6a1a416023", async() => {
                    WriteLiteral("Volver");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </main>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cursos> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
