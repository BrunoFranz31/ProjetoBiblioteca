#pragma checksum "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7073f264074b45c47d6b7526727cd008764e069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuarios.cshtml")]
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
#line 1 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7073f264074b45c47d6b7526727cd008764e069", @"/Views/Usuario/ListarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c632aee1c6109a664772be6f7ee76d46bec2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"row justify-content-md-center\">Usuários cadastrados no sistema</h1>\r\n<br>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 6 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<div class=""row"">
    <div class=""col-md-12"">
<table class=""table table-striped"">
    <thead>
        <tr >
            <th scope=""row"">Nome</th>
            <th scope=""row"">Login</th>
            <th scope=""row"">Tipo</th>
        </tr>
    </thead>
    
    <tbody>
");
#nullable restore
#line 20 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 25 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
             if(u.Tipo==Usuario.ADMIN)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Administrador</td>\r\n");
#nullable restore
#line 28 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Padrão</td>\r\n");
#nullable restore
#line 32 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 777, "\"", 806, 2);
            WriteAttributeValue("", 784, "editarUsuario?id=", 784, 17, true);
#nullable restore
#line 33 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 801, u.Id, 801, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 867, "\"", 897, 2);
            WriteAttributeValue("", 874, "ExcluirUsuario?id=", 874, 18, true);
#nullable restore
#line 34 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 892, u.Id, 892, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Excluir</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "D:\CURSO TI\MÓDULO 2\UC 07\atividade 2\Projeto Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>\r\n</div>\r\n<br>\r\n<div style=\"text-align: center;\"><a href=\"RegistrarUsuarios\">Registrar novo usuário</a></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
