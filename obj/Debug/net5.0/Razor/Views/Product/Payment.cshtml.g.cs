#pragma checksum "D:\Study\Winform\WebForm\WebFormFinalProject\Views\Product\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4456ea68bd356e6f44187b54ecefe9d5c585b4eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Payment), @"mvc.1.0.view", @"/Views/Product/Payment.cshtml")]
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
#line 1 "D:\Study\Winform\WebForm\WebFormFinalProject\Views\_ViewImports.cshtml"
using Midterm_Project_ASP_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\Winform\WebForm\WebFormFinalProject\Views\_ViewImports.cshtml"
using Midterm_Project_ASP_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\Winform\WebForm\WebFormFinalProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\Winform\WebForm\WebFormFinalProject\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4456ea68bd356e6f44187b54ecefe9d5c585b4eb", @"/Views/Product/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3fad69586264d728b01cc68c7e7bd47f8479dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe btn btn-primary btn-block shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Finish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Study\Winform\WebForm\WebFormFinalProject\Views\Product\Payment.cshtml"
  
    ViewData["Title"] = "Payment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container py-5"">
    <!-- For demo purpose -->
    <div class=""row mb-4"">
        <div class=""col-lg-8 mx-auto text-center"">
            <h1 class=""display-6"">Choose Payment</h1>
        </div>
    </div> <!-- End -->
    <div class=""row"">
        <div class=""col-lg-6 mx-auto"">
            <div class=""card "">
                <div class=""card-header"">
                    <div class=""bg-white shadow-sm pt-4 pl-2 pr-2 pb-2"">
                        <!-- Credit card form tabs -->
                        <ul role=""tablist"" class=""nav bg-light nav-pills rounded nav-fill mb-3"">
                            <li class=""nav-item""> 
                                <a data-toggle=""pill"" href=""#credit-card"" class=""nav-link active ""> 
                                    <i class=""fas fa-credit-card mr-2""></i> Credit Card 
                                </a> 
                            </li>
                            <li class=""nav-item""> 
                                <a data-togg");
            WriteLiteral(@"le=""pill"" href=""#paypal"" class=""nav-link""> 
                                    <i class=""fab fa-paypal mr-2""></i> Paypal 
                                </a> 
                            </li>
                            <li class=""nav-item""> 
                                <a data-toggle=""pill"" href=""#net-banking"" class=""nav-link ""> 
                                    <i class=""fas fa-mobile-alt mr-2""></i> Net Banking 
                                </a> 
                            </li>
                        </ul>
                    </div> <!-- End -->
                    <!-- Credit card form content -->
                    <div class=""tab-content"">
                        <!-- credit card info-->
                        <div id=""credit-card"" class=""tab-pane fade show active pt-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4456ea68bd356e6f44187b54ecefe9d5c585b4eb7297", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label for=""username"">
                                        <h6>Card Owner</h6>
                                    </label> 
                                    <input type=""text"" name=""username"" placeholder=""Card Owner Name"" required class=""form-control "">
                                </div>
                                <div class=""form-group"">
                                    <label for=""cardNumber"">
                                        <h6>Card number</h6>
                                    </label>
                                    <div class=""input-group"">
                                        <input type=""text"" name=""cardNumber"" placeholder=""Valid card number"" class=""form-control "" required>
                                        <div class=""input-group-append""> <span class=""input-group-text text-muted""> <i class=""fab fa-cc-visa mx-1""></i> <i class=""fab fa-cc-mastercard mx-1"">");
                WriteLiteral(@"</i> <i class=""fab fa-cc-amex mx-1""></i> </span> </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-8"">
                                        <div class=""form-group"">
                                            <label>
                                                <span class=""hidden-xs"">
                                                    <h6>Expiration Date</h6>
                                                </span>
                                            </label>
                                            <div class=""input-group""> <input type=""number"" placeholder=""MM""");
                BeginWriteAttribute("name", " name=\"", 3747, "\"", 3754, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" required> <input type=\"number\" placeholder=\"YY\"");
                BeginWriteAttribute("name", " name=\"", 3824, "\"", 3831, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" required> </div>
                                        </div>
                                    </div>
                                    <div class=""col-sm-4"">
                                        <div class=""form-group mb-4"">
                                            <label data-toggle=""tooltip"" title=""Three digit CV code on the back of your card"">
                                                <h6>CVV <i class=""fa fa-question-circle d-inline""></i></h6>
                                            </label> <input type=""text"" required class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer""> 
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4456ea68bd356e6f44187b54ecefe9d5c585b4eb10633", async() => {
                    WriteLiteral("\r\n");
                    WriteLiteral("                                        Confirm Payment\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div> <!-- End -->
                    <!-- Paypal info -->
                    <!--<div id=""paypal"" class=""tab-pane fade pt-3"">
                        <h6 class=""pb-2"">Select your paypal account type</h6>
                        <div class=""form-group ""> <label class=""radio-inline""> <input type=""radio"" name=""optradio"" checked> Domestic </label> <label class=""radio-inline""> <input type=""radio"" name=""optradio"" class=""ml-5"">International </label></div>
                        <p> <button type=""button"" class=""btn btn-primary ""><i class=""fab fa-paypal mr-2""></i> Log into my Paypal</button> </p>
                        <p class=""text-muted""> Note: After clicking on the button, you will be directed to a secure gateway for payment. After completing the payment process, you will be redirected back to the website to view details of your order. </p>
                    </div>--> <!-- End -->
                    <!-- bank transfer info -->
                ");
            WriteLiteral(@"    <!--<div id=""net-banking"" class=""tab-pane fade pt-3"">
                        <div class=""form-group "">
                            <label for=""Select Your Bank"">
                                <h6>Select your Bank</h6>
                            </label> <select class=""form-control"" id=""ccmonth"">
                                <option value="""" selected disabled>--Please select your Bank--</option>
                                <option>Bank 1</option>
                                <option>Bank 2</option>
                                <option>Bank 3</option>
                                <option>Bank 4</option>
                                <option>Bank 5</option>
                                <option>Bank 6</option>
                                <option>Bank 7</option>
                                <option>Bank 8</option>
                                <option>Bank 9</option>
                                <option>Bank 10</option>
                            </select>");
            WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <p> <button type=""button"" class=""btn btn-primary ""><i class=""fas fa-mobile-alt mr-2""></i> Proceed Payment</button> </p>
                        </div>
                        <p class=""text-muted"">Note: After clicking on the button, you will be directed to a secure gateway for payment. After completing the payment process, you will be redirected back to the website to view details of your order. </p>
                    </div>--> <!-- End -->
                    <!-- End -->
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        $('[data-toggle=""tooltip""]').tooltip()
    })
</script>");
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
