#pragma checksum "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686d8865d6752576c8636bbbfd3564d4174a9244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
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
#line 1 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686d8865d6752576c8636bbbfd3564d4174a9244", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tasks>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
      
        ViewData["Title"] = "Ana Sayfa";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #ust{
        margin-top:10%;
    }
</style>

<div class=""container mt-4"" id=""ust"">
    <div class=""row text-center"">
        <div class=""col"" id=""ust"">
            <h2>Görevler Listesi</h2>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col"">
            <a href=""/Task/Add"" class=""btn btn-outline-warning mb-2"">Yeni Görev Ekle</a>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col-9"">
            <table class="" table table-hover"">
                <tr>
                  <th>Görev No</th>
                  <th>Görev Başlığı</th>
                  <th>Görev Açıklaması</th>
                  <th>Görev Sahibi</th>
                  <th>Durumu</th>
                  <th>Düzenle</th>
                </tr>
                <tbody class=""table-group-divider"">

");
#nullable restore
#line 41 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                     foreach (var tags in Model)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                       Write(tags.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n                        <td>");
#nullable restore
#line 45 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                       Write(tags.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                       Write(tags.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                       Write(tags.Owner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                       Write(tags.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                     if (@tags.Status == "Oluşturuldu")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1517, "\"", 1545, 2);
            WriteAttributeValue("", 1524, "/Task/Update/", 1524, 13, true);
#nullable restore
#line 52 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
WriteAttributeValue("", 1537, tags.Id, 1537, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1614, "\"", 1642, 2);
            WriteAttributeValue("", 1621, "/Task/Delete/", 1621, 13, true);
#nullable restore
#line 53 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
WriteAttributeValue("", 1634, tags.Id, 1634, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                        </td>\r\n");
#nullable restore
#line 55 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                    }
                    else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                            <a class=\"btn btn-outline-success disabled\"");
            BeginWriteAttribute("href", " href=\"", 1877, "\"", 1905, 2);
            WriteAttributeValue("", 1884, "/Task/Update/", 1884, 13, true);
#nullable restore
#line 59 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
WriteAttributeValue("", 1897, tags.Id, 1897, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n                            <a class=\"btn btn-outline-danger disabled\"");
            BeginWriteAttribute("href", " href=\"", 1991, "\"", 2019, 2);
            WriteAttributeValue("", 1998, "/Task/Delete/", 1998, 13, true);
#nullable restore
#line 60 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
WriteAttributeValue("", 2011, tags.Id, 2011, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                        </td>\r\n");
#nullable restore
#line 62 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\huawei\Desktop\ReaSinav\Admin\Views\Task\Index.cshtml"

                 
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tasks>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
