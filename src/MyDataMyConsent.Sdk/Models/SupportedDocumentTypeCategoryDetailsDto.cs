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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = MyDataMyConsent.Sdk.Client.OpenAPIDateConverter;

namespace MyDataMyConsent.Sdk.Models
{
    /// <summary>
    /// SupportedDocumentTypeCategoryDetailsDto
    /// </summary>
    [DataContract(Name = "SupportedDocumentTypeCategoryDetailsDto")]
    public partial class SupportedDocumentTypeCategoryDetailsDto : IEquatable<SupportedDocumentTypeCategoryDetailsDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDocumentTypeCategoryDetailsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportedDocumentTypeCategoryDetailsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDocumentTypeCategoryDetailsDto" /> class.
        /// </summary>
        /// <param name="documentTypeCategoryId">documentTypeCategoryId (required).</param>
        /// <param name="documentTypeCategoryName">documentTypeCategoryName (required).</param>
        /// <param name="supportedDocuments">supportedDocuments (required).</param>
        /// <param name="supportedDocumentProviderDetails">supportedDocumentProviderDetails (required).</param>
        public SupportedDocumentTypeCategoryDetailsDto(Guid documentTypeCategoryId = default(Guid), string documentTypeCategoryName = default(string), List<SupportedDocumentDetailsDto> supportedDocuments = default(List<SupportedDocumentDetailsDto>), List<SupportedDocumentProviderDetailsDto> supportedDocumentProviderDetails = default(List<SupportedDocumentProviderDetailsDto>))
        {
            this.DocumentTypeCategoryId = documentTypeCategoryId;
            this.DocumentTypeCategoryName = documentTypeCategoryName;
            // to ensure "supportedDocuments" is required (not null)
            if (supportedDocuments == null) {
                throw new ArgumentNullException("supportedDocuments is a required property for SupportedDocumentTypeCategoryDetailsDto and cannot be null");
            }
            this.SupportedDocuments = supportedDocuments;
            // to ensure "supportedDocumentProviderDetails" is required (not null)
            if (supportedDocumentProviderDetails == null) {
                throw new ArgumentNullException("supportedDocumentProviderDetails is a required property for SupportedDocumentTypeCategoryDetailsDto and cannot be null");
            }
            this.SupportedDocumentProviderDetails = supportedDocumentProviderDetails;
        }

        /// <summary>
        /// Gets or Sets DocumentTypeCategoryId
        /// </summary>
        [DataMember(Name = "documentTypeCategoryId", IsRequired = true, EmitDefaultValue = false)]
        public Guid DocumentTypeCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTypeCategoryName
        /// </summary>
        [DataMember(Name = "documentTypeCategoryName", IsRequired = true, EmitDefaultValue = false)]
        public string DocumentTypeCategoryName { get; set; }

        /// <summary>
        /// Gets or Sets SupportedDocuments
        /// </summary>
        [DataMember(Name = "supportedDocuments", IsRequired = true, EmitDefaultValue = false)]
        public List<SupportedDocumentDetailsDto> SupportedDocuments { get; set; }

        /// <summary>
        /// Gets or Sets SupportedDocumentProviderDetails
        /// </summary>
        [DataMember(Name = "supportedDocumentProviderDetails", IsRequired = true, EmitDefaultValue = false)]
        public List<SupportedDocumentProviderDetailsDto> SupportedDocumentProviderDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedDocumentTypeCategoryDetailsDto {\n");
            sb.Append("  DocumentTypeCategoryId: ").Append(DocumentTypeCategoryId).Append("\n");
            sb.Append("  DocumentTypeCategoryName: ").Append(DocumentTypeCategoryName).Append("\n");
            sb.Append("  SupportedDocuments: ").Append(SupportedDocuments).Append("\n");
            sb.Append("  SupportedDocumentProviderDetails: ").Append(SupportedDocumentProviderDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportedDocumentTypeCategoryDetailsDto);
        }

        /// <summary>
        /// Returns true if SupportedDocumentTypeCategoryDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedDocumentTypeCategoryDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedDocumentTypeCategoryDetailsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentTypeCategoryId == input.DocumentTypeCategoryId ||
                    (this.DocumentTypeCategoryId != null &&
                    this.DocumentTypeCategoryId.Equals(input.DocumentTypeCategoryId))
                ) && 
                (
                    this.DocumentTypeCategoryName == input.DocumentTypeCategoryName ||
                    (this.DocumentTypeCategoryName != null &&
                    this.DocumentTypeCategoryName.Equals(input.DocumentTypeCategoryName))
                ) && 
                (
                    this.SupportedDocuments == input.SupportedDocuments ||
                    this.SupportedDocuments != null &&
                    input.SupportedDocuments != null &&
                    this.SupportedDocuments.SequenceEqual(input.SupportedDocuments)
                ) && 
                (
                    this.SupportedDocumentProviderDetails == input.SupportedDocumentProviderDetails ||
                    this.SupportedDocumentProviderDetails != null &&
                    input.SupportedDocumentProviderDetails != null &&
                    this.SupportedDocumentProviderDetails.SequenceEqual(input.SupportedDocumentProviderDetails)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DocumentTypeCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentTypeCategoryId.GetHashCode();
                }
                if (this.DocumentTypeCategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentTypeCategoryName.GetHashCode();
                }
                if (this.SupportedDocuments != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedDocuments.GetHashCode();
                }
                if (this.SupportedDocumentProviderDetails != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedDocumentProviderDetails.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
