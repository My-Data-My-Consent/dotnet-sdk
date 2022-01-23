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
using OpenAPIDateConverter = MyDataMyConsent.Client.OpenAPIDateConverter;

namespace MyDataMyConsent.Models
{
    /// <summary>
    /// Document
    /// </summary>
    [DataContract(Name = "Document")]
    public partial class Document : IEquatable<Document>
    {

        /// <summary>
        /// Gets or Sets Requirement
        /// </summary>
        [DataMember(Name = "requirement", EmitDefaultValue = false)]
        public DocumentsRequired? Requirement { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="documentField">documentField.</param>
        /// <param name="customKey">customKey.</param>
        /// <param name="drn">drn.</param>
        /// <param name="requirement">requirement.</param>
        public Document(string documentField = default(string), string customKey = default(string), List<string> drn = default(List<string>), DocumentsRequired? requirement = default(DocumentsRequired?))
        {
            this.DocumentField = documentField;
            this.CustomKey = customKey;
            this.Drn = drn;
            this.Requirement = requirement;
        }

        /// <summary>
        /// Gets or Sets DocumentField
        /// </summary>
        [DataMember(Name = "documentField", EmitDefaultValue = true)]
        public string DocumentField { get; set; }

        /// <summary>
        /// Gets or Sets CustomKey
        /// </summary>
        [DataMember(Name = "customKey", EmitDefaultValue = true)]
        public string CustomKey { get; set; }

        /// <summary>
        /// Gets or Sets Drn
        /// </summary>
        [DataMember(Name = "drn", EmitDefaultValue = true)]
        public List<string> Drn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  DocumentField: ").Append(DocumentField).Append("\n");
            sb.Append("  CustomKey: ").Append(CustomKey).Append("\n");
            sb.Append("  Drn: ").Append(Drn).Append("\n");
            sb.Append("  Requirement: ").Append(Requirement).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentField == input.DocumentField ||
                    (this.DocumentField != null &&
                    this.DocumentField.Equals(input.DocumentField))
                ) && 
                (
                    this.CustomKey == input.CustomKey ||
                    (this.CustomKey != null &&
                    this.CustomKey.Equals(input.CustomKey))
                ) && 
                (
                    this.Drn == input.Drn ||
                    this.Drn != null &&
                    input.Drn != null &&
                    this.Drn.SequenceEqual(input.Drn)
                ) && 
                (
                    this.Requirement == input.Requirement ||
                    this.Requirement.Equals(input.Requirement)
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
                if (this.DocumentField != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentField.GetHashCode();
                }
                if (this.CustomKey != null)
                {
                    hashCode = (hashCode * 59) + this.CustomKey.GetHashCode();
                }
                if (this.Drn != null)
                {
                    hashCode = (hashCode * 59) + this.Drn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Requirement.GetHashCode();
                return hashCode;
            }
        }

    }

}
