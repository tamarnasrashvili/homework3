#pragma checksum "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a18178e5d4d25aaae6f41753b3ca27b2926c4096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\_ViewImports.cshtml"
using TSUViewEngine;

#line default
#line hidden
#line 2 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\_ViewImports.cshtml"
using TSUViewEngine.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a18178e5d4d25aaae6f41753b3ca27b2926c4096", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccacd817e9e06fd28adb4c63432fcd91c7eaf4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 37, false);
#line 6 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
            EndContext();
            BeginContext(96, 40, true);
            WriteLiteral("\n\n<div class=\"container mt-3 mb-3\">\n    ");
            EndContext();
            BeginContext(137, 34, false);
#line 9 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Add"));

#line default
#line hidden
            EndContext();
            BeginContext(171, 86, true);
            WriteLiteral("\n</div>\n\n<div class=\"container mt-3\">\n\n    <div class=\"row row-cols-1 row-cols-md-3\">\n");
            EndContext();
#line 15 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml"
         foreach (var item in Model.Movies)
        {

#line default
#line hidden
            BeginContext(311, 96, true);
            WriteLiteral("            <div class=\"col-4 mb-4\">\n                <div class=\"card\">\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 407, "\"", 424, 1);
#line 19 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml"
WriteAttributeValue("", 413, item.Thumb, 413, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(425, 124, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(550, 10, false);
#line 21 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml"
                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(560, 75, true);
            WriteLiteral("</h5>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 25 "C:\Users\tamar\OneDrive\Desktop\Homework\TSUModelValidation-master\TSUViewEngine\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(645, 18, true);
            WriteLiteral("    </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
