using System;
using System.Collections.Generic;

namespace ModularBlazor.Core
{
    public interface IModule
    {
        string Name { get; }

        List<NavItem> NavItems { get; }

    }
}
