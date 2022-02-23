# MyDataMyConsent.Sdk - the C# library for the My Data My Consent - Developer API

Unleashing the power of data consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://mydatamyconsent.com/en-us/developers](https://mydatamyconsent.com/en-us/developers)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Individual consent request id.

            try
            {
                // Cancel the individual data consent request based on Id.
                IndividualDataConsentRequestResponse result = apiInstance.CancelIndividualDataConsentRequest(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CancelIndividualDataConsentRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.mydatamyconsent.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataConsentRequestsApi* | [**CancelIndividualDataConsentRequest**](docs/DataConsentRequestsApi.md#cancelindividualdataconsentrequest) | **PUT** /v1/consent-requests/individual/{requestId}/cancel | Cancel the individual data consent request based on Id.
*DataConsentRequestsApi* | [**CancelOrganizationDataConsentRequest**](docs/DataConsentRequestsApi.md#cancelorganizationdataconsentrequest) | **PUT** /v1/consent-requests/organization/{requestId}/cancel | Cancel the Organization data consent request based on Id.
*DataConsentRequestsApi* | [**CreateIndividualDataConsentRequest**](docs/DataConsentRequestsApi.md#createindividualdataconsentrequest) | **POST** /v1/consent-requests/individual | Create a individual data consent request.
*DataConsentRequestsApi* | [**CreateOrganizationDataConsentRequest**](docs/DataConsentRequestsApi.md#createorganizationdataconsentrequest) | **POST** /v1/consent-requests/organization | Create a organization data consent request.
*DataConsentRequestsApi* | [**GetAllConsentRequestsToIndividuals**](docs/DataConsentRequestsApi.md#getallconsentrequeststoindividuals) | **GET** /v1/consent-requests/individuals | Get all Consent Requests sent to Individuals.
*DataConsentRequestsApi* | [**GetAllConsentRequestsToOrganizations**](docs/DataConsentRequestsApi.md#getallconsentrequeststoorganizations) | **GET** /v1/consent-requests/organizations | Get All Consent Requests sent to Organizations.
*DataConsentRequestsApi* | [**GetIndividualConsentRequestById**](docs/DataConsentRequestsApi.md#getindividualconsentrequestbyid) | **GET** /v1/consent-requests/individuals/{requestId} | Get a Consent Request by ID.
*DataConsentRequestsApi* | [**GetOrganizationConsentRequestById**](docs/DataConsentRequestsApi.md#getorganizationconsentrequestbyid) | **GET** /v1/consent-requests/organizations/{requestId} | Get a OrganizationConsent Request by Id.
*DataConsentsApi* | [**DownloadConsentedDocumentById**](docs/DataConsentsApi.md#downloadconsenteddocumentbyid) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId}/download | Download a individuals consented document.
*DataConsentsApi* | [**DownloadOrgConsentedDocumentById**](docs/DataConsentsApi.md#downloadorgconsenteddocumentbyid) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId}/download | Download a organizations consented document.
*DataConsentsApi* | [**GetAllConsentedDocuments**](docs/DataConsentsApi.md#getallconsenteddocuments) | **GET** /v1/consents/individuals/{consentId}/documents | Get the individual documents based on ConsentId.
*DataConsentsApi* | [**GetAllConsentedFinancialAccounts**](docs/DataConsentsApi.md#getallconsentedfinancialaccounts) | **GET** /v1/consents/individuals/{consentId}/accounts | Get all individual consented financial accounts.
*DataConsentsApi* | [**GetAllOrganizationConsentedDocuments**](docs/DataConsentsApi.md#getallorganizationconsenteddocuments) | **GET** /v1/consents/organizations/{consentId}/documents | Get the organization documents based on ConsentId.
*DataConsentsApi* | [**GetConsentDetailsById**](docs/DataConsentsApi.md#getconsentdetailsbyid) | **GET** /v1/consents/individuals/{consentId} | Get all individuals consent details by consent id.
*DataConsentsApi* | [**GetConsentFinancialAccounts**](docs/DataConsentsApi.md#getconsentfinancialaccounts) | **GET** /v1/consents/organizations/{consentId}/accounts | Get all organizational consented financial accounts.
*DataConsentsApi* | [**GetConsentedAccountById**](docs/DataConsentsApi.md#getconsentedaccountbyid) | **GET** /v1/consents/individuals/{consentId}/accounts/{accountId} | Get individual consented financial account details based on account id.
*DataConsentsApi* | [**GetConsentedDocumentById**](docs/DataConsentsApi.md#getconsenteddocumentbyid) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId} | Get individuals consent document based on document id.
*DataConsentsApi* | [**GetConsentedFinancialAccount**](docs/DataConsentsApi.md#getconsentedfinancialaccount) | **GET** /v1/consents/organizations/{consentId}/accounts/{accountId} | Get organization consented financial account details based on account id.
*DataConsentsApi* | [**GetConsentedFinancialAccountTransactions**](docs/DataConsentsApi.md#getconsentedfinancialaccounttransactions) | **GET** /v1/consents/individuals/{consentId}/accounts/{accountId}/transactions | Get individual consented financial account transactions of an individual based on accountId.
*DataConsentsApi* | [**GetConsentsForOrganizations**](docs/DataConsentsApi.md#getconsentsfororganizations) | **GET** /v1/consents/organizations | Get the list of data consents sent for organizations.
*DataConsentsApi* | [**GetConsentsSentToIndividuals**](docs/DataConsentsApi.md#getconsentssenttoindividuals) | **GET** /v1/consents/individuals | Get the list of Consents Sent to Individuals.
*DataConsentsApi* | [**GetOrgConsentedAccountTransactions**](docs/DataConsentsApi.md#getorgconsentedaccounttransactions) | **GET** /v1/consents/organizations/{consentId}/accounts/{accountId}/transactions | Get organization consented financial account transactions of an individual based on accountId.
*DataConsentsApi* | [**GetOrganizationConsentDetailsById**](docs/DataConsentsApi.md#getorganizationconsentdetailsbyid) | **GET** /v1/consents/organizations/{consentId} | Get all organization consent details by consent id.
*DataConsentsApi* | [**GetOrganizationConsentedDocumentById**](docs/DataConsentsApi.md#getorganizationconsenteddocumentbyid) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId} | Get organization consent document based on document id.
*DataProcessingAgreementsApi* | [**CreateDataProcessingAgreement**](docs/DataProcessingAgreementsApi.md#createdataprocessingagreement) | **POST** /v1/data-agreements | Create a data processing agreement.
*DataProcessingAgreementsApi* | [**DeleteDataProcessingAgreementById**](docs/DataProcessingAgreementsApi.md#deletedataprocessingagreementbyid) | **DELETE** /v1/data-agreements/{id} | Delete a data processing agreement. This will not delete a published or a agreement in use with consents.
*DataProcessingAgreementsApi* | [**GetDataProcessingAgreementById**](docs/DataProcessingAgreementsApi.md#getdataprocessingagreementbyid) | **GET** /v1/data-agreements/{id} | Get data processing agreement by id.
*DataProcessingAgreementsApi* | [**GetDataProcessingAgreements**](docs/DataProcessingAgreementsApi.md#getdataprocessingagreements) | **GET** /v1/data-agreements | Get all data processing agreements.
*DataProcessingAgreementsApi* | [**TerminateDataProcessingAgreementById**](docs/DataProcessingAgreementsApi.md#terminatedataprocessingagreementbyid) | **PUT** /v1/data-agreements/{id}/terminate | Terminate a data processing agreement.
*DataProcessingAgreementsApi* | [**UpdateDataProcessingAgreement**](docs/DataProcessingAgreementsApi.md#updatedataprocessingagreement) | **PUT** /v1/data-agreements/{id} | Update a data processing agreement.
*DataProviderDiscoveryApi* | [**GetDataProviderById**](docs/DataProviderDiscoveryApi.md#getdataproviderbyid) | **GET** /v1/data-providers/{providerId} | Get a Data Provider details based on provider id.
*DataProviderDiscoveryApi* | [**GetDataProviders**](docs/DataProviderDiscoveryApi.md#getdataproviders) | **GET** /v1/data-providers | Discover all data providers in My Data My Consent by country and filters.
*DigiLockerCompatIssuerApi* | [**DigilockerCompatIssueDocument**](docs/DigiLockerCompatIssuerApi.md#digilockercompatissuedocument) | **POST** /issuer/issuedoc/1/xml | Digilocker Compatible endpoint to issue document.
*DocumentsApi* | [**GetIssuedDocumentById**](docs/DocumentsApi.md#getissueddocumentbyid) | **GET** /v1/documents/issued/{documentId} | Get issued document.
*DocumentsApi* | [**GetIssuedDocuments**](docs/DocumentsApi.md#getissueddocuments) | **GET** /v1/documents/issued/{documentTypeId} | Get paginated list of issued documents of given document type.
*DocumentsApi* | [**GetRegisteredDocumentTypes**](docs/DocumentsApi.md#getregistereddocumenttypes) | **GET** /v1/documents/types | Get registered document types.
*DocumentsApi* | [**IssueDocumentToIndividual**](docs/DocumentsApi.md#issuedocumenttoindividual) | **POST** /v1/documents/issue/individual | Issue a new document to an individual user.
*DocumentsApi* | [**IssueDocumentToOrganization**](docs/DocumentsApi.md#issuedocumenttoorganization) | **POST** /v1/documents/issue/organization | Issue a new document to an organization.
*DocumentsApi* | [**UploadDocumentForIndividual**](docs/DocumentsApi.md#uploaddocumentforindividual) | **POST** /v1/documents/issue/individual/upload/{issueRequestId} | Upload a document for issuance request of individual.
*DocumentsApi* | [**UploadDocumentForOrganization**](docs/DocumentsApi.md#uploaddocumentfororganization) | **POST** /v1/documents/issue/organization/upload/{issueRequestId} | Upload a document for issuance request of organization.
*SupportedIdentifiersApi* | [**GetAllSupportedIdentifiers**](docs/SupportedIdentifiersApi.md#getallsupportedidentifiers) | **GET** /v1/supported-identifiers/{countryIso2Code} | Get all supported identifiers by country.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Models.Activity](docs/Activity.md)
 - [Models.ApprovedConsentRequest](docs/ApprovedConsentRequest.md)
 - [Models.BankAccountType](docs/BankAccountType.md)
 - [Models.CollectibleTypes](docs/CollectibleTypes.md)
 - [Models.ConsentTemplateTypes](docs/ConsentTemplateTypes.md)
 - [Models.CreateDataProcessingAgreementRequestModel](docs/CreateDataProcessingAgreementRequestModel.md)
 - [Models.CreateIndividualDataConsentRequest](docs/CreateIndividualDataConsentRequest.md)
 - [Models.CreateOrganizationDataConsentRequest](docs/CreateOrganizationDataConsentRequest.md)
 - [Models.DataConsentDetailsDto](docs/DataConsentDetailsDto.md)
 - [Models.DataConsentDocumentsDto](docs/DataConsentDocumentsDto.md)
 - [Models.DataConsentFinancialsDto](docs/DataConsentFinancialsDto.md)
 - [Models.DataConsentIdentifier](docs/DataConsentIdentifier.md)
 - [Models.DataConsentRequestedDocument](docs/DataConsentRequestedDocument.md)
 - [Models.DataConsentRequestedFinancialAccount](docs/DataConsentRequestedFinancialAccount.md)
 - [Models.DataConsentRequesterDto](docs/DataConsentRequesterDto.md)
 - [Models.DataConsentStatus](docs/DataConsentStatus.md)
 - [Models.DataProcessingAgreementDto](docs/DataProcessingAgreementDto.md)
 - [Models.DataProcessingAgreementDtoPaginatedList](docs/DataProcessingAgreementDtoPaginatedList.md)
 - [Models.DataProtectionOfficer](docs/DataProtectionOfficer.md)
 - [Models.DataProvider](docs/DataProvider.md)
 - [Models.DataProviderPaginatedList](docs/DataProviderPaginatedList.md)
 - [Models.DigitalSignature](docs/DigitalSignature.md)
 - [Models.Document](docs/Document.md)
 - [Models.DocumentCategoryType](docs/DocumentCategoryType.md)
 - [Models.DocumentIssueRequest](docs/DocumentIssueRequest.md)
 - [Models.DocumentIssueRequestDetails](docs/DocumentIssueRequestDetails.md)
 - [Models.DocumentReceiver](docs/DocumentReceiver.md)
 - [Models.DocumentSubCategoryType](docs/DocumentSubCategoryType.md)
 - [Models.DocumentType](docs/DocumentType.md)
 - [Models.DocumentTypePaginatedList](docs/DocumentTypePaginatedList.md)
 - [Models.DocumentsRequired](docs/DocumentsRequired.md)
 - [Models.FetchTypes](docs/FetchTypes.md)
 - [Models.FileType](docs/FileType.md)
 - [Models.Financial](docs/Financial.md)
 - [Models.FinancialAccount](docs/FinancialAccount.md)
 - [Models.FinancialAccountDetailsRequired](docs/FinancialAccountDetailsRequired.md)
 - [Models.FinancialAccounts](docs/FinancialAccounts.md)
 - [Models.GetConsentTemplateDetailsDto](docs/GetConsentTemplateDetailsDto.md)
 - [Models.IdentificationStrategy](docs/IdentificationStrategy.md)
 - [Models.Identifier](docs/Identifier.md)
 - [Models.IdentifierStringKeyValuePair](docs/IdentifierStringKeyValuePair.md)
 - [Models.IdentitySupportedFields](docs/IdentitySupportedFields.md)
 - [Models.IndividualDataConsentRequestResponse](docs/IndividualDataConsentRequestResponse.md)
 - [Models.IssuedDocument](docs/IssuedDocument.md)
 - [Models.IssuedDocumentPaginatedList](docs/IssuedDocumentPaginatedList.md)
 - [Models.Life](docs/Life.md)
 - [Models.OrganizationDataConsentInfoDto](docs/OrganizationDataConsentInfoDto.md)
 - [Models.OrganizationDataConsentInfoDtoPaginatedList](docs/OrganizationDataConsentInfoDtoPaginatedList.md)
 - [Models.OrganizationDataConsentRequestResponse](docs/OrganizationDataConsentRequestResponse.md)
 - [Models.OrganizationDocumentDetailsDto](docs/OrganizationDocumentDetailsDto.md)
 - [Models.OrganizationDocumentDownloadDto](docs/OrganizationDocumentDownloadDto.md)
 - [Models.OrganizationFinancialAccountDto](docs/OrganizationFinancialAccountDto.md)
 - [Models.OrganizationFinancialTransactionsDto](docs/OrganizationFinancialTransactionsDto.md)
 - [Models.OrganizationFinancialTransactionsDtoPaginatedList](docs/OrganizationFinancialTransactionsDtoPaginatedList.md)
 - [Models.ProblemDetails](docs/ProblemDetails.md)
 - [Models.PushUriRequest](docs/PushUriRequest.md)
 - [Models.PushUriResponse](docs/PushUriResponse.md)
 - [Models.Receiver](docs/Receiver.md)
 - [Models.ReceiverType](docs/ReceiverType.md)
 - [Models.SharedWith](docs/SharedWith.md)
 - [Models.StringStringKeyValuePair](docs/StringStringKeyValuePair.md)
 - [Models.SupportedEntityType](docs/SupportedEntityType.md)
 - [Models.SupportedIdentifier](docs/SupportedIdentifier.md)
 - [Models.SupportedIdentifiersByCountry](docs/SupportedIdentifiersByCountry.md)
 - [Models.UpdateDataProcessingAgreementRequestModel](docs/UpdateDataProcessingAgreementRequestModel.md)
 - [Models.UriDetails](docs/UriDetails.md)
 - [Models.UserAccountFinancialTransactionsDto](docs/UserAccountFinancialTransactionsDto.md)
 - [Models.UserAccountFinancialTransactionsDtoPaginatedList](docs/UserAccountFinancialTransactionsDtoPaginatedList.md)
 - [Models.UserDataConsentInfoDto](docs/UserDataConsentInfoDto.md)
 - [Models.UserDataConsentInfoDtoPaginatedList](docs/UserDataConsentInfoDtoPaginatedList.md)
 - [Models.UserDocumentDetailsDto](docs/UserDocumentDetailsDto.md)
 - [Models.UserDocumentDownloadDto](docs/UserDocumentDownloadDto.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: https://accounts.mydatamyconsent.com/connect/authorize
- **Scopes**: 
  - developer: Developer API

