# OpenTemenos

This application will a test suite and http client/proxy for [Temenos](https://temenos.com) managed by Elevate Data.

## Getting Started

First, an overview. Temenos is a web-based, core banking system. In order to interface with it, we need to be able to work with their REST APIs.
Their APIs are severely micro-serviced to the point that there are 400+ OpenApi specification documents used to interface will all endpoints that are currently active.
This is by no means an easy thing to work around. This is where the `OpenTemenos` library comes in. It is designed to be an organizational abstraction level to the main APIs. 
This also manages HttpClient creation to ensure that an app does not become thread starved. As such, virtually all the code for the class libraries that `OpenTemenos` references
are generated by references in the `*.csproj` and OpenApi `json/yaml` files and should almost never be edited directly.

### Installation process

When deploying there are a couple of parameters that mush be supplied. The currently required variables are:

- Temenos Credentials. These can be *either*
  - `TemenosCredential__ApiKey`
  - `TemenosCredential__UserName` *and* `TemenosCredential__Password`

### Software dependencies

Everything is included in the .NET6 SKD.

### Latest releases

Still working on the initial build. Most OpenApi specs have been read in and have a basic shell of integration testing created.

### API references

- [Temenos API Docs: Getting started](https://apidocs.temenos.com/getting-started) - the primary source of documentation.
- [GitHub: Temenos APIs](https://github.com/temenos/APIs/) - a GutHub repo that the Temenos team uses to host all the OpenApi specs used in the previous website.
A copy of this is what is used in this application.
- NSwag/Visual Studio Connected Services - *complete* documentation on this app in hard to come by and this tool in instrumental in the generation of the client code. These settings can be found in the `*.csproj` files in `OpenApiReference` items. Here is a brief description of what each parameter means.
  - **Include** - This is where a local copy of the Temenos OpenApi specs will be saved. To have a little more control, these are being copied over manually from [GitHub: Temenos APIs](https://github.com/temenos/APIs/).
  - **CodeGenerator** - We are using the `NSwagCSharp` code generator. That means that all items in the **Options** tag are command line parameters for NSwag.
  - **SourceUri** - The GitHub URL that is the master version of the OpenApi spec. If the local version is missing, a copy will be downloaded from here and stored in the path indicated by **Include**.
  - **OutputPath** - The name of the class to save the code as in the `obj` folder. This must be set and be unique for each spec since we are going to be saving the outputs of several specs in the same project.
  - **ClassName** - This unique class name is the value we will use in the client. This should be close to the original file name to make it easier to trace back between the systems. We override this name in the OpenTemenosClient to more closely match what is on the [Temenos API Docs: Getting started](https://apidocs.temenos.com/getting-started) site.
  - **Options** - These items are passed as command line parameters to the NSwag command during code generation. The format is as follows `/Parameter:Value` and are space separated.
    - **ContractsOutput** - The contracts output file path (optional, if no path is set then a single file with the implementation and contracts is generated)
    - **ContractsNamespace** - The namespace to use on the generated classes for contracts (interface and models)
    - **GenerateClientInterfaces** - Create an interface for the client class. This makes usage quite easier.
    - **JsonLibrary** - Specify between `SystemTextJson` and `NewtonSoft`. While `SystemTextJson` is experimental, it is faster and smaller than `NewtonSoft`.
    - **GenerateNullableReferenceTypes** - Specifies whether whether to enumerate Nullable Reference Type annotations.
    - **AdditionalNamespaceUsages** - Additional namespaces to include in using directives for the client.
    - **GenerateExceptionClasses** - Specifies whether to generate custom exception classes or not. Since we have more than one spec we are not generating them and will have to supply them manually in the `Shared` library.
    - **ExcludedTypeNames** - The excluded DTO type names (must be defined in an import or other namespace). These are classes/models/types other than exception that exist in all specs for Temenos.
    - **GenerateContractsOutput** - Specifies whether to generate contracts output (interface and models in a separate file set with the ContractsOutput parameter).
    - **AdditionalContractNamespaceUsages** - Additional namespaces to include in using directives for the contracts (Comma separated list on command line).
    - **GenerateOptionalParameters** - By default NSwag will create 2 methods per operation, one with and one without a CancellationToken, enabling this will combine them. Also, this will default any nullable parameters to null.


## Build and Test

TODO: Describe and show how to build your code and run the tests.

Create a copy of the `OpenTemenos.Tests.testsettings.template.json` called `OpenTemenos.Tests.testsettings.json` and update the specified fields.
If you populate the ApiKey field, username and password will be ignored.

Build the code like always. Unit testing can be run in bulk.

## Contribute

TODO: Explain how other users and developers can contribute to make your code better.