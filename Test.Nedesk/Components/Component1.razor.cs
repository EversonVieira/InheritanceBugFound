using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using Test.Nedesk;
using Test.Nedesk.Shared;

namespace Test.Nedesk.Components
{
    public partial class Component1<TItem, TSource> where TItem:List<int>
                                                    where TSource : List<int>
    {
        [Parameter]
        public string Input { get; set; }

        [Parameter]
        public EventCallback<string> InputChanged { get; set; }
    }
}