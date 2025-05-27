# Creating a Function App

A sample C# Azure Functions solution demonstrating:

- **HTTP-triggered** functions (`Echo`, `GetSettingInfo`)  
- **Timer-triggered** (“`recurring`”) functions  
- Configuration via **Application Settings**  
- Local emulation and cloud deployment  

---

## 📄 Table of Contents

1. [Project Overview](#project-overview)  
2. [Prerequisites](#prerequisites)  
3. [Solution Structure](#solution-structure)  
4. [Getting Started](#getting-started)  
   - [Cloning & Setup](#cloning--setup)  
   - [Running Locally](#running-locally)  
   - [Testing](#testing)  
5. [Deployment](#deployment)  
6. [Configuration](#configuration)  
7. [Contributing](#contributing)
8. [Additional Resources](#additional-resources)

---

## Project Overview

This repository contains a .NET 8.0 Azure Functions app showcasing:

- **`Echo`** — An HTTP-triggered function that echoes back request payloads.
- **`Recurring`** — A Timer-triggered function running on a schedule (default: every 5 minutes).  
- **`GetSettingInfo`** — Reads from Application Settings (environment) and returns key values.  


Use this as a starter template for building serverless workflows on Azure Functions.

---

## ⚙️ Prerequisites

- **Azure Subscription**  
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)  
- [Azure Functions Core Tools v5+](https://docs.microsoft.com/azure/azure-functions/functions-run-local#v2)  
- [Azure CLI](https://docs.microsoft.com/cli/azure/install-azure-cli) _(for deployment)_

---

## 📁 Solution Structure
```plaintext
Azure_Projects/
├── .vscode/ ← VS Code launch/debug settings
├── Echo.cs ← HTTP Trigger: echo back request data
├── GetSettingInfo.cs ← HTTP Trigger: read & display App Settings
├── Recurring.cs ← Timer Trigger: runs per cron schedule
├── host.json ← Functions host configuration
├── func.csproj ← C# project file & NuGet dependencies
└── readme.md ← (this file)
```

---

## 🚀 Getting Started

### Cloning & Setup

```bash
git clone https://github.com/dubemliveson/Azure_Projects.git
cd Azure_Projects
```

Restore NuGet packages:
```bash 
dotnet restore
```

### Running Locally
Start the Functions host:
```bash 
func start
```

- **HTTP APIs**
  - `Echo`: `GET|POST http://localhost:7071/api/Echo`
  - `GetSettingInfo`:
`GET http://localhost:7071/api/GetSettingInfo?key=<YourSettingName>`
- **Timer Trigger**
  - `Recurring` will run automatically on startup and every 5 minutes by default.

### 🧪 Testing
You can exercise the HTTP functions via *cURL*, *Postman*, or your browser:
```bash
curl -X POST http://localhost:7071/api/Echo \
     -H "Content-Type: application/json" \
     -d '{"message":"hello"}'`
```

## ☁️ Deployment

1. **Login** to Azure CLI:
`az login`

2. **Create** a Function App (one-time):
```bash
az functionapp create \
  --resource-group MyResourceGroup \
  --consumption-plan-location westus \
  --runtime dotnet \
  --functions-version 5 \
  --name <YOUR_FUNCTION_APP_NAME> \
  --storage-account <YOUR_STORAGE_ACCOUNT>`
```

3. **Publish** from your workspace:
`func azure functionapp publish <YOUR_FUNCTION_APP_NAME>`

## 🔧 Configuration

All app settings (connection strings, custom settings, etc.) live in Azure’s *Configuration* blade or your local `local.settings.json`.
Be sure to add:
```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "<Your_Storage_Conn_String>",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "MyCustomSetting": "SomeValue"
  }
}
```

You can then read `MyCustomSetting` via the `GetSettingInfo` function:

`GET /api/GetSettingInfo?key=MyCustomSetting`

## 🤝 Contributing

1. Fork the repo
2. Create your feature branch (`git checkout -b feature/foo`)
3. Commit your changes
4. Open a Pull Request


## Additional Resources

## Additional Resources

- **Step-by-Step Azure Functions Tutorial**  
  A full walkthrough of building and deploying these Azure Functions in C#.  
  Read it here: [Building Azure Functions with C#](https://dev.to/dubemliveson/how-i-built-my-first-serverless-app-in-azure-lessons-learned-for-beginners-3j3b)

