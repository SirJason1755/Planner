#pragma checksum "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "231c5e02ada17c4daa9cfeefa55d5b489aabda48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\_ViewImports.cshtml"
using Planner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\_ViewImports.cshtml"
using Planner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231c5e02ada17c4daa9cfeefa55d5b489aabda48", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f34874fc4d62129caeb1f21e44fd1cc2e1b84bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Welcome to the wedding Planner</h1>\r\n<h1>Hello ");
#nullable restore
#line 2 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
     Write(ViewBag.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr>\r\n<table class =\"table table-hover\">\r\n        <tr>\r\n            <th>Wedding</th>\r\n            <th>Date</th>\r\n            <th>Guest</th>\r\n            <th>Action</th>\r\n        </tr>\r\n");
#nullable restore
#line 11 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
          
            foreach(Wedding u in ViewBag.AllWeddings)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 396, "\"", 427, 2);
            WriteAttributeValue("", 403, "/onewedding/", 403, 12, true);
#nullable restore
#line 15 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 415, u.WeddingID, 415, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                                                      Write(u.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("  &  ");
#nullable restore
#line 15 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                                                                       Write(u.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 16 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                   Write(u.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 17 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                   Write(u.GuestList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 18 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                     if(@u.Planner.UserID == @ViewBag.User.UserID)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 712, 2);
            WriteAttributeValue("", 692, "/delete/", 692, 8, true);
#nullable restore
#line 20 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 700, u.WeddingID, 700, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">YEETUS DELETEUS</a></td>\r\n");
#nullable restore
#line 21 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                        }
                    else{
                        if(u.GuestList.Any(r => r.UserID == @ViewBag.User.UserID))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><a");
            BeginWriteAttribute("href", " href=\"", 939, "\"", 987, 4);
            WriteAttributeValue("", 946, "/unrsvp/", 946, 8, true);
#nullable restore
#line 25 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 954, u.WeddingID, 954, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 966, "/", 966, 1, true);
#nullable restore
#line 25 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 967, ViewBag.User.UserID, 967, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">UnRSVP</a></td>\r\n");
#nullable restore
#line 26 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1094, "\"", 1140, 4);
            WriteAttributeValue("", 1101, "/rsvp/", 1101, 6, true);
#nullable restore
#line 28 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1107, u.WeddingID, 1107, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1119, "/", 1119, 1, true);
#nullable restore
#line 28 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1120, ViewBag.User.UserID, 1120, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">RSVP</a></td>\r\n");
#nullable restore
#line 29 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    }\r\n                </tr>\r\n");
#nullable restore
#line 33 "D:\Users\Jason\Desktop\CodingDojo\CSharpe\ORMS\Planner\Views\Home\Dashboard.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br>\r\n<h2><a href=\"/Weddings\">New Wedding</a></h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
