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
    /// Data Consent document issuer details.
    /// </summary>
    [DataContract(Name = "DataConsentDocumentIssuer")]
    public partial class DataConsentDocumentIssuer : IEquatable<DataConsentDocumentIssuer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentDocumentIssuer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataConsentDocumentIssuer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentDocumentIssuer" /> class.
        /// </summary>
        /// <param name="id">Document issuer id. (required).</param>
        /// <param name="name">Document issuer name. (required).</param>
        public DataConsentDocumentIssuer(Guid id = default(Guid), string name = default(string))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DataConsentDocumentIssuer and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Document issuer id.
        /// </summary>
        /// <value>Document issuer id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Document issuer name.
        /// </summary>
        /// <value>Document issuer name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataConsentDocumentIssuer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as DataConsentDocumentIssuer);
        }

        /// <summary>
        /// Returns true if DataConsentDocumentIssuer instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsentDocumentIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsentDocumentIssuer input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
