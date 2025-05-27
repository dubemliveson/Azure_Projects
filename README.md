# Azure_Projects

A central repository for all Azure-related code samples and automation.  
Use this space to collect your Functions, API Management configurations, Infrastructure as Code, DevOps pipelines, and more—all organized by project type.

---

## 📖 Table of Contents

1. [Overview](#overview)  
2. [Repository Structure](#repository-structure)  
3. [Current Projects](#current-projects)  
4. [Adding a New Project](#adding-a-new-project)  
5. [Contributing](#contributing)  
6. [Naming & Layout Conventions](#naming--layout-conventions)  
7. [Prerequisites & Tooling](#prerequisites--tooling)  

---

## Overview

This repo is intended as a one-stop shop for your Azure samples and automation. Keep each logical piece of work in its own folder—whether it’s a Functions app, an ARM template, a Bicep module, or an API Management deployment configuration.

---

## Repository Structure

```plaintext
Azure_Projects/
├── Functions/            ← C# / JavaScript / Python Azure Functions apps
│   ├── ProjectA/         ← Function app “ProjectA”
│   └── ProjectB/         ← Function app “ProjectB”
├── APIM/                 ← Azure API Management configs & policies
│   └── MyApi/            ← e.g. ARM/Bicep definitions for APIM instance
├── IaC/                  ← Infrastructure as Code (ARM, Bicep, Terraform)
│   ├── Networking/       
│   └── Storage/
├── DevOps/               ← CI/CD pipelines (GitHub Actions, Azure Pipelines)
├── docs/                 ← Shared documentation, architecture diagrams
└── README.md             ← (this file)
```

## Current Projects

- Functions/EchoSample:
    A minimal C# HTTP-triggered function that echoes payloads.
- Functions/SettingsReader:
    Demo of reading and returning Azure Function App Settings.
- Functions/RecurringJob:
    Timer-triggered function that runs on a schedule.
(*More coming soon…*)

## Adding a New Project

1. Choose a category (e.g. Functions, APIM, IaC, DevOps, docs).
2. Create a new folder under that category with a descriptive name:
```bash
mkdir -p Functions/MyNewFunctionApp
```
3. Initialize your code (e.g. `func init`, `bicep new`, `terraform init`).
4. Add a README.md inside the new folder, describing:
- Purpose & overview
- Prerequisites
- How to build/run locally
- How to deploy

5. Commit & push, then update this top-level README.md under Current Projects.

## Contributing
1. Fork the repo.
2. Create a feature branch:

```bash
git checkout -b feature/awesome-azure-sample
```
3. Add your project, tests, and documentation.
4. Open a Pull Request for review.

<br>

## Naming & Layout Conventions

- **Folder names:** PascalCase or kebab-case—choose one and stay consistent.
- **IaC modules:** group by resource type (e.g. `Networking`, `Compute`, `Storage`).
- **Pipeline files:** keep at `DevOps/` root or in subfolders per service.
- **Documentation:** use Markdown in `docs/`, with clear cross-links.

<br>

## Prerequisites & Tooling

Depending on project type, you may need:
- .NET SDK
- Azure Functions Core Tools
- Azure CLI
- Bicep CLI
- Terraform
- Git

Always refer to each project’s own README for specific version requirements.




