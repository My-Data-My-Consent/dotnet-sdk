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
    /// UriDetails
    /// </summary>
    [DataContract(Name = "UriDetails")]
    public partial class UriDetails : IEquatable<UriDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UriDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UriDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UriDetails" /> class.
        /// </summary>
        /// <param name="aadhaar">aadhaar (required).</param>
        /// <param name="uri">uri (required).</param>
        /// <param name="docType">docType (required).</param>
        /// <param name="docName">docName (required).</param>
        /// <param name="docId">docId (required).</param>
        /// <param name="issuedOn">issuedOn (required).</param>
        /// <param name="validFrom">validFrom (required).</param>
        /// <param name="validTo">validTo.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="action">action.</param>
        public UriDetails(string aadhaar = default(string), string uri = default(string), string docType = default(string), string docName = default(string), string docId = default(string), string issuedOn = default(string), string validFrom = default(string), string? validTo = default(string?), string? timestamp = default(string?), string? action = default(string?))
        {
            this.Aadhaar = aadhaar;
            this.Uri = uri;
            this.DocType = docType;
            this.DocName = docName;
            this.DocId = docId;
            this.IssuedOn = issuedOn;
            this.ValidFrom = validFrom;
            this.ValidTo = validTo;
            this.Timestamp = timestamp;
            this.Action = action;
        }

        /// <summary>
        /// Gets or Sets Aadhaar
        /// </summary>
        [DataMember(Name = "aadhaar", IsRequired = true, EmitDefaultValue = false)]
        public string Aadhaar { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets DocType
        /// </summary>
        [DataMember(Name = "docType", IsRequired = true, EmitDefaultValue = false)]
        public string DocType { get; set; }

        /// <summary>
        /// Gets or Sets DocName
        /// </summary>
        [DataMember(Name = "docName", IsRequired = true, EmitDefaultValue = false)]
        public string DocName { get; set; }

        /// <summary>
        /// Gets or Sets DocId
        /// </summary>
        [DataMember(Name = "docId", IsRequired = true, EmitDefaultValue = false)]
        public string DocId { get; set; }

        /// <summary>
        /// Gets or Sets IssuedOn
        /// </summary>
        [DataMember(Name = "issuedOn", IsRequired = true, EmitDefaultValue = false)]
        public string IssuedOn { get; set; }

        /// <summary>
        /// Gets or Sets ValidFrom
        /// </summary>
        [DataMember(Name = "validFrom", IsRequired = true, EmitDefaultValue = false)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets ValidTo
        /// </summary>
        [DataMember(Name = "validTo", EmitDefaultValue = true)]
        public string? ValidTo { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = true)]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string? Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UriDetails {\n");
            sb.Append("  Aadhaar: ").Append(Aadhaar).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  DocType: ").Append(DocType).Append("\n");
            sb.Append("  DocName: ").Append(DocName).Append("\n");
            sb.Append("  DocId: ").Append(DocId).Append("\n");
            sb.Append("  IssuedOn: ").Append(IssuedOn).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as UriDetails);
        }

        /// <summary>
        /// Returns true if UriDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UriDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UriDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Aadhaar == input.Aadhaar ||
                    (this.Aadhaar != null &&
                    this.Aadhaar.Equals(input.Aadhaar))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.DocType == input.DocType ||
                    (this.DocType != null &&
                    this.DocType.Equals(input.DocType))
                ) && 
                (
                    this.DocName == input.DocName ||
                    (this.DocName != null &&
                    this.DocName.Equals(input.DocName))
                ) && 
                (
                    this.DocId == input.DocId ||
                    (this.DocId != null &&
                    this.DocId.Equals(input.DocId))
                ) && 
                (
                    this.IssuedOn == input.IssuedOn ||
                    (this.IssuedOn != null &&
                    this.IssuedOn.Equals(input.IssuedOn))
                ) && 
                (
                    this.ValidFrom == input.ValidFrom ||
                    (this.ValidFrom != null &&
                    this.ValidFrom.Equals(input.ValidFrom))
                ) && 
                (
                    this.ValidTo == input.ValidTo ||
                    (this.ValidTo != null &&
                    this.ValidTo.Equals(input.ValidTo))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.Aadhaar != null)
                {
                    hashCode = (hashCode * 59) + this.Aadhaar.GetHashCode();
                }
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                if (this.DocType != null)
                {
                    hashCode = (hashCode * 59) + this.DocType.GetHashCode();
                }
                if (this.DocName != null)
                {
                    hashCode = (hashCode * 59) + this.DocName.GetHashCode();
                }
                if (this.DocId != null)
                {
                    hashCode = (hashCode * 59) + this.DocId.GetHashCode();
                }
                if (this.IssuedOn != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedOn.GetHashCode();
                }
                if (this.ValidFrom != null)
                {
                    hashCode = (hashCode * 59) + this.ValidFrom.GetHashCode();
                }
                if (this.ValidTo != null)
                {
                    hashCode = (hashCode * 59) + this.ValidTo.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
