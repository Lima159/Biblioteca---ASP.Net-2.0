#pragma checksum "C:\Users\ialima\Source\Repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56f595d0d9495c7af45f7f26533e366b6c35816c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ialima\Source\Repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\_ViewImports.cshtml"
using PortalBiblioteca;

#line default
#line hidden
#line 2 "C:\Users\ialima\Source\Repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\_ViewImports.cshtml"
using PortalBiblioteca.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56f595d0d9495c7af45f7f26533e366b6c35816c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fbc20716f7fdf83a30de2063aed39512d096e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ialima\Source\Repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1021, true);
            WriteLiteral(@"
<style>
    .button {
      background-color: #6699ff; /* Green */
      border: none;
      color: white;
      padding: 15px 32px;
      text-align: center;
      text-decoration: none;
      display: inline-block;
      font-size: 16px;
    }
</style>

<div style=""width:1000px; height:200px; background-color:white"">
    <div class=""text-center"" style=""background-color:#6699ff"">
        <h1 class=""display-4"">Portal Biblioteca</h1>
        <p>Subscreva para mais ofertas <a href=""https://github.com/Lima159/Biblioteca---ASP.Net-2.2.0"">CLIQUE AQUI</a>.</p>
    </div>

    <div align=""center"" class=""form-group"" style=""color:midnightblue"">
        <a href=""/livro"" class=""button""> Livros</a>
        <a href=""/autor"" class=""button""> Autores</a>
        <a href=""/editora"" class=""button""> Editora</a>
        <a href=""/leitor"" class=""button""> Leitores</a>
        <a href=""/genero"" class=""button""> Gêneros</a>
        <a href=""/emprestimo"" class=""button""> Empréstimos</a>
    </div>
</div>");
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
