#pragma checksum "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e409872de92db32890e877eee2c0ef292c79ce74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Student), @"mvc.1.0.view", @"/Views/Home/Student.cshtml")]
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
#line 1 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\_ViewImports.cshtml"
using registrationWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\_ViewImports.cshtml"
using registrationWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e409872de92db32890e877eee2c0ef292c79ce74", @"/Views/Home/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1167c9046adb5ec078bbfd9f1b6ea904f8848e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
  
    ViewData["Title"] = "Registration";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Registration</h1>

<table class=""table table-striped"">
    <thead>
        <tr>
            <td>Id</td>
            <td>First Name</td>
            <td>Last Name</td>
            <td>Email</td>
            <td>Phone</td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
         foreach (var inst in ViewBag.Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
               Write(inst.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
               Write(inst.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
               Write(inst.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
               Write(inst.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
               Write(inst.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Flia Rossi\Desktop\COLLEGE - AGUS\c#\registrationWebApp\Views\Home\Student.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<style>
    body {
        font-family: Arial, Helvetica, sans-serif;
        background-color: black;
    }

    * {
        box-sizing: border-box;
    }

    /* Add padding to containers */
    .container {
        padding: 16px;
        background-color: white;
    }

    /* Full-width input fields */
    input[type=text], input[type=password] {
        width: 100%;
        padding: 15px;
        margin: 5px 0 22px 0;
        display: inline-block;
        border: none;
        background: #f1f1f1;
    }

        input[type=text]:focus, input[type=password]:focus {
            background-color: #ddd;
            outline: none;
        }

    /* Overwrite default styles of hr */
    hr {
        border: 1px solid #f1f1f1;
        margin-bottom: 25px;
    }

    /* Set a style for the submit button */
    .registerbtn {
        background-color: #04AA6D;
        color: white;
        padding: 16px 20px;
        margin: 8px 0;
        borde");
            WriteLiteral(@"r: none;
        cursor: pointer;
        width: 100%;
        opacity: 0.9;
    }

        .registerbtn:hover {
            opacity: 1;
        }

    /* Add a blue text color to links */
    a {
        color: dodgerblue;
    }

    /* Set a grey background color and center the text of the ""sign in"" section */
    .signin {
        background-color: #f1f1f1;
        text-align: center;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e409872de92db32890e877eee2c0ef292c79ce747473", async() => {
                WriteLiteral(@"
    <div class=""container"">

        <h1>Register new Student</h1>

        <p>Please fill in this form to create a new Student.</p>
        <hr>

        <label for=""Student Id""><b>Student Id</b></label>
        <input type=""text"" placeholder=""Student Id"" name=""Student Id"" id=""Student Id"" required>

        <label for=""Name""><b>Student Name</b></label>
        <input type=""text"" placeholder=""Name"" name=""Name"" id=""Name"" required>

        <label for=""Last Name""><b>Student Last Name</b></label>
        <input type=""text"" placeholder=""Last Name"" name=""Last Name"" id=""Last Name"" required>

        <label for=""email""><b>Student Email</b></label>
        <input type=""text"" placeholder=""email"" name=""email"" id=""email"" required>

        <label for=""Phone""><b>Student Phone</b></label>
        <input type=""text"" placeholder=""Phone"" name=""Phone"" id=""Phone"" required>
        <hr>
      
        <button type=""submit"" class=""registerbtn"">Register</button>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
