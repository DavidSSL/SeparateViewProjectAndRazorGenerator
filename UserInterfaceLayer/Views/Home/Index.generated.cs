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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("featured", () => {

WriteLiteral("\r\n    <section");

WriteLiteral(" class=\"featured\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"content-wrapper\"");

WriteLiteral(">\r\n            <hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n                <h1>");

            
            #line 8 "..\..\Views\Home\Index.cshtml"
               Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n                <h2>");

            
            #line 9 "..\..\Views\Home\Index.cshtml"
               Write(ViewBag.Message);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n            </hgroup>\r\n            <p>\r\n                To learn more abou" +
"t ASP.NET MVC visit\r\n                <a");

WriteLiteral(" href=\"http://asp.net/mvc\"");

WriteLiteral(" title=\"ASP.NET MVC Website\"");

WriteLiteral(">http://asp.net/mvc</a>.\r\n                The page features <mark>videos, tutoria" +
"ls, and samples</mark> to help you get the most from ASP.NET MVC.\r\n             " +
"   If you have any questions about ASP.NET MVC visit\r\n                <a");

WriteLiteral(" href=\"http://forums.asp.net/1146.aspx/1?MVC\"");

WriteLiteral(" title=\"ASP.NET MVC Forum\"");

WriteLiteral(">our forums</a>.\r\n            </p>\r\n        </div>\r\n    </section>\r\n");

});

WriteLiteral("<h3>We suggest the following:</h3>\r\n<ol");

WriteLiteral(" class=\"round\"");

WriteLiteral(">\r\n    <li");

WriteLiteral(" class=\"one\"");

WriteLiteral(@">
        <h5>Getting Started</h5>
        ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that
        enables a clean separation of concerns and that gives you full control over markup
        for enjoyable, agile development. ASP.NET MVC includes many features that enable
        fast, TDD-friendly development for creating sophisticated applications that use
        the latest web standards.
        <a");

WriteLiteral(" href=\"http://go.microsoft.com/fwlink/?LinkId=245151\"");

WriteLiteral(">Learn more…</a>\r\n    </li>\r\n\r\n    <li");

WriteLiteral(" class=\"two\"");

WriteLiteral(">\r\n        <h5>Add NuGet packages and jump-start your coding</h5>\r\n        NuGet " +
"makes it easy to install and update free libraries and tools.\r\n        <a");

WriteLiteral(" href=\"http://go.microsoft.com/fwlink/?LinkId=245153\"");

WriteLiteral(">Learn more…</a>\r\n    </li>\r\n\r\n    <li");

WriteLiteral(" class=\"three\"");

WriteLiteral(">\r\n        <h5>Find Web Hosting</h5>\r\n        You can easily find a web hosting c" +
"ompany that offers the right mix of features\r\n        and price for your applica" +
"tions.\r\n        <a");

WriteLiteral(" href=\"http://go.microsoft.com/fwlink/?LinkId=245157\"");

WriteLiteral(">Learn more…</a>\r\n    </li>\r\n</ol>\r\n");

        }
    }
}
#pragma warning restore 1591