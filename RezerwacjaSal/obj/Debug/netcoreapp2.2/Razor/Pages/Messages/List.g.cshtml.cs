#pragma checksum "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6b4ac370ecd8a4ffb0c98c358d4e9e4d8daa58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RezerwacjaSal.Pages.Messages.Pages_Messages_List), @"mvc.1.0.razor-page", @"/Pages/Messages/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Messages/List.cshtml", typeof(RezerwacjaSal.Pages.Messages.Pages_Messages_List), null)]
namespace RezerwacjaSal.Pages.Messages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\_ViewImports.cshtml"
using RezerwacjaSal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6b4ac370ecd8a4ffb0c98c358d4e9e4d8daa58", @"/Pages/Messages/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153ee7dfce6fce13f708644f3027e1f961ed1e17", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Messages_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
  
    ViewData["Title"] = "HiddenList";

#line default
#line hidden
            BeginContext(102, 62, true);
            WriteLiteral("\r\n<h3>Lista ostatnich wiadomości</h3>\r\n<h4>Liczba wiadomości: ");
            EndContext();
            BeginContext(165, 22, false);
#line 9 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
                  Write(Model.Messages.Count());

#line default
#line hidden
            EndContext();
            BeginContext(187, 90, true);
            WriteLiteral("</h4>\r\n<h3>\r\n    <a href=\"https://outlook.live.com/mail/inbox\">Skrzynka email</a>\r\n</h3>\r\n");
            EndContext();
            BeginContext(277, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed6b4ac370ecd8a4ffb0c98c358d4e9e4d8daa584554", async() => {
                BeginContext(297, 82, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Wyczyść\" class=\"btn btn-default btn-danger\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(386, 361, true);
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>
                Data
            </th>
            <th>
                Email
            </th>
            <th>
                Numer
            </th>
            <th>
                Imię nazwisko
            </th>
            <th>
                Temat
            </th>
");
            EndContext();
            BeginContext(819, 103, true);
            WriteLiteral("            <th>\r\n                IP\r\n            </th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
         foreach (var item in Model.Messages)
        {

#line default
#line hidden
            BeginContext(980, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1041, 39, false);
#line 50 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1148, 40, false);
#line 53 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1256, 57, false);
#line 56 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ApplicationUser.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1381, 39, false);
#line 59 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1488, 49, false);
#line 62 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.MessageSubject));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1691, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1734, 37, false);
#line 68 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.IP));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 48, true);
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 73 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Messages\List.cshtml"
        }

#line default
#line hidden
            BeginContext(1830, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RezerwacjaSal.Pages.Messages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezerwacjaSal.Pages.Messages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezerwacjaSal.Pages.Messages.ListModel>)PageContext?.ViewData;
        public RezerwacjaSal.Pages.Messages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
