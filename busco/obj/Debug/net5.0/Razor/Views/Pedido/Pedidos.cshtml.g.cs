#pragma checksum "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96aa6ad0dbcfd79c16697ef61db624c284cb2c25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Pedidos), @"mvc.1.0.view", @"/Views/Pedido/Pedidos.cshtml")]
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
#line 1 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\_ViewImports.cshtml"
using busco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\_ViewImports.cshtml"
using busco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96aa6ad0dbcfd79c16697ef61db624c284cb2c25", @"/Views/Pedido/Pedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e015e12421e115c5a0cdb2a68571df259cd2d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Pedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Lista de Pedidos</h1>

<table class=""table border"">
    <tr>
        <th>Id</th>
        <th>Nombre del Producto</th>
        <th>Foto</th>
        <th>Descripción</th>
        <th>Precio del Producto</th>
        <th>Celular del Cliente</th>
        <th>Lugar del Pedido</th>
        <th>Nombre del Cliente</th>
        <th>Categoria</th>
    </tr>
");
#nullable restore
#line 17 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.Foto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.Lugar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.NombreCliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
           Write(item.Categoria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 33 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
     if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"4\" class=\"text-center\">No se encontraron Pedidos</td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "E:\Universidad\USMP\Ciclos\Reubicacion II\Programacion I\Busco\AppBusco\busco\Views\Pedido\Pedidos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/busco/registrarpedido\" class=\"btn btn-primary\">Añadir Nuevo Pedido</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591