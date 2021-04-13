
# NOTES

# Blazor .NET

> Written with [StackEdit](https://stackedit.io/).

## **What makes Blazor so flexible?**

Essentially, Blazor has a separation between how it calculates UI changes (app/component model) and how those changes are applied (renderer). This sets Blazor apart from other UI frameworks such as Angular or ReactJS/React Native that can only create web technology based UIs. By using different renderers Blazor is able to create not only web based UIs, but also native mobile UIs as well.
<b/>
<b/>
<b/>


![](https://lh5.googleusercontent.com/7qSVTvfd6ZYFSsdvRwk_33JmqzlfZlFdF1VVncQYcbR3qSYrrJLd5NkjKD-hnOTcJT103JVlYQT_1dmgnO9TONczizPWqYXs2622cNz2CAiQVBEXlmt4jK8Of0FpFo5rHSHn14Lb)

<b/>
<b/>
<b/>

### **Render/Hosting Model**

At its core, Blazor’s app/component model is responsible for calculating UI changes, but you can use different renderers to control how the UI is actually displayed and updated. These renderers are more commonly referred to as hosting models. At the time of writing, there are four hosting models for Blazor in various stages of development.  

**Blazor Server** (Remote Renderer)

-   Platform:  **Web**
-   Status –  **GA/Production Supported**

**Blazor WebAssembly** (WebAssembly Renderer)

-   Platform:  **Web**
-   Status:  **Preview (Committed Product)**

**Blazor Electron** (Electron Renderer)

-   Platform:  **Desktop (Windows, Mac, and Linux)**
-   Status:  **Experimental (Not Committed)**

**Mobile Blazor Bindings**  (MobileBlazorBindings Renderer)

-   Platform:  **Mobile (iOS and Android)**
-   Status:  **Experimental (Not Committed)**

### **App/Component Model**

This is the engine room of the framework. Here we can find all the non-UI specific elements which make Blazor work. The programming model, routing and navigation, and the render tree, which is Blazor’s mechanism for calculating UI changes.

The part I want to focus on though is the programming model. Out of the four hosting models I talked about above, the first three have one thing in common, they all understand web standards. Components authored to target these hosting models will be using *HTML* and *CSS*. But the fourth model, Mobile Blazor bindings, doesn’t understand web standards at all. Applications built for this hosting model will need to have their components written using native mobile controls.

```java
 // WebAssembly Renderer

<div>
 <p>Current count: @currentCount</p>
 <button class="btn btn-primary" @onclick="IncrementCount">Click me</button>
</div>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
```

```java
// MobileBlazorBindings Renderer

<StackLayout>
 <Label FontSize="30" Text="@($"Current count: {currentCount}")" />
 <Button Text="Click me" OnClick="@IncrementCount" />
</StackLayout>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}

```

**The programming model is practically the same!**
<b/>
<b/>
## **Blazor Server**

![](https://lh4.googleusercontent.com/jWAcExuurXUSaF6s4P7JgHvJHSoRpZecXTK9OcryYo3EXXH1L4GGt-zB2Lro4dTytVNL-pw7-PpEX1JUAR939hHnIHe3AJWVSKGQnINVCqSdS_Rm_XX5hTLkipo3GbAlrwFVLUlw)

In this model, the Blazor application runs on the server on top of the full .NET Core runtime. When the user loads the application a small JavaScript file is downloaded which establishes a real-time, two-way [SignalR](https://docs.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-3.1) connection with the server. Any interaction that the user has with the app is then transmitted back to the server over the SignalR connection for the server to process. After the server is done, any UI updates are transmitted back to the client and applied to the [DOM](https://en.wikipedia.org/wiki/Document_Object_Model) (Document Object Model).

<b/>
<b/>

## **Blazor WebAssembly**

This is the big one, the hosting model that usually gets most interest, and for good reason. This model offers a direct competitor to JavaScript SPAs such as *Angular*, *VueJS*, and *React*.

![](https://lh3.googleusercontent.com/mOlbeBLFNYCEl6CdctXBoadoKK3JRV2wONEStZmheeb0vJXwMPC8FEjDjjmvbH9Hoq_x2G8I03xX8hKlKdXi8azoWX5YXqAfPBLM1aHTWqjj_chj4l7FUjsQMDyT8rvOe55giwRK)

A version of the [Mono .NET runtime](https://www.mono-project.com/), compiled to WebAssembly, is downloaded to the client’s browser along with the application DLLs and any dependencies. WebAssembly is basically a language that can run directly on the browser. Once everything is in the browser, the Mono runtime is bootstrapped, and it, in turn, loads and executes the application DLLs.

Currently, Blazor WebAssembly uses interpreted mode to load and run your application. In this mode, the Mono IL interpreter executes your applications .NET DLLs inside the browser. The only part of the process that is compiled to WebAssembly is the Mono runtime.

It’s also important to point out that using Blazor WebAssembly doesn’t require you to use .NET on the server. Meaning if you have a backend written in Node, PHP, or Rails you can happily use Blazor as the frontend without any issues as Blazor WebAssembly compiles to static files.
