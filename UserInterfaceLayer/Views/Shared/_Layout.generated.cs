﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserInterfaceLayer.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class Layout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Layout()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"en\"");

WriteLiteral(">\r\n    <head>\r\n        <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n        <title>");

            
            #line 5 "..\..\Views\Shared\_Layout.cshtml"
          Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - My ASP.NET MVC Application</title>\r\n        <link");

WriteAttribute("href", Tuple.Create(" href=\"", 162), Tuple.Create("\"", 182)
, Tuple.Create(Tuple.Create("", 169), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 169), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n        <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width\"");

WriteLiteral(" />\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\Shared\_Layout.cshtml"
   Write(Styles.Render("~/Content/css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Views\Shared\_Layout.cshtml"
   Write(Scripts.Render("~/bundles/modernizr"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </head>\r\n    <body>\r\n        <header>\r\n            <div");

WriteLiteral(" class=\"content-wrapper\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"float-left\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"site-title\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\_Layout.cshtml"
                                     Write(Html.ActionLink("your logo here", "Index", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"float-right\"");

WriteLiteral(">\r\n                    <section");

WriteLiteral(" id=\"login\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 19 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.Partial("_LoginPartial"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </section>\r\n                    <nav>\r\n                    " +
"    <ul");

WriteLiteral(" id=\"menu\"");

WriteLiteral(">\r\n                            <li>");

            
            #line 23 "..\..\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Home", "Index", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                            <li>");

            
            #line 24 "..\..\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("About", "About", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                            <li>");

            
            #line 25 "..\..\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Contact", "Contact", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                        </ul>\r\n                    </nav>\r\n               " +
" </div>\r\n            </div>\r\n        </header>\r\n        <div");

WriteLiteral(" id=\"body\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Shared\_Layout.cshtml"
       Write(RenderSection("featured", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <section");

WriteLiteral(" class=\"content-wrapper main-content clear-fix\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 34 "..\..\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </section>\r\n        </div>\r\n        <footer>\r\n            <div");

WriteLiteral(" class=\"content-wrapper\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"float-left\"");

WriteLiteral(">\r\n                    <p>&copy; ");

            
            #line 40 "..\..\Views\Shared\_Layout.cshtml"
                         Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" - My ASP.NET MVC Application</p>\r\n                </div>\r\n            </div>\r\n  " +
"      </footer>\r\n\r\n");

WriteLiteral("        ");

            
            #line 45 "..\..\Views\Shared\_Layout.cshtml"
   Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 46 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
