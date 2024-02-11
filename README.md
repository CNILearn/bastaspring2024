# BASTA! Frankfurt 2024

* Be ready for C# 12
* HotChocolate: Ein Heißgetränk oder GraphQL-Backend mit .NET?
* YARP - Yet Another Reverse Proxy
* Logs, metrics, distributed tracing and OpenTelemetry
* XAML-Clients mit WinUI, .NET MAUI, WPF, Uno Platform and Avalonia UI
* Minimal APIs, Docker und Azure Container Apps mit .NET Aspire 

## Be ready for C# 12

Dienstag, 13. Februar 2024, 10:45-11:45, Platinum Ballsaal II

Christian Nagel

C# 12 ist released, an der nächsten Version von C# wird bereits gearbeitet. Mit Primary Constructors und Collection Expressions kann der Code in allen .NET-Applikationen vereinfacht werden. Was dahinter steckt, was es sonst noch Neues in C# gibt, was mit Inline Arrays und Interceptors gemacht werden kann, und was in der nächsten Version von C# geplant ist, lernen Sie in dieser Session.

[C# Slides](slides/csharp12.pdf)

### C# Samples

- Minimal API
- Alias any type
- Primary constructors
- Ref readonly
- Inline arrays
- Collection expressions
- Optional parameters in lambda expressions
- Unsafe accessor
- Interceptors
- Native AOT

## HotChocolate: Ein Heißgetränk oder GraphQL-Backend mit .NET?

Mittwoch, 14. Februar 2024, 15:15-16:15, Platinum Ballsaal II

Sebastian Szvetecz

Alle Liebhaber:innen heißer Schokolade bzw. Kakao muss ich jetzt leider enttäuschen. HotChocolate ist in diesem Kontext kein Heißgetränk, sondern ein GraphQL-Backend für .NET-Entwickler:innen. GraphQL ist eine Abfragesprache für APIs, gilt als DER Gegner von REST und wird unter anderem von Facebook, GitHub und Pinterest verwendet. In dieser Session werden wir noch genauer aufarbeiten, was GraphQL ist und warum es ein würdiger Gegner von REST ist. Außerdem werden wir uns ansehen wie einfach man mit ASP.NET Core und HotChocolate ein GraphQL API umsetzen kann. Unser GraphQL API soll nicht nur mit Hilfe von Entity Framework Core auf eine Datenkbank zugreifen, sie soll dem Client auch ermöglichen, Daten zu filtern, zu sortieren und zu paginieren, um einen möglichst flexiblen Datenzugriff zu ermöglichen. Filtern, Sortieren und Paginieren – klingt aufwendig? Nein, nicht mit HotChocolate. Aber auch für fortgeschrittenere Szenarien wie z. B. langsame Teilabfragen ist man mit HotChocolate gerüstet.

[Hot chocolate slides](slides/hotchocolate.pdf)

## YARP - Yet Another Reverse Proxy

Donnerstag, 15. Februar 2024, 12:00-13:00, Gold III

Christian Nagel

YARP ist ein Open Source Reverse Proxy, der von Microsoft entwickelt wird. Viele Funktionalitäten können von Services zu diesem Proxy ausgelagert werden. Transformation von Requests, ein Wechsel des Protokolls, Load Balancing, Rate Limiting, Authentication und Authorization und vieles mehr sind Features dieses Proxys. In dieser Session lernen Sie, wie Sie YARP in On-Premises- als auch in Cloud-Szenarien einsetzen können.

[YARP slides](slides/yarp.pdf)

## Logs, metrics, distributed tracing and OpenTelemetry

Donnerstag, 15. Februar 2024, 15:30-16:30, Platinum Ballsaal II

Christian Nagel

Grafana? Prometheus? Application Insights? OpenTelemetry? Am Beispiel einer verteilten Lösung, die sowohl on Premises als auch mit Azure Cloud Services läuft, sehen Sie wie Log, Metrics, und Distributed Tracing mit .NET-Applikationen implementiert und die Daten mit Grafana und Prometheus sowie Azure Services wie Azure Monitor, Log Analytics und Application Insights ausgewertet werden können.

[Telemetry slides](slides/telemetry.pdf)

### Telemetry samples

## XAML-Clients mit WinUI, .NET MAUI, WPF, Uno Platform and Avalonia UI

Donnerstag, 15. Februar 2024, 17:00-18:00, Platinum Ballsaal I

Sebastian Szvetecz, Christian Nagel

Es gibt einen .NET-Backend-Service für eine Spiele-App. Dazu bauen wir Clients mit WinUI, .NET MAUI, WPF, Platform Uno und Avalonia UI. Gestartet wird mit gemeinsamem Libraries: Clientcode, um die APIs aufzurufen, und eine View-Model Library, die mit allen XAML-basierten Clients zum Einsatz kommt. Danach bauen wir Clients, um gleich die Vor- und Nachteile sowie die Unterschiede und Gemeinsamkeiten dieser Technologien aufzeigen. Welche dieser Plattformen ist am besten für Ihre Anforderungen geeignet? Am Ende des Tages gibt es laufende WinUI-, .NET-MAUI-, WPF-, Platform-Uno- und Avalonia-UI- Clients.

[XAML Slides](slides/xaml.pdf)

### XAML samples

- ViewModels
  - [Codebreaker Viewmodels](https://github.com/CodebreakerApp/Codebreaker.Xaml/tree/main/src/Codebreaker.ViewModels)
- WPF
  - WPF with .NET Framework
  - Upgrade assistant converted, C# updates
  - Template Studio for WPF
  - [Codbreaker WPF](https://github.com/CodebreakerApp/Codebreaker.Xaml/tree/main/src/Codebreaker.WPF)
- WinUI
  - Template Studio for WinUI
  - [Codebreaker WinUI](https://github.com/CodebreakerApp/Codebreaker.Xaml/tree/main/src/Codebreaker.WinUI)
- .NET MAUI
  - .NET MAUI with MAUI Accelerator
 - [Codebreaker MAUI](https://github.com/CodebreakerApp/Codebreaker.Xaml/tree/main/src/Codebreaker.MAUI)
- Uno Platform
  - 
  - [Codebreaker Uno](https://github.com/CodebreakerApp/Codebreaker.Xaml/tree/main/src/Codebreaker.Uno)
- Avalonia UI
  - [Codebreaker Avalonia](https://github.com/CodebreakerApp/Codebreaker.Xaml/tree/main/src/Codebreaker.Avalonia)

### XAML Links

- Common
  - [Codebreaker XAML clients and shared view-models](https://github.com/CodebreakerApp/Codebreaker.Xaml)
  - [Community Toolkit .NET](https://github.com/CommunityToolkit/dotnet)
  - [Community Toolkit Labs](https://toolkitlabs.dev/)
- WPF
  - [WPF Repo](https://github.com/dotnet/wpf)
  - [WPF .NET 9 Milestone](https://github.com/dotnet/wpf/milestone/38)
- WinUI
  - [WinUI Repo](https://github.com/microsoft/microsoft-ui-xaml)
  - [Windows App SDK](https://github.com/microsoft/WindowsAppSDK)
  - [Windows calculator](https://github.com/microsoft/calculator)
  - [Windows Community Toolkit for WinUI and Uno](https://github.com/CommunityToolkit/Windows)
- MAUI
  - [MAUI Repo](https://github.com/dotnet/maui)
  - [.NET MAUI Community Toolkit](https://github.com/CommunityToolkit/Maui)
- Uno Platform
  - [Uno Platform](https://platform.uno/)
  - [Calculator](https://platform.uno/uno-calculator/)
  - [GitHub Uno Platform](https://github.com/unoplatform/uno)
  - [Uno Gallery](https://gallery.platform.uno/)
  - [Uno Playground](https://playground.platform.uno)
  - [Windows Community Toolkit for WinUI and Uno](https://github.com/CommunityToolkit/Windows)
  - [Device APIs](https://aka.platform.uno/demo-unexpected-apis)
  - [Views implemented with Uno](https://platform.uno/docs/articles/implemented-views.html)
- Avalonia UI 
  - [Avalonia UI](https://www.avaloniaui.net/)
  - [Avalonia Playground](https://play.avaloniaui.net/)
  - [Avalonia GitHub](https://github.com/AvaloniaUI/Avalonia)

## Minimal APIs, Docker und Azure Container Apps mit .NET Aspire

Freitag, 16. Februar 2024, 8:30 - 16:30, Basalt WS

Christian Nagel, Sebastian Szvetecz

.NET Aspire ist Microsoft's .NET cloud ready stack der es erleichtert eine Lösung basierend auf Microservices zu entwickeln. .NET Aspire bietet Tools, Komponenten, und Orchestration für .NET. In diesem Workshop werden bestehende Clients genutzt. Das Backend wird mit Unterstützung von .NET Aspire gebaut. Damit lernen Sie Azure Services wie Azure Container Apps, Cosmos DB, Log Analytics und Application Insights kennen, sehen die Funktionalität die .NET Aspire anbietet, und können die Lösung auch ohne Azure Services in einer Docker Landschaft On-Premises betreiben.

See [Codebreakerlight](https://github.com/codebreakerapp/codebreakerlight)
