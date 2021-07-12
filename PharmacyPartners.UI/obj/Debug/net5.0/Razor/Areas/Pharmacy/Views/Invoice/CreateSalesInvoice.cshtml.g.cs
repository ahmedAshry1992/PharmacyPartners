#pragma checksum "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\Invoice\CreateSalesInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843282ed89681f0e27ad6ceeea010b0801d08d0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Pharmacy_Views_Invoice_CreateSalesInvoice), @"mvc.1.0.view", @"/Areas/Pharmacy/Views/Invoice/CreateSalesInvoice.cshtml")]
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
#line 1 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\_ViewImports.cshtml"
using PharmacyPartners.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\_ViewImports.cshtml"
using PharmacyPartners.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843282ed89681f0e27ad6ceeea010b0801d08d0b", @"/Areas/Pharmacy/Views/Invoice/CreateSalesInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ff734bdd0ff19cf32d8cc60f8fcca964dc9a56", @"/Areas/Pharmacy/Views/_ViewImports.cshtml")]
    public class Areas_Pharmacy_Views_Invoice_CreateSalesInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("invoicebasic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\Invoice\CreateSalesInvoice.cshtml"
  
    var invoiceTypes = (IEnumerable<PharmacyUI.Models.WebRequest.Response.Invoice.InvoiceType>)ViewBag.invoiceTypes;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .action {
        background-color: Transparent;
        border: none;
    }

    .overlay {
        z-index: -1;
        position: absolute;
    }

    .originalDiv {
        z-index: 1;
        position: absolute;
    }

    
</style>
<div id=""allpage"" class=""form"" method=""post"">

    <div class=""title-bar h-35"" style=""height: 60px;"">
        <h1 class=""title-bar-title pull-xs-left"">
            <span class=""d-ib"">Create Invoice</span>
        </h1>
        <div class=""pull-xs-right"">
            <div class=""btn-group"" data-toggle=""buttons"">
                <label class=""btn btn-primary btn-pill"">
                    <button class=""btn action saveinv"">Save</button>
                </label>
                <label class=""btn btn-primary"">
                    <button class=""btn action"">Wait</button>
                </label>
                <label class=""btn btn-primary btn-pill"">
                    <button class=""btn action"">Cancele</button>
                </la");
            WriteLiteral(@"bel>
            </div>

        </div>
    </div>

    <div class=""row gutter-xs"">
        <div class=""col-xs-5"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-actions"">
                        <button type=""button"" class=""card-action card-toggler"" title=""Collapse""></button>
                    </div>
                    <strong>Informations</strong>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "843282ed89681f0e27ad6ceeea010b0801d08d0b6387", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "843282ed89681f0e27ad6ceeea010b0801d08d0b6673", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 57 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\Invoice\CreateSalesInvoice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                            <div class=""col-sm-12 col-sm-offset-0"">

                                <div class=""form-group col-lg-12"">
            <label for=""ref-1"" class=""control-label"">Invoice type</label>
            <select class=""form-control inv-type"">
");
#nullable restore
#line 65 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\Invoice\CreateSalesInvoice.cshtml"
                 foreach (var item in invoiceTypes)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "843282ed89681f0e27ad6ceeea010b0801d08d0b8963", async() => {
#nullable restore
#line 67 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\Invoice\CreateSalesInvoice.cshtml"
                                        Write(item.type);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\Invoice\CreateSalesInvoice.cshtml"
                       WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\web_projects\PharmacyPartners\PharmacyPartners.UI\Areas\Pharmacy\Views\Invoice\CreateSalesInvoice.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </select>
        </div>

                               

                                <div class=""form-group col-lg-12"">
                                    <label for=""name-1"" class=""control-label"">Customer</label>
                                    <input id=""name-1"" x-cusid=""0"" class=""form-control customerName"" name=""customerName"" placeholder=""CustomerName"" type=""text"" required>

                                    <div class=""dropdown-menu dropdown-menu-right dropdown-menu-lg cus-drdn autocomplete"">
                                        <div class=""dropdown-body"">
                                            <div class=""custom-scrollable-area autocomplete"" style=""position: relative; overflow: hidden; width: 100%; height: 100%;"">

                                                <div class=""custom-scrollbar-gripper"" style=""background: rgb(0, 0, 0); width: 6px; position: absolute; top: 0px; opacity: 0.4; display: none; border-radius: 7px; z-index: 99; right: 5px; height: 189");
                WriteLiteral(@".766px;""></div><div class=""custom-scrollbar-track"" style=""width: 6px; height: 100%; position: absolute; top: 0px; display: none; border-radius: 7px; background: rgb(51, 51, 51); opacity: 0.2; z-index: 90; right: 5px;""></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div hidden class=""form-group col-lg-12 code-block"">
                                    <label for=""code-1"" class=""control-label"">Customer Code</label>
                                    <input id=""code-1"" readonly class=""form-control customerCode"" name=""customercode"" type=""text"">

                                </div>
                                <div hidden class=""form-group col-lg-12 pons-block"">
                                    <label for=""points-1"" class=""control-label"">Customer Points</label>
                                    <input id=""points-1"" rea");
                WriteLiteral(@"donly class=""form-control customerPoints"" name=""customerPoints"" type=""text"">

                                </div>
                                <div hidden class=""form-group col-lg-12 addr-block"">
                                    <label for=""address-1"" class=""control-label"">Customer Adderss</label>
                                    <input id=""address-1"" readonly class=""form-control customerAddress"" name=""customerAdress"" type=""text"">

                                </div>

                                <div hidden class=""form-group col-lg-12 phon-block"">
                                    <label for=""phone-1"" class=""control-label"">Customer Phone</label>
                                    <input id=""phone-1"" readonly class=""form-control customerPhone"" name=""customerPhone"" type=""text"">

                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-7"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div class=""card-actions"">
                            <button type=""button"" class=""card-action card-toggler"" title=""Collapse""></button>
                        </div>
                        <strong>Invoice Items</strong>
                    </div>
                    <div class=""card-body"">
                        <table class=""table table-hover table-bordered table-striped"">
                            <thead style=""background-color: #F5F5F5;"">
                                <tr>
                                    <th class=""text-center"">Product</th>
                                    <th class=""text-center"">Packs</th>
                                    <th class=""text-center"">Price</th>
                                    <th class=""text-center"">Discount %</th>");
            WriteLiteral(@"
                                    <th class=""text-center"">Discount</th>
                                    <th class=""text-center"">Net</th>
                                </tr>
                            </thead>
                            <tbody class=""dyna-tbody"">
                            </tbody>
                            <tfoot class=""dyna-foot"">
                                <tr>
                                    <td class=""text-left""></td>
                                    <td class=""text-left""></td>
                                    <td class=""text-left""></td>
                                    <td class=""text-right""></td>
                                    <td class=""text-right""></td>
                                    <td class=""text-right"">
                                    </td>
                                </tr>
                            </tfoot>
                        </table>





                    </div>
                </div>
         ");
            WriteLiteral(@"   </div>

        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-actions"">
                        <button type=""button"" class=""card-action card-toggler"" title=""Collapse""></button>
                    </div>
                    <strong>Product search</strong>
                </div>
                <div class=""card-body"">
                    <div class=""form-group col-sm-5"">
                        <label class=""control-label"" for=""form-control-1"">Search</label>
                        <input id=""form-control-1"" placeholder=""Search by name or pack code"" class=""form-control productsearch"" type=""text"">
                        <div class=""hidden-sec"" hidden></div>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-lg prod-drdn prod-autocomplete"">
                            <div class=""dropdown-body"">
                                <div class=""custom-scrollable-area prod-autoc");
            WriteLiteral(@"omplete"" style=""position: relative; overflow: hidden; width: 100%; height: 100%;"">

                                    <div class=""custom-scrollbar-gripper"" style=""background: rgb(0, 0, 0); width: 6px; position: absolute; top: 0px; opacity: 0.4; display: none; border-radius: 7px; z-index: 99; right: 5px; height: 189.766px;""></div><div class=""custom-scrollbar-track"" style=""width: 6px; height: 100%; position: absolute; top: 0px; display: none; border-radius: 7px; background: rgb(51, 51, 51); opacity: 0.2; z-index: 90; right: 5px;""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-8 searchresult"">

                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-actions"">
                        <button type=");
            WriteLiteral(@"""button"" class=""card-action card-toggler"" title=""Collapse""></button>
                    </div>
                    <strong>Product in bill</strong>
                </div>
                <div class=""card-body"">

                    <table  class=""table table-hover table-bordered billtable"">
                        <thead style=""background-color: #F5F5F5;"">
                            <tr>
                                <th class=""text-center"" rowspan=""2"">ID</th>
                                <th class=""text-center"" rowspan=""2"">Name</th>
                                <th class=""text-center"" rowspan=""2"">Expiry</th>
                                <th class=""text-center"" rowspan=""2"">Price</th>
                                <th class=""text-center"" colspan=""2"">Quantity</th>
                                <th class=""text-center"" rowspan=""2"">Sale</th>
                                <th class=""text-center"" rowspan=""2"">Discount %</th>
                                <th class=""text-center"" ro");
            WriteLiteral(@"wspan=""2"">Discount</th>
                                <th class=""text-center"" rowspan=""2"">Net</th>
                                <th class=""text-center"" rowspan=""2"">Delete</th>
                            </tr>
                            <tr>
                                <th class=""text-center"">Pack</th>
                                <th class=""text-center"">Strip/Rack</th>
                            </tr>
                        </thead>
                        <tbody id=""navigate"" class=""dyna-tbody1"">
                        </tbody>

                    </table>


                  

                </div>
            </div>
        </div>


    </div>

</div>


<script>
    $(document).ready(function () {

        var ids = [];
        var items = 0;
        var price = 0;
        var net = 0;
        var defItems = 0;
        var x = 1;


        $("".productsearch"").keyup(function () {



            if ($("".productsearch"").val() != """") {

           ");
            WriteLiteral(@"     var $dom = '<div></div>';
                $($dom).empty().load(""/invoice/getproductlist?request="" + $("".productsearch"").val(), function () {
                    
                    var table = $(this).find(""table"");
                    if (table.attr(""x-name"") == ""search"") {
                        $("".prod-drdn"").show();
                        $('.prod-autocomplete').empty().append(table);
                        //  console.log(table);
                    }
                    else {
                        $('.searchresult').empty().append(table);
                       var rowCount = $('.prod-table tr').length;
                    if (rowCount == 1) {
                        // alert(rowCount);
                        $('.addproduct').trigger('click');
                    }
                    }
                });




            }
            else {
                $("".prod-drdn"").hide();
                $('.prod-autocomplete').empty();
                $('.searchresult')");
            WriteLiteral(@".empty();
            }
        });

        $(""body"").off(""click"", "".sel-prod-name"").on(""click"", "".sel-prod-name"", function () {
            $('.searchresult').empty().load(""/invoice/getproductlistgrid?request="" + $(this).attr(""x-name""), function () { });

            
            $("".prod-drdn"").hide();
        });
        
        $("".customerName"").keyup(function () {
            $("".cus-drdn"").show();

            if ($("".customerName"").val() != """") {
                $('.autocomplete').empty().load(""/invoice/getctomerlist?request="" + $("".customerName"").val(), function (response) {

                });
            }
            else {
                $("".customerName"").attr(""x-cusid"", ""0"");
                $("".customerCode"").val("""");
                $("".customerPoints"").val("""");
                $("".customerPhone"").val("""");
                $("".customerAddress"").val("""");
                $("".pons-block"").hide();
                $("".code-block"").hide();
                $("".phon-bloc");
            WriteLiteral(@"k"").hide();
                $("".addr-block"").hide();
                $('.autocomplete').empty();
                $('.cus-drdn').hide();

            }
        });

        $(""body"").off(""click"", "".addproduct"").on(""click"", "".addproduct"", function () {

            var $dom = $(this);
            if (ids.includes($dom.attr(""x-id"")) == false) {
                defItems = $dom.attr(""x-defitems"");
                ids.push($dom.attr(""x-id""));
                var id = $dom.attr(""x-id"");
                price = $dom.attr(""x-price"");
                items = $dom.attr(""x-items"");
                var name = $dom.attr(""x-name"");
                var expiry = $dom.attr(""x-expiry"")
                net = (price / defItems) * items;

                var $dom = '<tr  > <td>' + '<input  readonly class=""form-control code"" type=""text""  value=""' + id + '""/>' + '</td><td >' + '<input  class=""form-control"" readonly type=""text""  value=""' + name + '""/>' + '</td><td >' + '<input  class=""form-control"" type=""text"" re");
            WriteLiteral(@"adonly style=""width: 95px;"" value=""' + expiry + '""/>' + '</td>1<td >' + '<input  class=""form-control"" type=""text"" readonly  value=""' + price + '""/>' + '</td><td >' + '<input class=""form-control"" type=""text"" readonly value=""' + 1 + '""/>' + '</td><td>' + '<input class=""form-control prodquantity"" type=""number"" min=""' + 1 + '"" max=""' + items + '""  value=""' + items + '""/>' + '</td><td>' + '<input  class=""form-control sale""  type=""text"" readonly value=""' + net + '""/>' + '</td><td>' + '<input  class=""form-control discountrat"" style=""width: 70px;"" type=""number"" min=""' + 0 + '"" max=""' + 10 + '""  value=""' + 0 + '""/>' + '</td> <td>' + '<input  readonly class=""form-control discoutval"" type=""text""  value=""' + 0 + '""/>' + '</td><td>' + '<input  class=""form-control net"" type=""text"" readonly value=""' + net + '""/>' + '</td><td>' + '<button class=""btn btn-primary btn-xs deleteproduct"" x-delprod=""' + id + '"" type=""button"" >Delete</button>' + '</td></tr>';

                $('.dyna-tbody1').append(
                    $dom
 ");
            WriteLiteral(@"               );
                recalculeTotal();
            }
        });

        $("".billtable"").on(""click"", "".deleteproduct"", function () {
            var $dom = $(this).closest(""tr"");
            $dom.remove();
            recalculeTotal();
            var remid = $(this).attr(""x-delprod"");
            const index = ids.indexOf(remid);
            if (index > -1) {
                ids.splice(index, 1);
            }
        });

        $("".billtable"").on(""change"", "".prodquantity"", function () {

            var max = parseInt($(this).attr(""max""));
            var min = parseInt($(this).attr(""min""));
            if ($(this).val() > max) {
                $(this).val(max);
            }
            else if ($(this).val() < min) {
                $(this).val(min);
            }
            var code = $(this).closest(""tr"").find("".code"").val();
            var qua = $(this).closest(""tr"").find("".prodquantity"").val();
            var price1 = $(""#"" + code).attr(""x-price"");
    ");
            WriteLiteral(@"        var dfit = $(""#"" + code).attr(""x-defitems"");
            var dic1 = $(this).closest(""tr"").find("".discountrat"").val();
            var cellnet1 = (price1 / dfit) * qua;
            var dicVal1 = cellnet1 * (dic1 / 100);

            $(this).closest(""tr"").find("".net"").val(cellnet1 - dicVal1);
            $(this).closest(""tr"").find("".sale"").val((price1 / dfit) * qua);
            $(this).closest(""tr"").find("".discoutval"").val(dicVal1);

            recalculeTotal();

        });

        $("".billtable"").on(""change"", "".discountrat"", function () {
            var max = parseInt($(this).attr(""max""));
            var min = parseInt($(this).attr(""min""));
            if ($(this).val() > max) {
                $(this).val(min);
            }
            else if ($(this).val() < min) {
                $(this).val(min);
            }
            var code = $(this).closest(""tr"").find("".code"").val();
            var qua = $(this).closest(""tr"").find("".prodquantity"").val();
            var pric");
            WriteLiteral(@"e1 = $(""#"" + code).attr(""x-price"");
            var dfit = $(""#"" + code).attr(""x-defitems"");
            var dic = $(this).closest(""tr"").find("".discountrat"").val();
            var cellnet = (price1 / dfit) * qua;
            var dicVal = cellnet * (dic / 100);
            $(this).closest(""tr"").find("".net"").val(cellnet - dicVal);
            $(this).closest(""tr"").find("".discoutval"").val(dicVal);


            recalculeTotal();

        });

        $(""body"").off(""click"", "".sel-customer"").on(""click"", "".sel-customer"", function () {
            var $dom = $(this);
            $("".customerName"").val($dom.attr(""x-cusname""));
            $("".customerName"").attr(""x-cusid"", $dom.attr(""x-cusid""));
            $("".customerPhone"").val($dom.attr(""x-cusphone""));
            $("".customerAddress"").val($dom.attr(""x-cusaddr""));
            $("".customerCode"").val($dom.attr(""x-cusid""));
            $("".customerPoints"").val($dom.attr(""x-points""));
            $("".pons-block"").show();
            $("".code-bl");
            WriteLiteral(@"ock"").show();
            $("".phon-block"").show();
            $("".addr-block"").show();
            $('.autocomplete').empty();
            $('.cus-drdn').hide();

        });

        $(""body"").off(""click"", "".saveinv"").on(""click"", "".saveinv"", function () {
            if (validateInvoice()) {
                var data = invoiceObjectCreate(1);

                pharmacy.Globals.MakeAjaxCall(""Post"", ""invoice/create"", data, function (response) { });
            }
            //console.log(data);

        });


        function recalculeTotal() {
            var total = 0;
            $.each($("".dyna-tbody1 tr""), function () {
                var $dom = $(this);
                total += parseFloat($dom.closest('tr').find("".net"").val());
            });
            //  alert(total);
            $("".total"").empty();
            $("".total"").text(total);
        }

        function invoiceObjectCreate(status) {
            var invObject = {
                userId: 0,
                c");
            WriteLiteral(@"ustomerId: $("".customerName"").attr(""x-cusid""),
                statusId: status,
                typeId: parseInt($("".inv-type"").val()),
                salesProducts: []
            };
            $.each($("".dyna-tbody1 tr""), function () {
                var $dom = $(this).closest('tr');
                var pro = {
                    invoiceId: 0,
                    productToSellId: $dom.find("".code"").val(),
                    discount: parseFloat($dom.find("".discountrat"").val()) / 100,
                    items: $dom.find("".prodquantity"").val()
                }
                invObject.salesProducts.push(pro);
            });

            return invObject;

        }

        function validateInvoice() {
            var rowCount = $('.dyna-tbody1 tr').length;
            if (rowCount > 0) {
                return true;
            }
            return false;
        }



    });
        
       

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