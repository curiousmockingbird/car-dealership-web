#pragma checksum "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e99cec1aceabfbf44a15e5ed53b5b574d1ef29d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Cars), @"mvc.1.0.view", @"/Views/Cars/Cars.cshtml")]
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
#line 9 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
using Dealership.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e99cec1aceabfbf44a15e5ed53b5b574d1ef29d", @"/Views/Cars/Cars.cshtml")]
    public class Views_Cars_Cars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e99cec1aceabfbf44a15e5ed53b5b574d1ef29d2881", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Car Dealership</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
  ");
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
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e99cec1aceabfbf44a15e5ed53b5b574d1ef29d4120", async() => {
                WriteLiteral("\n");
                WriteLiteral("    <a href=\"/\"> <-- Go back to home page</a>\n\t\t<h1>Available vehicles:</h1>\n\t\t<!-- <a href=\'/cars/new\'> Sell your!</a>\n\t\t<a href=\'/cars\'> See list of cars we got!</a> -->\n\t\t\n");
#nullable restore
#line 15 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
         if (Car.GetAll().Count == 0)
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<p> No cars currently available. </p>\n");
#nullable restore
#line 18 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
		} else {
      

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<ul>\n");
#nullable restore
#line 21 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
             foreach(Car car in Model)
			{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<a");
                BeginWriteAttribute("href", " href=\'", 675, "\'", 695, 2);
                WriteAttributeValue("", 682, "/cars/", 682, 6, true);
#nullable restore
#line 23 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
WriteAttributeValue("", 688, car.Id, 688, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><li> ");
#nullable restore
#line 23 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
                                        Write(car.MakeModel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li></a>\n");
#nullable restore
#line 24 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t</ul>\n");
#nullable restore
#line 26 "/Users/owner/Documents/Programación/Epicodus/Csharp/Tue-27-Aug/car-dealership/Views/Cars/Cars.cshtml"
		}

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\n\t\t<p>\t<a href=\'/cars/new\'>Click here </a>to sell your vehicle</p>\n\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
