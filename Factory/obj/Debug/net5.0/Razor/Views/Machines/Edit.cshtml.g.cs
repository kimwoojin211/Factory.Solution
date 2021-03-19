#pragma checksum "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e1a70744b442217740e95fc68de6d0e3321f32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Edit), @"mvc.1.0.view", @"/Views/Machines/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e1a70744b442217740e95fc68de6d0e3321f32", @"/Views/Machines/Edit.cshtml")]
    public class Views_Machines_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Add a new Machine</h4>\r\n\r\n");
#nullable restore
#line 8 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.LabelFor(machine => machine.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.EditorFor(machine => machine.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.LabelFor(machine => machine.Manufacturer));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.EditorFor(machine => machine.Manufacturer));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.Label("Model Number"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.EditorFor(machine => machine.ModelNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.LabelFor(machine => machine.Condition));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.EditorFor(machine => machine.Condition));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.Label("Date of Last Service"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.EditorFor(machine => machine.LastServiced, new { type="date" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.Label("Add another licensed Engineer (or leave blank)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.DropDownList("EngineerId", null, string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new machine\" />\r\n");
#nullable restore
#line 29 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p>");
#nullable restore
#line 32 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.ActionLink($"Back to {Model.Name} Details (Changes not saved)", "Details", new { machineId = Model.MachineId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 33 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.ActionLink("Show all Machines", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 34 "W:\Dropbox\Documents\Epicodus\indiv\Factory.Solution\factory\Views\Machines\Edit.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591