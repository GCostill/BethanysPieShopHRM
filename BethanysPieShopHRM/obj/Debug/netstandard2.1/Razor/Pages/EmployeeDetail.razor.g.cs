#pragma checksum "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91d19304aa2cd88d9e01dd985a2c7b96ae4d7a67"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\_Imports.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, "Details for ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                    Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 3 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                        Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12 row");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-2");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 7 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                    $"https://gillcleerenpluralsight.blob.core.windows.net/person/{Employee.EmployeeId}.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-10 row");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-xs-12 col-sm-8");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group row");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-8");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "label");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control-plaintext");
            __builder.AddContent(35, 
#nullable restore
#line 14 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                       Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group row");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.AddMarkupContent(42, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-8");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "label");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "readonly", true);
            __builder.AddAttribute(49, "class", "form-control-plaintext");
            __builder.AddContent(50, 
#nullable restore
#line 20 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form-group row");
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.AddMarkupContent(57, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-sm-8");
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "readonly", true);
            __builder.AddAttribute(64, "class", "form-control-plaintext");
            __builder.AddContent(65, 
#nullable restore
#line 27 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-group row");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.AddMarkupContent(72, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-sm-8");
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "label");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "readonly", true);
            __builder.AddAttribute(79, "class", "form-control-plaintext");
            __builder.AddContent(80, 
#nullable restore
#line 34 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n            ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "form-group row");
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.AddMarkupContent(87, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col-sm-8");
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "label");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "readonly", true);
            __builder.AddAttribute(94, "class", "form-control-plaintext");
            __builder.AddContent(95, 
#nullable restore
#line 41 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n            ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group row");
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.AddMarkupContent(102, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n                ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-sm-8");
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "label");
            __builder.AddAttribute(107, "type", "text");
            __builder.AddAttribute(108, "readonly", true);
            __builder.AddAttribute(109, "class", "form-control-plaintext");
            __builder.AddContent(110, 
#nullable restore
#line 48 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\r\n            ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "form-group row");
            __builder.AddMarkupContent(116, "\r\n                ");
            __builder.AddMarkupContent(117, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n                ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "col-sm-8");
            __builder.AddMarkupContent(120, "\r\n                    ");
            __builder.OpenElement(121, "label");
            __builder.AddAttribute(122, "type", "text");
            __builder.AddAttribute(123, "readonly", true);
            __builder.AddAttribute(124, "class", "form-control-plaintext");
            __builder.AddContent(125, 
#nullable restore
#line 55 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\r\n            ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "form-group row");
            __builder.AddMarkupContent(131, "\r\n                ");
            __builder.AddMarkupContent(132, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n                ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "col-sm-8");
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.OpenElement(136, "label");
            __builder.AddAttribute(137, "type", "text");
            __builder.AddAttribute(138, "readonly", true);
            __builder.AddAttribute(139, "class", "form-control-plaintext");
            __builder.AddContent(140, 
#nullable restore
#line 62 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n\r\n            ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "form-group row");
            __builder.AddMarkupContent(146, "\r\n                ");
            __builder.AddMarkupContent(147, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                ");
            __builder.OpenElement(148, "div");
            __builder.AddAttribute(149, "class", "col-sm-8");
            __builder.AddMarkupContent(150, "\r\n                    ");
            __builder.OpenElement(151, "label");
            __builder.AddAttribute(152, "type", "text");
            __builder.AddAttribute(153, "readonly", true);
            __builder.AddAttribute(154, "class", "form-control-plaintext");
            __builder.AddContent(155, 
#nullable restore
#line 69 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n\r\n            ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "form-group row");
            __builder.AddMarkupContent(161, "\r\n                ");
            __builder.AddMarkupContent(162, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n                ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "class", "col-sm-8");
            __builder.AddMarkupContent(165, "\r\n                    ");
            __builder.OpenElement(166, "label");
            __builder.AddAttribute(167, "type", "text");
            __builder.AddAttribute(168, "readonly", true);
            __builder.AddAttribute(169, "class", "form-control-plaintext");
            __builder.AddContent(170, 
#nullable restore
#line 76 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n\r\n            ");
            __builder.OpenElement(174, "div");
            __builder.AddAttribute(175, "class", "form-group row");
            __builder.AddMarkupContent(176, "\r\n                ");
            __builder.AddMarkupContent(177, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n                ");
            __builder.OpenElement(178, "div");
            __builder.AddAttribute(179, "class", "col-sm-8");
            __builder.AddMarkupContent(180, "\r\n\r\n");
#nullable restore
#line 84 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                     if (Employee.Smoker)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(181, "                        ");
            __builder.AddMarkupContent(182, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>\r\n");
#nullable restore
#line 87 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(183, "                        ");
            __builder.AddMarkupContent(184, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>\r\n");
#nullable restore
#line 91 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(185, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n\r\n            ");
            __builder.OpenElement(188, "div");
            __builder.AddAttribute(189, "class", "form-group row");
            __builder.AddMarkupContent(190, "\r\n                ");
            __builder.AddMarkupContent(191, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                ");
            __builder.OpenElement(192, "div");
            __builder.AddAttribute(193, "class", "col-sm-8");
            __builder.AddMarkupContent(194, "\r\n                    ");
            __builder.OpenElement(195, "label");
            __builder.AddAttribute(196, "type", "text");
            __builder.AddAttribute(197, "readonly", true);
            __builder.AddAttribute(198, "class", "form-control-plaintext");
            __builder.AddContent(199, 
#nullable restore
#line 99 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n\r\n            ");
            __builder.OpenElement(203, "div");
            __builder.AddAttribute(204, "class", "form-group row");
            __builder.AddMarkupContent(205, "\r\n                ");
            __builder.AddMarkupContent(206, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                ");
            __builder.OpenElement(207, "div");
            __builder.AddAttribute(208, "class", "col-sm-8");
            __builder.AddMarkupContent(209, "\r\n                    ");
            __builder.OpenElement(210, "label");
            __builder.AddAttribute(211, "type", "text");
            __builder.AddAttribute(212, "readonly", true);
            __builder.AddAttribute(213, "class", "form-control-plaintext");
            __builder.AddContent(214, 
#nullable restore
#line 106 "C:\VSProjects\BethanysPieShopHRM\BethanysPieShopHRM\Pages\EmployeeDetail.razor"
                                                                                Employee.ExitDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(215, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591