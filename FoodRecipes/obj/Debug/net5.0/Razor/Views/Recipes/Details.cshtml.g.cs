#pragma checksum "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec5ca09de9af48d078dbd7b6bc48b058b4ec2476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Details), @"mvc.1.0.view", @"/Views/Recipes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5ca09de9af48d078dbd7b6bc48b058b4ec2476", @"/Views/Recipes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a55aa4044dffa0464efc6e35377c397465df17", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeDetailsServiceModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 class=\"text-center mt-5\">Invalid Recipe!</h2>\n");
#nullable restore
#line 11 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\n            <div class=\"row\">\n\n                <div class=\"col-md-6 offset-3\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 317, "\"", 338, 1);
#nullable restore
#line 18 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
WriteAttributeValue("", 323, Model.ImageUrl, 323, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"project-image\" class=\"rounded\">\n\n                    <div class=\"project-info-box mt-4\">\n                        <div class=\"project-info-box\">\n                            <p><b>");
#nullable restore
#line 22 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n                            <p class=\"mb-3\"><b>Cooking time:</b> ");
#nullable restore
#line 23 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
                                                            Write(Model.CookingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes</p>\n                            <p><b>Category:</b> ");
#nullable restore
#line 24 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
                                           Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                            <div class=\"project-info-box mt-3\">\n                                <h5>Ingredients</h5>\n                                <p class=\"mb-0\">");
#nullable restore
#line 28 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
                                           Write(Model.Ingredients);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"project-info-box mt-3\">\n                                <h5>Directions</h5>\n                                <p class=\"mb-0\">");
#nullable restore
#line 32 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
                                           Write(Model.Directions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div><!-- / project-info-box -->\n                </div><!-- / column -->\n            </div>\n        </div>\n");
#nullable restore
#line 39 "F:\Anu\Guvi_Project\Food.Recipes.ASP.Net-main\Food.Recipes.ASP.Net-main\FoodRecipes\Views\Recipes\Details.cshtml"
    }


#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeDetailsServiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
