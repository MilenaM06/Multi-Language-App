# Multi-Language Application with CI/CD and MSI Deployment

## Project Purpose

This project demonstrates a **multi-language software suite** for Windows, showcasing how to integrate native and managed into a single solution with automated build, test, and deployment.

The project also provides a **CI/CD pipeline with GitHub Actions** and an **MSI installer (WiX Toolset)** to package and distribute the application.

---

## What It Does

### Integrates these components into a single WPF application:

- **Intel Fortran**
- **C++ Native**
- **C++/CLI**
- **.NET Framework**
- **.NET Standard / .NET 6+**
- **WPF (.NET)**

### Includes:

- Unit & UI tests
- Logging in native and managed code
- GitHub Actions CI/CD pipeline
- MSI installer built with WiX Toolset

---

## Technologies Used

| Component               | Technology                 |
| ----------------------- | -------------------------- |
| **Fortran**             | Intel Fortran (OneAPI)     |
| **C++ Native/ C++/CLI** | MSVC Toolset               |
| **.NET Framework**      | .NET Framework 4.7.2       |
| **.NET Core**           | .NET 8                     |
| **UI**                  | WPF                        |
| **Logging**             | spdlog (C++), Serilog (C#) |
| **Installer**           | WiX Toolset (v3)           |
| **CI/CD**               | GitHub Actions             |
| **Testing Frameworks**  | NUnit, Google Test         |
| **Package Management**  | NuGet                      |

---

## Repository Structure

```text
/root
│
├── FortranSolution/
│   └── FortranProject
│       └── FortranProject.vfproj
│    └── FortranProject.sln
│
├── DotNetSolution/
│   └── CppProject
│       └── CppProject.vcxproj
│   └── CliProject
│       └── CliProject.vcxproj
│   └── NetFrameworkApp
│       └── NetFrameworkApp.csproj
│   └──  NetStandardLib
│       └──  NetStandardLib.csproj
│   └──  WpfApp
│       └──  WpfApp.csproj
│   └── Tests
│       └──  CppNativeTests
        └──  CliTests
        └──  DotNetTests
        └──  UITests
    └──  DotNetSolution.sln
│
├── Installer/
│   └──  Product.wxs
│   └──  Installer.sln
│
└── .github/workflows/ci-cd.yml
```

## CI/CD Workflow

Fully automated CI/CD pipeline implemented with **GitHub Actions** running on **Windows hosted runners**.

### Pipeline Stages

- **Checkout and restore dependencies**
- **Install Intel OneAPI & WiX Toolset**
- **Build Fortran** (via `devenv`)
- **Build .NET & C++ projects** (via `msbuild`)
- **Run unit tests**
- **Build WPF application**
- **Package everything into an MSI installer and upload it as an artifact**
- **Deploy app on a hosted runner and run UI tests**
- **Upload logs as an artifact**

---

## 🖥️ How It Works

- 📝 **Fortran project** is compiled first and produces a DLL used by the WPF application.
- 🔗 **C++ Native** is compiled as a static `.lib` and linked into **C++/CLI**, which produces a `.dll` for managed code.
- 🔄 **C++/CLI**, **.NET Framework**, and **.NET Standard** are referenced in the WPF app.
- 🎨 **WPF app** integrates all components and provides buttons to invoke each one and display their outputs.
- 🧪 **Unit tests** (NUnit, Google Test) validate individual components.
- 👀 **UI tests** (with `System.Windows.Automation`) validate the installed application.
- 📜 **Logs** from both native (spdlog) and managed (Serilog) components are written to files and uploaded as artifacts.
- 📦 **WiX Toolset** packages the WPF executable and its dependencies into an MSI installer.

---

## ✨ Highlights

- 🌐 **Multi-language integration**: Fortran, C++, C#, .NET
- 🔄 **End-to-end automation**: build → test → package → artifact
- 📦 **Installer**: professional MSI with WiX
- 📜 **Logging**: native & managed, human-readable & JSON
- 🧪 **Tests**: Unit & UI, integrated into pipeline
- 🚀 **CI/CD**: Runs on Windows runners with Visual Studio & OneAPI
