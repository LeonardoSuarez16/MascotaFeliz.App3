#pragma checksum "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c4cd942da970cf95d4aa357669dec27b2fa4fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Duenos.Pages_Duenos_ListaDuenos), @"mvc.1.0.razor-page", @"/Pages/Duenos/ListaDuenos.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Duenos
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
#line 1 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c4cd942da970cf95d4aa357669dec27b2fa4fa", @"/Pages/Duenos/ListaDuenos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90b2b40ba8c1257b37c8db6b0a6d90a6076caca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Duenos_ListaDuenos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Duenos/DetallesDuenos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Duenos/ActualizarDuenos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-cards"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<section>\n    <h1> LISTADO DE DUE??OS </h1>\n    <div class=\"row row-cols-1 row-cols-md-4 g-4\">\n");
#nullable restore
#line 9 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
     foreach (var dn in Model.ListaDuenos){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\">\n            <div class=\"card h-100\"  style=\"background-color:#DCDCDC;\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                      Write(dn.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                                  Write(dn.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <spam class=\"card-text\" style=\"font-weight: 700;\">Id: </spam>\n                    <spam class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                       Write(dn.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</spam> <br>\n                    <spam class=\"card-text\" style=\"font-weight: 700;\">Nombres: </spam>\n                    <spam class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                       Write(dn.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</spam> <br>\n                    <spam class=\"card-text\" style=\"font-weight: 700;\">Apellidos: </spam>\n                    <spam class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                       Write(dn.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</spam> <br>              \n                    <spam class=\"card-text\" style=\"font-weight: 700;\">Direccion: </spam>\n                    <spam class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                       Write(dn.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</spam> <br>                                        \n                    <spam class=\"card-text\" style=\"font-weight: 700;\">Telefono: </spam>\n                    <spam class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                       Write(dn.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</spam> <br>\n                    <spam class=\"card-text\" style=\"font-weight: 700;\">Correo: </spam>\n                    <spam class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
                                       Write(dn.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</spam> <br>                                                            \n                    <div style=\"margin-top: 1rem; text-align:center\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c4cd942da970cf95d4aa357669dec27b2fa4fa9496", async() => {
                WriteLiteral("\n                            <input type=\"hidden\" name=\"idDueno\"");
                BeginWriteAttribute("value", " value=\"", 1656, "\"", 1670, 1);
#nullable restore
#line 28 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
WriteAttributeValue("", 1664, dn.Id, 1664, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1731, "\"", 1745, 1);
#nullable restore
#line 29 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
WriteAttributeValue("", 1739, dn.Id, 1739, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c4cd942da970cf95d4aa357669dec27b2fa4fa10763", async() => {
                    WriteLiteral("+ Info");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c4cd942da970cf95d4aa357669dec27b2fa4fa12327", async() => {
                    WriteLiteral("Actualizar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("    \n                    </div>                            \n                </div>\n            </div>\n        </div>    \n");
#nullable restore
#line 37 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <table class=""table table-striped mt-5"">
        <tr>
            <th>ID</th>
            <th>NOMBRES</th>
            <th>APELLIDOS</th>
            <th>DIRECCION</th>
            <th>TELEFONO</th>
            <th>CORREO</th>            
        </tr>
");
#nullable restore
#line 48 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
         foreach (var dn in Model.ListaDuenos){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 50 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
               Write(dn.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 51 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
               Write(dn.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 52 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
               Write(dn.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 53 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
               Write(dn.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 54 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
               Write(dn.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 55 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
               Write(dn.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \n            </tr>\n");
#nullable restore
#line 57 "C:\Users\leona\OneDrive\Escritorio\nuevo\MascotaFeliz.App3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ListaDuenos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ListaDuenosModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaDuenosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaDuenosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ListaDuenosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
