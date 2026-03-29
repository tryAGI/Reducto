# Reducto

[![Nuget package](https://img.shields.io/nuget/vpre/Reducto)](https://www.nuget.org/packages/Reducto/)
[![dotnet](https://github.com/tryAGI/Reducto/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Reducto/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Reducto)](https://github.com/tryAGI/Reducto/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Reducto OpenAPI specification](https://storage.googleapis.com/stainless-sdk-openapi-specs/reducto%2Freductoai-9dcbb133ea8d4e419314a5fddc878258610a80acfe82604b328a7eb3cb4f8f5f.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Reducto;

using var client = new ReductoClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Reducto/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Reducto/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
