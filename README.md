# ModularBlazor
Example Project of A Modular Blazor Implementation

A while back I asked how to create a Modular Blazor application. This project is a simple example of how to do that using the standard projects and tools availble from Microsoft. No custom framework. No strange things to learn.

## How it works
The core part of a Modular Blazor app is Razor Class libraries

[Microsoft Docs: ASP.NET Core Razor components class libraries](https://docs.microsoft.com/en-us/aspnet/core/blazor/class-libraries?view=aspnetcore-3.1&tabs=visual-studio)

Razor Class libraries Support:
 - Static Files
 - Blazor Componants
 - Blazor Pages
 
The only other thing that is needed is to add some assembly scanning to get the main Blazor projects routing to look at the referenced Razor Class libraries for Blazor Pages.


```
<Router AppAssembly="@typeof(Program).Assembly" AdditionalAssemblies="AssemblyScanning.GetAssemblies().ToArray()">
    <Found Context="routeData">
        <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
    </Found>
    <NotFound>
        <LayoutView Layout="@typeof(MainLayout)">
            <p>Sorry, there's nothing at this address.</p>
        </LayoutView>
    </NotFound>
</Router>
```
