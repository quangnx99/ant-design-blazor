#pragma checksum "D:\Project\MyAntDesignApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23e108e6e23834cd571c3cf8a6398a72311f6e8"
// <auto-generated/>
#pragma warning disable 1591
namespace MyAntDesignApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project\MyAntDesignApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\MyAntDesignApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\MyAntDesignApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\MyAntDesignApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\MyAntDesignApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\MyAntDesignApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\MyAntDesignApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project\MyAntDesignApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\MyAntDesignApp\_Imports.razor"
using MyAntDesignApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project\MyAntDesignApp\_Imports.razor"
using MyAntDesignApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Project\MyAntDesignApp\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-i0ek76vusm");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-i0ek76vusm");
            __builder.OpenComponent<MyAntDesignApp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-i0ek76vusm");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-i0ek76vusm><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-i0ek76vusm>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-i0ek76vusm");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\Project\MyAntDesignApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
