#pragma checksum "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8ae8569e282af87c086cec0a2f668de06cb9393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Models.Recipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Models.Ingredients;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Models.Cooks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Models.Sellers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Services.Recipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Services.Recipes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Services.Ingredients;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Services.Cooks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\_ViewImports.cshtml"
using FoodRecipes.Services.Sellers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8ae8569e282af87c086cec0a2f668de06cb9393", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a55aa4044dffa0464efc6e35377c397465df17", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Shared\Error.cshtml"
  
    ViewBag.Title = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
#nullable restore
#line 9 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 12 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
#line 14 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
