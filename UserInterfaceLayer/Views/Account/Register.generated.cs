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

namespace UserInterfaceLayer.Views.Account
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Register.cshtml")]
    public partial class Register : System.Web.Mvc.WebViewPage<PresentationModelLayer.Models.RegisterModel>
    {
        public Register()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Account\Register.cshtml"
  
    ViewBag.Title = "Register";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <h1>");

            
            #line 7 "..\..\Views\Account\Register.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n    <h2>Create a new account.</h2>\r\n</hgroup>\r\n\r\n");

            
            #line 11 "..\..\Views\Account\Register.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\Register.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\Register.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\Register.cshtml"
                             


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>Registration Form</legend>\r\n        <ol>\r\n       " +
"     <li>\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 24 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ol>\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Register\"");

WriteLiteral(" />\r\n    </fieldset>\r\n");

            
            #line 33 "..\..\Views\Account\Register.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 36 "..\..\Views\Account\Register.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
