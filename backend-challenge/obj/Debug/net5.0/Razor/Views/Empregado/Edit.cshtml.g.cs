#pragma checksum "D:\Arquivos HD\WEB II\EX 04\concert-backend-challenge\backend-challenge\Views\Empregado\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b317e10b17ba73b7d93f92f36f4333932b95d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empregado_Edit), @"mvc.1.0.view", @"/Views/Empregado/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b317e10b17ba73b7d93f92f36f4333932b95d1", @"/Views/Empregado/Edit.cshtml")]
    public class Views_Empregado_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<backend_challenge.Data.Empregado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Arquivos HD\WEB II\EX 04\concert-backend-challenge\backend-challenge\Views\Empregado\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Empregado</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""id_empregado"" />
            <div class=""form-group"">
                <label asp-for=""primeiro_nome"" class=""control-label""></label>
                <input asp-for=""primeiro_nome"" class=""form-control"" />
                <span asp-validation-for=""primeiro_nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ultimo_nome"" class=""control-label""></label>
                <input asp-for=""ultimo_nome"" class=""form-control"" />
                <span asp-validation-for=""ultimo_nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""telefone"" class=""control-label""></label>
                <input asp-for=""telefone"" class=""form-contro");
            WriteLiteral(@"l"" />
                <span asp-validation-for=""telefone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""endereco"" class=""control-label""></label>
                <input asp-for=""endereco"" class=""form-control"" />
                <span asp-validation-for=""endereco"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<backend_challenge.Data.Empregado> Html { get; private set; }
    }
}
#pragma warning restore 1591
