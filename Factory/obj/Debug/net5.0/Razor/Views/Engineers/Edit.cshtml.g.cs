#pragma checksum "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da95d0a325514397ffb64fcc77e1e24571bb049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Edit), @"mvc.1.0.view", @"/Views/Engineers/Edit.cshtml")]
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
#line 5 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
using Factory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da95d0a325514397ffb64fcc77e1e24571bb049", @"/Views/Engineers/Edit.cshtml")]
    public class Views_Engineers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Edit Engineer: ");
#nullable restore
#line 7 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n");
#nullable restore
#line 9 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
Write(Html.Label("Years of Experience"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
Write(Html.EditorFor(model => model.YearsExperience, new {type = "number"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 20 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n<p>");
#nullable restore
#line 23 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Engineers\Edit.cshtml"
Write(Html.ActionLink("Show all engineers", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591
