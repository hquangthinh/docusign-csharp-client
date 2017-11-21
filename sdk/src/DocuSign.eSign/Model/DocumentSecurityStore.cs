/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// DocumentSecurityStore
    /// </summary>
    [DataContract]
    public partial class DocumentSecurityStore :  IEquatable<DocumentSecurityStore>, IValidatableObject
    {
        public DocumentSecurityStore()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSecurityStore" /> class.
        /// </summary>
        /// <param name="Certificates">.</param>
        /// <param name="Crls">.</param>
        /// <param name="Ocsps">.</param>
        public DocumentSecurityStore(List<string> Certificates = default(List<string>), List<string> Crls = default(List<string>), List<string> Ocsps = default(List<string>))
        {
            this.Certificates = Certificates;
            this.Crls = Crls;
            this.Ocsps = Ocsps;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="certificates", EmitDefaultValue=false)]
        public List<string> Certificates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="crls", EmitDefaultValue=false)]
        public List<string> Crls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ocsps", EmitDefaultValue=false)]
        public List<string> Ocsps { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentSecurityStore {\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
            sb.Append("  Crls: ").Append(Crls).Append("\n");
            sb.Append("  Ocsps: ").Append(Ocsps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DocumentSecurityStore);
        }

        /// <summary>
        /// Returns true if DocumentSecurityStore instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentSecurityStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentSecurityStore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Certificates == other.Certificates ||
                    this.Certificates != null &&
                    this.Certificates.SequenceEqual(other.Certificates)
                ) && 
                (
                    this.Crls == other.Crls ||
                    this.Crls != null &&
                    this.Crls.SequenceEqual(other.Crls)
                ) && 
                (
                    this.Ocsps == other.Ocsps ||
                    this.Ocsps != null &&
                    this.Ocsps.SequenceEqual(other.Ocsps)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Certificates != null)
                    hash = hash * 59 + this.Certificates.GetHashCode();
                if (this.Crls != null)
                    hash = hash * 59 + this.Crls.GetHashCode();
                if (this.Ocsps != null)
                    hash = hash * 59 + this.Ocsps.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}