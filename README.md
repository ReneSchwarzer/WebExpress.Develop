![WebExpress](https://raw.githubusercontent.com/ReneSchwarzer/WebExpress/main/assets/banner.png)

# WebExpress
`WebExpress` is a lightweight web server optimized for use in low-performance environments (e.g. Rasperry PI). By providing a powerful plugin system and a comprehensive API, web applications can be easily and quickly integrated into a .net language (e.g. C#). Some advantages of `WebExpress` are:

- It is easy to use.
- It offers a variety of features and tools that can help you build and manage your website.
- It is fast and efficient and can help you save time and money.
- It is flexible and can be customized to meet your specific requirements.

The `WebExpress` family includes the following projects:

- [WebExpress](https://github.com/ReneSchwarzer/WebExpress#readme) - The web server for `WebExpress` applications and the documentation.
- [WebExpress.WebCore](https://github.com/ReneSchwarzer/WebExpress.WebCore#readme) - The core for `WebExpress` applications.
- [WebExpress.WebUI](https://github.com/ReneSchwarzer/WebExpress.WebUI#readme) - Common templates and controls for `WebExpress` applications.
- [WebExpress.WebIndex](https://github.com/ReneSchwarzer/WebExpress.WebIndex#readme) - Reverse index for `WebExpress` applications.
- [WebExpress.WebApp](https://github.com/ReneSchwarzer/WebExpress.WebApp#readme) - Business application template for `WebExpress` applications.

# WebExpress.Develop
This repository provides a centralized, all-in-one development environment for the WebExpress ecosystem. It brings together all necessary projects through direct references, removing any reliance on NuGet packages.

## Recommended folder structure
To ensure that all project references resolve correctly and that the solution builds as intended, make sure all required `WebExpress` repositories are placed within the same base directory as `WebExpress.Develop`.
```
base/ 
 ├── WebExpress.Develop/ 
 ├── WebExpress.WebCore/ 
 ├── WebExpress.WebUI/ 
 ├── WebExpress.WebIndex/ 
 ├── WebExpress.WebApp/ 
 └── ...
```

## Build configuration
In Visual Studio (or your build tool of choice), select the `DebugLocal` configuration. This activates conditional project references defined in the `.csproj` files, enabling local development with direct project dependencies rather than NuGet packages.

# Download 
The current binaries are available for download [here](https://github.com/ReneSchwarzer/WebExpress/releases).

# Start
If you're looking to get started with `WebExpress`, we would recommend using the following documentation. It can help you understand the platform.

- [Installation Guide](https://github.com/ReneSchwarzer/WebExpress/blob/main/doc/installation_guide.md) 
- [Development Guide](https://github.com/ReneSchwarzer/WebExpress/blob/main/doc/development_guide.md)
- [WebExpress.WebCore API Documentation](https://reneschwarzer.github.io/WebExpress.WebCore/) 
- [WebExpress.WebUI API Documentation](https://reneschwarzer.github.io/WebExpress.WebUI/) 
- [WebExpress.WebApp API Documentation](https://reneschwarzer.github.io/WebExpress.WebApp/) 
- [WebExpress.WebIndex API Documentation](https://reneschwarzer.github.io/WebExpress.WebIndex/) 

# Learning
The following tutorials illustrate the essential techniques of `WebExpress`. These tutorials are designed to assist you, as a developer, in understanding the various aspects of `WebExpress`. Each tutorial provides a detailed, step-by-step guide that you can work through using an example. If you’re interested in beginning the development of `WebExpress` components, we would recommend you to complete some of these tutorials.

- [HelloWorld](https://github.com/ReneSchwarzer/WebExpress.Tutorial.HelloWorld#readme)
- [WebUI](https://github.com/ReneSchwarzer/WebExpress.Tutorial.WebUI#readme)
- [WebApp](https://github.com/ReneSchwarzer/WebExpress.Tutorial.WebApp#readme)
- [WebIndex](https://github.com/ReneSchwarzer/WebExpress.Tutorial.WebIndex#readme)

# Tags
#WebUI #WebExpress #DotNet #NETCore
