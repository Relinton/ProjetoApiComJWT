#pragma checksum "D:\Relinton Sistemas\Projetos API\ProjetoApiComJWT\ConsumindoApiViaJQuery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da69c398e480558de0a1ee3718a0eca9faac7fac"
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
#line 1 "D:\Relinton Sistemas\Projetos API\ProjetoApiComJWT\ConsumindoApiViaJQuery\Views\_ViewImports.cshtml"
using ConsumindoApiViaJQuery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Relinton Sistemas\Projetos API\ProjetoApiComJWT\ConsumindoApiViaJQuery\Views\_ViewImports.cshtml"
using ConsumindoApiViaJQuery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da69c398e480558de0a1ee3718a0eca9faac7fac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6d2fb30112d2503438900d5f75c56bc37fb718", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Relinton Sistemas\Projetos API\ProjetoApiComJWT\ConsumindoApiViaJQuery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>


<button type=""button"" id=""login"">Login</button>
<button type=""button"" id=""logout"">Logout</button>
<button type=""button"" id=""showData"">Exibir Dados</button>
<div id=""response""></div>

<script>
    $(document).ready(function () {
        $(""#login"").click(function () { });
        $(""#showData"").click(function () { });
        $(""#logout"").click(function () { });
    });
    $(""#login"").click(function () {
        var options = {};
        options.url = ""/api/seguranca"";
        options.type = ""POST"";
        var obj = {};
        obj.userName = ""Relinton"";
        obj.password = ""12345678"";
        options.data = JSON.stringify(obj);
        options.contentType = ""application/json"";
        options.dataType = ""json"";
        options.success = function (obj) {
            sessionStorage.setItem(""token"", obj.token);
            $(""#response"").html(""<h2>Usu??rio logado com sucesso.</h2>"");
      ");
            WriteLiteral(@"  };
        options.error = function () {
            $(""#response"").html(""<h1>Erro ao chamar a Web API!</h1>"");
        };
        $.ajax(options);
    });
    $(""#exibirDados"").click(function () {
        var options = {};
        options.url = ""/api/usuarios"";
        options.type = ""GET"";
        options.beforeSend = function (request) {
            request.setRequestHeader(""Authorization"",
                ""Bearer "" + sessionStorage.getItem(""token""));
        };
        options.dataType = ""json"";
        options.success = function (data) {
            var table = ""<table border='1' cellpadding='10'>"";
            data.forEach(function (element) {
                var row = ""<tr>"";
                row += ""<td>"";
                row += element.alunoId;
                row += ""</td>"";
                row += ""<td>"";
                row += element.nome;
                row += ""</td>"";
                row += ""</tr>"";
                table += row;
            });
            table += ");
            WriteLiteral(@"""</table>"";
            $(""#response"").append(table);
        };
        options.error = function (a, b, c) {
            $(""#response"").html(""<h1>Erro a chamar a Web API!("" + b + "" - "" + c + "")</h1>"");
        };
        $.ajax(options);
    });

    $(""#logout"").click(function () {
        sessionStorage.removeItem(""token"");
        $(""#response"").html(""<h2>Usu??rio realizou o logout com sucesso.</h2 >"");
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
