// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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