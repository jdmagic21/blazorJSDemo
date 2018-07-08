#pragma checksum "/Users/jasonutt/Downloads/blazorDemo/BlazerJSDemo/Pages/JSDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a2ca143fc3b8060943f04717f6b6c8357c12238"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazerJSDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazerJSDemo;
    using BlazerJSDemo.Shared;
    using BlazerJSDemo.Pages;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/demo")]
    public class JSDemo : JSDemoModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "JavaScript Interop demo");
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "hr");
            builder.CloseElement();
            builder.AddContent(4, "\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(CallJSMethod));
            builder.AddContent(8, "Call JS Method");
            builder.CloseElement();
            builder.AddContent(9, "\n");
            builder.OpenElement(10, "br");
            builder.CloseElement();
            builder.AddContent(11, "\n");
            builder.OpenElement(12, "p");
            builder.AddAttribute(13, "id", "demop");
            builder.CloseElement();
            builder.AddContent(14, "\n");
            builder.OpenElement(15, "button");
            builder.AddAttribute(16, "class", "btn btn-primary");
            builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(CallCSMethod));
            builder.AddContent(18, "Call C# Method");
            builder.CloseElement();
            builder.AddContent(19, "\n");
            builder.OpenElement(20, "br");
            builder.CloseElement();
            builder.AddContent(21, "\n");
            builder.OpenElement(22, "p");
            builder.AddContent(23, message);
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591