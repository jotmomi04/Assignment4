#pragma checksum "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0e22a5dcad43272b77b273914da593a68d78f5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\2nd trem\asp.net\Plagar App\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CharacterList")]
    public partial class CharacterList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CharacterList</h3>\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 4 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
     foreach (var CharacterList in Characters)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "checkbox");
            __builder.AddAttribute(5, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
                                           CharacterList.IsFicttional

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CharacterList.IsFicttional = __value, CharacterList.IsFicttional));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
                                                                          CharacterList.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "li");
            __builder.AddContent(10, 
#nullable restore
#line 7 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
             CharacterList.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "li");
            __builder.AddContent(13, 
#nullable restore
#line 8 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
             CharacterList.Profession

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
       
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "placeholder", "Title");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
                                  newTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTitle = __value, newTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "placeholder", "Age");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
                                newAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAge = __value, newAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "placeholder", "Profession");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
                                       newProfession

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newProfession = __value, newProfession));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
                  Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Add Title");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\2nd trem\asp.net\Plagar App\BlazorApp\Pages\CharacterList.razor"
        
    private List<Character> Characters = new();
    private string newTitle;
    private int newAge;
    private string newProfession;
   
     private void Title()
    { if(!string.IsNullOrWhiteSpace(newTitle))
    { 
        Characters.Add(new Character { Title = newTitle });
            newTitle = string.Empty;
           
        };
  
    }
  private void Age(){
Characters.Add(new Character { Age = newAge });

  }
   private void Profession(){
Characters.Add(new Character { Profession = newProfession });

  }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
