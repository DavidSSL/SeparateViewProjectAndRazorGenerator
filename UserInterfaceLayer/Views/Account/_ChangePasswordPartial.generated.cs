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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_ChangePasswordPartial.cshtml")]
    public partial class ChangePasswordPartial : System.Web.Mvc.WebViewPage<PresentationModelLayer.Models.LocalPasswordModel>
    {
        public ChangePasswordPartial()
        {
        }
        public override void Execute()
        {
WriteLiteral("<h3>Change password</h3>\r\n\r\n");

            
            #line 5 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
 using (Html.BeginForm("Manage", "Account")) {
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
                             


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>Change Password Form</legend>\r\n        <ol>\r\n    " +
"        <li>\r\n");

WriteLiteral("                ");

            
            #line 13 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
           Write(Html.LabelFor(m => m.OldPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 14 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
           Write(Html.PasswordFor(m => m.OldPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 17 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
           Write(Html.LabelFor(m => m.NewPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
           Write(Html.PasswordFor(m => m.NewPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ol>\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Change password\"");

WriteLiteral(" />\r\n    </fieldset>\r\n");

            
            #line 27 "..\..\Views\Account\_ChangePasswordPartial.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591