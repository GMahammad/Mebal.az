#pragma checksum "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8db3952e43bca87b344477a8fa805d89362355fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Mebelan.az\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Mebelan.az\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Mebelan.az\Web\Views\_ViewImports.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Mebelan.az\Web\Views\_ViewImports.cshtml"
using Web.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db3952e43bca87b344477a8fa805d89362355fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9b1ad929fc01f2eea93e5a6f298c12ce861e32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sec-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    solos a:hover{\r\n        color:orange;\r\n    }\r\n    </style >\r\n\r\n\r\n    <section class=\"firstslider\" >\r\n    <div class=\"fff\" >\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
     foreach (var fslider in Model.FirstSliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"fslide\" >\r\n    <div class=\"row\" >\r\n    <div class=\"col-lg-6 col-sm-6 col-md-6 leftpart\" >\r\n    <h3 >");
#nullable restore
#line 19 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
    Write(fslider.TopHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3 >\r\n    <h1 >");
#nullable restore
#line 20 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
    Write(fslider.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1 >\r\n    <h5 >\r\n    ");
#nullable restore
#line 22 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
Write(fslider.SlideDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h5 >\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 504, "\"", 528, 1);
#nullable restore
#line 24 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 511, fslider.SlideAdv, 511, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 24 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
                            Write(fslider.SlideButton);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a >\r\n    </div >\r\n    <div class=\"col-lg-6 col-sm-6 col-md-6\" >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8db3952e43bca87b344477a8fa805d89362355fb6087", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 633, "~/img/", 633, 6, true);
#nullable restore
#line 27 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 639, fslider.PhotoURL, 639, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div >\r\n    </div >\r\n    </div >\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div >\r\n    </section >\r\n    <section class=\"brandslider mt-5 \" >\r\n    <div class=\"container\" >\r\n    <div class=\"eee\" >\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
     foreach (var category in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"col-lg-3 col-sm-4 col-md-4\" >\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 976, "\"", 1049, 1);
#nullable restore
#line 41 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 983, Url.Action("index","advertisement", new {categoryID=category.ID}), 983, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black; text-decoration:none;\" >\r\n\r\n    <div class=\"circle\" > </div >\r\n    <div class=\"brand\" >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8db3952e43bca87b344477a8fa805d89362355fb8833", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1174, "~/img/", 1174, 6, true);
#nullable restore
#line 45 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1180, category.CategoryPhotoSlide, 1180, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h5 >");
#nullable restore
#line 46 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
    Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5 >\r\n    </div >\r\n    </a >\r\n\r\n    </div >\r\n");
#nullable restore
#line 51 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div >
    </div >
    </section >
    <section class=""wholeadvert pb-3 "" >
    <div class=""solos"" style=""padding-top: 50px; text-align: center;"" >
    <h1 style=""font-size: 60px;"" class=""mb-4"" > Elanlar</h1 >
    <ul style="" display: flex; justify-content: center;"" >
    <li style=""list-style: none;
    padding: 0 15px;"">
    <a style="" color: black; text-decoration: none; transition: 0.2s; font-size: 30px; :hover{color:orange} "" href=""#"" > Yeni elanlar</a >
    </li >
    <li style=""list-style: none;
    padding: 0 15px;"">
    <a style="" color: black; text-decoration: none; transition: 0.2s; font-size: 30px;"" href=""#"" > Mebel sexləri</a >
    </li >
    <li style=""list-style: none; padding: 0 15px;"" >
    <a style="" color: black; text-decoration: none; transition: 0.2s; font-size: 30px;"" href=""#"" > Fabrik mebelləri</a >
    </li >

    </ul >
    </div >
    <div class=""container"" >
    <div class=""add-all"" >
    <div class=""home-detailed-search"" >
    <a class=""big"" href=""/adve");
            WriteLiteral("rtisement\" > Ətraflı Axtarış</a >\r\n    <a class=\"small\" href=\"/advertisement/responsiveindex\" > Ətraflı Axtarış</a >\r\n\r\n    </div >\r\n\r\n    <div class=\"row \" >\r\n");
#nullable restore
#line 83 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
     foreach (var advert in Model.Advertisements)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <div class=\"col-lg-4 col-lg-4 col-sm-6 col-md-4 col-6\" >\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 2647, "\"", 2687, 2);
            WriteAttributeValue("", 2654, "/advertisement/details/", 2654, 23, true);
#nullable restore
#line 86 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2677, advert.ID, 2677, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n    <div class=\"adv-frame\" >\r\n    <div class=\"adv-photo\" >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8db3952e43bca87b344477a8fa805d89362355fb12961", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2766, "~/img/", 2766, 6, true);
#nullable restore
#line 89 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2772, advert.AdvertisementPictures[0].Picture.URL, 2772, 44, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8db3952e43bca87b344477a8fa805d89362355fb14540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2860, "~/img/", 2860, 6, true);
#nullable restore
#line 90 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2866, advert.AdvertisementPictures[1].Picture.URL, 2866, 44, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"advert-price\" style=\"width:50%\" >\r\n    <h5 style=\"white-space:nowrap; position:absolute; bottom:10%; color:white; right:0%; padding:7px 10px; background-color:orange; border-radius:10px 0 0 10px;\" >");
#nullable restore
#line 92 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
                                                                                                                                                              Write(advert.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</h5 >\r\n    </div >\r\n    </div >\r\n    <div class=\"adv-desc\" >\r\n    <h5 >\r\n    ");
#nullable restore
#line 97 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
Write(advert.AdvertName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h5 >\r\n    <h6 >\r\n    İstehsalçı :\r\n    <a href=\"#\" >");
#nullable restore
#line 101 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
            Write(advert.Stores.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a >\r\n    </h6 > <br >\r\n    <p style=\"opacity:0.5;\" >");
#nullable restore
#line 103 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
                        Write(advert.Posttime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 103 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
                                                              Write(advert.Cities.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p >\r\n    </div >\r\n    </div >\r\n    </a >\r\n\r\n    </div >\r\n");
#nullable restore
#line 109 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <a href=""/advertisement"" style=""outline:none; justify-content:center"" class="" loadmorebut"" > Daha çox</a >

    </div >

    </div >
    </div >
    </section >
    <section id=""disa"" style=""text-align: center;"" class=""discount"" >
    <div class=""container"" >
    <h1 > Endirimli məhsullar</h1 >
    <div class=""row"" >
");
#nullable restore
#line 121 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
     foreach (var discount in Model.Discounts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div id=\"first-dis\" style=\"transition: .3s;\" class=\" mb-4 left col-lg-6 col-md-6 col-sm-12\" >\r\n    <div class=\"percent\" >\r\n    <h5 >");
#nullable restore
#line 125 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
    Write(discount.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</h5 >\r\n    </div >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8db3952e43bca87b344477a8fa805d89362355fb19172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4121, "~/img/", 4121, 6, true);
#nullable restore
#line 127 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4127, discount.PhotoURL, 4127, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"dis-buy\" >\r\n    <a href=\"#\" > Elana get</a >\r\n    </div >\r\n    <div class=\"dis-price\" >\r\n    <span class=\"cross\" >");
#nullable restore
#line 132 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
                    Write(discount.LastPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</span >\r\n    <span class=\"org\" >");
#nullable restore
#line 133 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
                  Write(discount.CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</span >\r\n    </div >\r\n\r\n    </div >\r\n");
#nullable restore
#line 137 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div >\r\n\r\n    </div >\r\n    </section >\r\n    <section class=\"Marka-slider\" >\r\n    <div class=\"mmm\" >\r\n");
#nullable restore
#line 144 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
     foreach (var brand in Model.Brands)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"mark\" >\r\n    <div class=\"col-3\" >\r\n    <a href=\"#\" > </a >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8db3952e43bca87b344477a8fa805d89362355fb22043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4680, "~/Img/", 4680, 6, true);
#nullable restore
#line 149 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4686, brand.BrandURL, 4686, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div >\r\n    </div >\r\n");
#nullable restore
#line 153 "C:\Users\User\Desktop\Mebelan.az\Web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div >\r\n\r\n    </section >\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
