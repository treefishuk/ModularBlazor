using ModularBlazor.Core;
using System.Collections.Generic;

namespace ModularBlazor.ModuleOne
{
    public class Registration : IModule
    {
        public string Name => "Module One";
        public List<NavItem> NavItems => new List<NavItem> { 
            new NavItem { Name = "Module One Test", Url = "/test" } 
        };
    }
}
