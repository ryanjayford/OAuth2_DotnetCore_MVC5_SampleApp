#pragma checksum "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5feaa70df79bcbfdfa6d43f6672bbacdfa353f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QBO_QBO), @"mvc.1.0.view", @"/Views/QBO/QBO.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QBO/QBO.cshtml", typeof(AspNetCore.Views_QBO_QBO))]
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
#line 1 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\_ViewImports.cshtml"
using OAuth2_CoreMVC_Sample;

#line default
#line hidden
#line 2 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\_ViewImports.cshtml"
using OAuth2_CoreMVC_Sample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5feaa70df79bcbfdfa6d43f6672bbacdfa353f6", @"/Views/QBO/QBO.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d8354a0033e5894ff50dab620df030ed1161aa", @"/Views/_ViewImports.cshtml")]
    public class Views_QBO_QBO : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QBO", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(132, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5feaa70df79bcbfdfa6d43f6672bbacdfa353f64300", async() => {
                BeginContext(184, 77, true);
                WriteLiteral("<div><input type=\"submit\" name=\"customerBtn\" value=\"Create Customer\" /></div>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(265, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 10 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml"
 if (ViewData["CustomerId"] != null)
{
    

#line default
#line hidden
            BeginContext(323, 34, false);
#line 12 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml"
Write(Html.Raw(ViewData["CustomerInfo"]));

#line default
#line hidden
            EndContext();
            BeginContext(359, 11, true);
            WriteLiteral("    <br/>\r\n");
            EndContext();
            BeginContext(375, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(379, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5feaa70df79bcbfdfa6d43f6672bbacdfa353f66654", async() => {
                BeginContext(477, 75, true);
                WriteLiteral("<div><input type=\"submit\" name=\"invoiceBtn\" value=\"Create Invoice\" /></div>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-customerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml"
                                                                 WriteLiteral(ViewData["CustomerId"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-customerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(556, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml"

}

#line default
#line hidden
            BeginContext(563, 12, true);
            WriteLiteral("<br />\r\n\r\n\r\n");
            EndContext();
#line 21 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml"
 if (ViewData["InvoiceInfo"] != null)
{
    

#line default
#line hidden
            BeginContext(622, 33, false);
#line 23 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml"
Write(Html.Raw(ViewData["InvoiceInfo"]));

#line default
#line hidden
            EndContext();
#line 23 "C:\Users\rkasaraneni\Documents\git\OAuth2_DotnetCore_MVC5_SampleApp\OAuth2_CoreMVC_Sample\Views\QBO\QBO.cshtml"
                                      
}

#line default
#line hidden
            BeginContext(660, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
