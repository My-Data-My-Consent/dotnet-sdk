/*
 * My Data My Consent - Developer API
 *
 * Unleashing the power of data consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@mydatamyconsent.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using MyDataMyConsent.Client;
using MyDataMyConsent.Api;
// uncomment below to import models
//using MyDataMyConsent.Models;

namespace MyDataMyConsent.Test.Api
{
    /// <summary>
    ///  Class for testing DataConsentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataConsentsApiTests : IDisposable
    {
        private DataConsentsApi instance;

        public DataConsentsApiTests()
        {
            instance = new DataConsentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataConsentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataConsentsApi
            //Assert.IsType<DataConsentsApi>(instance);
        }

        /// <summary>
        /// Test DownloadConsentedDocumentAnalysis
        /// </summary>
        [Fact]
        public void DownloadConsentedDocumentAnalysisTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //string documentId = null;
            //instance.DownloadConsentedDocumentAnalysis(consentId, documentId);
        }

        /// <summary>
        /// Test DownloadIndividualConsentedDocumentById
        /// </summary>
        [Fact]
        public void DownloadIndividualConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //string documentId = null;
            //instance.DownloadIndividualConsentedDocumentById(consentId, documentId);
        }

        /// <summary>
        /// Test DownloadOrganizationConsentedDocumentById
        /// </summary>
        [Fact]
        public void DownloadOrganizationConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //string documentId = null;
            //instance.DownloadOrganizationConsentedDocumentById(consentId, documentId);
        }

        /// <summary>
        /// Test GetAllConsentedFinancialAccounts
        /// </summary>
        [Fact]
        public void GetAllConsentedFinancialAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetAllConsentedFinancialAccounts(consentId);
            //Assert.IsType<DataConsentFinancialsDto>(response);
        }

        /// <summary>
        /// Test GetConsentFinancialAccounts
        /// </summary>
        [Fact]
        public void GetConsentFinancialAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetConsentFinancialAccounts(consentId);
            //Assert.IsType<DataConsentFinancialsDto>(response);
        }

        /// <summary>
        /// Test GetConsentedAccountById
        /// </summary>
        [Fact]
        public void GetConsentedAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //var response = instance.GetConsentedAccountById(consentId, accountId);
            //Assert.IsType<FinancialAccount>(response);
        }

        /// <summary>
        /// Test GetConsentedDocumentById
        /// </summary>
        [Fact]
        public void GetConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //string documentId = null;
            //var response = instance.GetConsentedDocumentById(consentId, documentId);
            //Assert.IsType<DataConsentDocument>(response);
        }

        /// <summary>
        /// Test GetConsentedFinancialAccount
        /// </summary>
        [Fact]
        public void GetConsentedFinancialAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //var response = instance.GetConsentedFinancialAccount(consentId, accountId);
            //Assert.IsType<OrganizationFinancialAccountDto>(response);
        }

        /// <summary>
        /// Test GetConsentedFinancialAccountInsights
        /// </summary>
        [Fact]
        public void GetConsentedFinancialAccountInsightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //string accountId = null;
            //instance.GetConsentedFinancialAccountInsights(consentId, accountId);
        }

        /// <summary>
        /// Test GetConsentedFinancialAccountTransactions
        /// </summary>
        [Fact]
        public void GetConsentedFinancialAccountTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //string? filters = null;
            //DateTime? fromDateTimeUtc = null;
            //DateTime? toDateTimeUtc = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetConsentedFinancialAccountTransactions(consentId, accountId, filters, fromDateTimeUtc, toDateTimeUtc, pageNo, pageSize);
            //Assert.IsType<UserAccountFinancialTransactionsDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test GetConsents
        /// </summary>
        [Fact]
        public void GetConsentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataConsentStatus? status = null;
            //DateTime? fromDateTime = null;
            //DateTime? toDateTime = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetConsents(status, fromDateTime, toDateTime, pageNo, pageSize);
            //Assert.IsType<DataConsentDetailsPaginatedList>(response);
        }

        /// <summary>
        /// Test GetIndividualConsentedDocuments
        /// </summary>
        [Fact]
        public void GetIndividualConsentedDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetIndividualConsentedDocuments(consentId);
            //Assert.IsType<List<DataConsentDocument>>(response);
        }

        /// <summary>
        /// Test GetIndividualDataConsentById
        /// </summary>
        [Fact]
        public void GetIndividualDataConsentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetIndividualDataConsentById(consentId);
            //Assert.IsType<DataConsent>(response);
        }

        /// <summary>
        /// Test GetOrgConsentedAccountTransactions
        /// </summary>
        [Fact]
        public void GetOrgConsentedAccountTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //string? filters = null;
            //DateTime? fromDateTimeUtc = null;
            //DateTime? toDateTimeUtc = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetOrgConsentedAccountTransactions(consentId, accountId, filters, fromDateTimeUtc, toDateTimeUtc, pageNo, pageSize);
            //Assert.IsType<OrganizationFinancialTransactionsDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test GetOrganizationConsentedDocumentById
        /// </summary>
        [Fact]
        public void GetOrganizationConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //string documentId = null;
            //var response = instance.GetOrganizationConsentedDocumentById(consentId, documentId);
            //Assert.IsType<DataConsentDocument>(response);
        }

        /// <summary>
        /// Test GetOrganizationConsentedDocuments
        /// </summary>
        [Fact]
        public void GetOrganizationConsentedDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetOrganizationConsentedDocuments(consentId);
            //Assert.IsType<List<DataConsentDocument>>(response);
        }

        /// <summary>
        /// Test GetOrganizationDataConsentById
        /// </summary>
        [Fact]
        public void GetOrganizationDataConsentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetOrganizationDataConsentById(consentId);
            //Assert.IsType<DataConsent>(response);
        }

        /// <summary>
        /// Test GetOrganizationDataConsents
        /// </summary>
        [Fact]
        public void GetOrganizationDataConsentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataConsentStatus? status = null;
            //DateTime? fromDateTime = null;
            //DateTime? toDateTime = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetOrganizationDataConsents(status, fromDateTime, toDateTime, pageNo, pageSize);
            //Assert.IsType<DataConsentDetailsPaginatedList>(response);
        }
    }
}
