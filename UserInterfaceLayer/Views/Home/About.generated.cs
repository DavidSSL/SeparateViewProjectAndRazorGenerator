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

namespace UserInterfaceLayer.Views.Home
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/About.cshtml")]
    public partial class About : System.Web.Mvc.WebViewPage<dynamic>
    {
        public About()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\About.cshtml"
  
    ViewBag.Title = "About";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <h1>");

            
            #line 6 "..\..\Views\Home\About.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n    <h2>");

            
            #line 7 "..\..\Views\Home\About.cshtml"
   Write(ViewBag.Message);

            
            #line default
            #line hidden
WriteLiteral(@"</h2>
</hgroup>

<article>
    <p>
        Use this area to provide additional information.
    </p>

    <p>
        Use this area to provide additional information.
    </p>

    <p>
        Use this area to provide additional information.
    </p>
</article>

<aside>
    <h3>Aside Title</h3>
    <p>
        Use this area to provide additional information.
    </p>
    <ul>
        <li>");

            
            #line 30 "..\..\Views\Home\About.cshtml"
       Write(Html.ActionLink("Home", "Index", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 31 "..\..\Views\Home\About.cshtml"
       Write(Html.ActionLink("About", "About", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 32 "..\..\Views\Home\About.cshtml"
       Write(Html.ActionLink("Contact", "Contact", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n</aside>");

        }
    }
}
#pragma warning restore 1591
