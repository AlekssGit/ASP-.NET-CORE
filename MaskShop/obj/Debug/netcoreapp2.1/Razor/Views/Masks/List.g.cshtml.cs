#pragma checksum "C:\Sasha\Eltech\.NET Labs\MaskShop\MaskShop\Views\Masks\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ccafef81d24705b88b56cd8240b67c2bb51e4d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Masks_List), @"mvc.1.0.view", @"/Views/Masks/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Masks/List.cshtml", typeof(AspNetCore.Views_Masks_List))]
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
#line 1 "C:\Sasha\Eltech\.NET Labs\MaskShop\MaskShop\Views\_ViewImports.cshtml"
using MaskShop.ViewModels;

#line default
#line hidden
#line 2 "C:\Sasha\Eltech\.NET Labs\MaskShop\MaskShop\Views\_ViewImports.cshtml"
using MaskShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccafef81d24705b88b56cd8240b67c2bb51e4d1", @"/Views/Masks/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87388afba0af75797ddf25657757a2ed4ba85cf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Masks_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 28, true);
            WriteLiteral(" \r\n<h1>Все маски</h1>\r\n <h3>");
            EndContext();
            BeginContext(29, 18, false);
#line 3 "C:\Sasha\Eltech\.NET Labs\MaskShop\MaskShop\Views\Masks\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
            EndContext();
            BeginContext(47, 37, true);
            WriteLiteral("</h3>\r\n <div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 5 "C:\Sasha\Eltech\.NET Labs\MaskShop\MaskShop\Views\Masks\List.cshtml"
       
         foreach (Mask mask in Model.getAllMasks)
         {
            

#line default
#line hidden
            BeginContext(169, 30, false);
#line 8 "C:\Sasha\Eltech\.NET Labs\MaskShop\MaskShop\Views\Masks\List.cshtml"
       Write(Html.Partial("AllMasks", mask));

#line default
#line hidden
            EndContext();
#line 8 "C:\Sasha\Eltech\.NET Labs\MaskShop\MaskShop\Views\Masks\List.cshtml"
                                           
         }
     

#line default
#line hidden
            BeginContext(221, 9, true);
            WriteLiteral(" </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
