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
    /// IndividualDataConsentRequestResponse
    /// </summary>
    [DataContract(Name = "IndividualDataConsentRequestResponse")]
    public partial class IndividualDataConsentRequestResponse : IEquatable<IndividualDataConsentRequestResponse>
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DataConsentStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualDataConsentRequestResponse" /> class.
        /// </summary>
        /// <param name="id">Consent request id.</param>
        /// <param name="templateId">Consent request template id.</param>
        /// <param name="requestedAtUtc">Requested date time in utc zone.</param>
        /// <param name="requestExpiresAtUtc">Request expires date time in utc zone.</param>
        /// <param name="status">status.</param>
        /// <param name="transactionId">Requested transaction id.</param>
        public IndividualDataConsentRequestResponse(Guid id = default(Guid), Guid templateId = default(Guid), DateTime requestedAtUtc = default(DateTime), DateTime requestExpiresAtUtc = default(DateTime), DataConsentStatus? status = default(DataConsentStatus?), string? transactionId = default(string?))
        {
            this.Id = id;
            this.TemplateId = templateId;
            this.RequestedAtUtc = requestedAtUtc;
            this.RequestExpiresAtUtc = requestExpiresAtUtc;
            this.Status = status;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Consent request id
        /// </summary>
        /// <value>Consent request id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Consent request template id
        /// </summary>
        /// <value>Consent request template id</value>
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public Guid TemplateId { get; set; }

        /// <summary>
        /// Requested date time in utc zone
        /// </summary>
        /// <value>Requested date time in utc zone</value>
        [DataMember(Name = "requestedAtUtc", EmitDefaultValue = false)]
        public DateTime RequestedAtUtc { get; set; }

        /// <summary>
        /// Request expires date time in utc zone
        /// </summary>
        /// <value>Request expires date time in utc zone</value>
        [DataMember(Name = "requestExpiresAtUtc", EmitDefaultValue = false)]
        public DateTime RequestExpiresAtUtc { get; set; }

        /// <summary>
        /// Requested transaction id
        /// </summary>
        /// <value>Requested transaction id</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = true)]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndividualDataConsentRequestResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  RequestedAtUtc: ").Append(RequestedAtUtc).Append("\n");
            sb.Append("  RequestExpiresAtUtc: ").Append(RequestExpiresAtUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as IndividualDataConsentRequestResponse);
        }

        /// <summary>
        /// Returns true if IndividualDataConsentRequestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IndividualDataConsentRequestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndividualDataConsentRequestResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.RequestedAtUtc == input.RequestedAtUtc ||
                    (this.RequestedAtUtc != null &&
                    this.RequestedAtUtc.Equals(input.RequestedAtUtc))
                ) && 
                (
                    this.RequestExpiresAtUtc == input.RequestExpiresAtUtc ||
                    (this.RequestExpiresAtUtc != null &&
                    this.RequestExpiresAtUtc.Equals(input.RequestExpiresAtUtc))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.RequestedAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedAtUtc.GetHashCode();
                }
                if (this.RequestExpiresAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.RequestExpiresAtUtc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
