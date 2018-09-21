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
    /// UserAccountManagementGranularInformation
    /// </summary>
    [DataContract]
    public partial class UserAccountManagementGranularInformation :  IEquatable<UserAccountManagementGranularInformation>, IValidatableObject
    {
        public UserAccountManagementGranularInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountManagementGranularInformation" /> class.
        /// </summary>
        /// <param name="CanManageAccountSecuritySettings">.</param>
        /// <param name="CanManageAccountSecuritySettingsMetadata">CanManageAccountSecuritySettingsMetadata.</param>
        /// <param name="CanManageAccountSettings">.</param>
        /// <param name="CanManageAccountSettingsMetadata">CanManageAccountSettingsMetadata.</param>
        /// <param name="CanManageAdmins">.</param>
        /// <param name="CanManageAdminsMetadata">CanManageAdminsMetadata.</param>
        /// <param name="CanManageGroups">.</param>
        /// <param name="CanManageGroupsMetadata">CanManageGroupsMetadata.</param>
        /// <param name="CanManageReporting">.</param>
        /// <param name="CanManageReportingMetadata">CanManageReportingMetadata.</param>
        /// <param name="CanManageSharing">.</param>
        /// <param name="CanManageSharingMetadata">CanManageSharingMetadata.</param>
        /// <param name="CanManageSigningGroups">.</param>
        /// <param name="CanManageSigningGroupsMetadata">CanManageSigningGroupsMetadata.</param>
        /// <param name="CanManageUsers">.</param>
        /// <param name="CanManageUsersMetadata">CanManageUsersMetadata.</param>
        public UserAccountManagementGranularInformation(string CanManageAccountSecuritySettings = default(string), SettingsMetadata CanManageAccountSecuritySettingsMetadata = default(SettingsMetadata), string CanManageAccountSettings = default(string), SettingsMetadata CanManageAccountSettingsMetadata = default(SettingsMetadata), string CanManageAdmins = default(string), SettingsMetadata CanManageAdminsMetadata = default(SettingsMetadata), string CanManageGroups = default(string), SettingsMetadata CanManageGroupsMetadata = default(SettingsMetadata), string CanManageReporting = default(string), SettingsMetadata CanManageReportingMetadata = default(SettingsMetadata), string CanManageSharing = default(string), SettingsMetadata CanManageSharingMetadata = default(SettingsMetadata), string CanManageSigningGroups = default(string), SettingsMetadata CanManageSigningGroupsMetadata = default(SettingsMetadata), string CanManageUsers = default(string), SettingsMetadata CanManageUsersMetadata = default(SettingsMetadata))
        {
            this.CanManageAccountSecuritySettings = CanManageAccountSecuritySettings;
            this.CanManageAccountSecuritySettingsMetadata = CanManageAccountSecuritySettingsMetadata;
            this.CanManageAccountSettings = CanManageAccountSettings;
            this.CanManageAccountSettingsMetadata = CanManageAccountSettingsMetadata;
            this.CanManageAdmins = CanManageAdmins;
            this.CanManageAdminsMetadata = CanManageAdminsMetadata;
            this.CanManageGroups = CanManageGroups;
            this.CanManageGroupsMetadata = CanManageGroupsMetadata;
            this.CanManageReporting = CanManageReporting;
            this.CanManageReportingMetadata = CanManageReportingMetadata;
            this.CanManageSharing = CanManageSharing;
            this.CanManageSharingMetadata = CanManageSharingMetadata;
            this.CanManageSigningGroups = CanManageSigningGroups;
            this.CanManageSigningGroupsMetadata = CanManageSigningGroupsMetadata;
            this.CanManageUsers = CanManageUsers;
            this.CanManageUsersMetadata = CanManageUsersMetadata;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageAccountSecuritySettings", EmitDefaultValue=false)]
        public string CanManageAccountSecuritySettings { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAccountSecuritySettingsMetadata
        /// </summary>
        [DataMember(Name="canManageAccountSecuritySettingsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageAccountSecuritySettingsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageAccountSettings", EmitDefaultValue=false)]
        public string CanManageAccountSettings { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAccountSettingsMetadata
        /// </summary>
        [DataMember(Name="canManageAccountSettingsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageAccountSettingsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageAdmins", EmitDefaultValue=false)]
        public string CanManageAdmins { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAdminsMetadata
        /// </summary>
        [DataMember(Name="canManageAdminsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageAdminsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageGroups", EmitDefaultValue=false)]
        public string CanManageGroups { get; set; }
        /// <summary>
        /// Gets or Sets CanManageGroupsMetadata
        /// </summary>
        [DataMember(Name="canManageGroupsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageGroupsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageReporting", EmitDefaultValue=false)]
        public string CanManageReporting { get; set; }
        /// <summary>
        /// Gets or Sets CanManageReportingMetadata
        /// </summary>
        [DataMember(Name="canManageReportingMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageReportingMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageSharing", EmitDefaultValue=false)]
        public string CanManageSharing { get; set; }
        /// <summary>
        /// Gets or Sets CanManageSharingMetadata
        /// </summary>
        [DataMember(Name="canManageSharingMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageSharingMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageSigningGroups", EmitDefaultValue=false)]
        public string CanManageSigningGroups { get; set; }
        /// <summary>
        /// Gets or Sets CanManageSigningGroupsMetadata
        /// </summary>
        [DataMember(Name="canManageSigningGroupsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageSigningGroupsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageUsers", EmitDefaultValue=false)]
        public string CanManageUsers { get; set; }
        /// <summary>
        /// Gets or Sets CanManageUsersMetadata
        /// </summary>
        [DataMember(Name="canManageUsersMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageUsersMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountManagementGranularInformation {\n");
            sb.Append("  CanManageAccountSecuritySettings: ").Append(CanManageAccountSecuritySettings).Append("\n");
            sb.Append("  CanManageAccountSecuritySettingsMetadata: ").Append(CanManageAccountSecuritySettingsMetadata).Append("\n");
            sb.Append("  CanManageAccountSettings: ").Append(CanManageAccountSettings).Append("\n");
            sb.Append("  CanManageAccountSettingsMetadata: ").Append(CanManageAccountSettingsMetadata).Append("\n");
            sb.Append("  CanManageAdmins: ").Append(CanManageAdmins).Append("\n");
            sb.Append("  CanManageAdminsMetadata: ").Append(CanManageAdminsMetadata).Append("\n");
            sb.Append("  CanManageGroups: ").Append(CanManageGroups).Append("\n");
            sb.Append("  CanManageGroupsMetadata: ").Append(CanManageGroupsMetadata).Append("\n");
            sb.Append("  CanManageReporting: ").Append(CanManageReporting).Append("\n");
            sb.Append("  CanManageReportingMetadata: ").Append(CanManageReportingMetadata).Append("\n");
            sb.Append("  CanManageSharing: ").Append(CanManageSharing).Append("\n");
            sb.Append("  CanManageSharingMetadata: ").Append(CanManageSharingMetadata).Append("\n");
            sb.Append("  CanManageSigningGroups: ").Append(CanManageSigningGroups).Append("\n");
            sb.Append("  CanManageSigningGroupsMetadata: ").Append(CanManageSigningGroupsMetadata).Append("\n");
            sb.Append("  CanManageUsers: ").Append(CanManageUsers).Append("\n");
            sb.Append("  CanManageUsersMetadata: ").Append(CanManageUsersMetadata).Append("\n");
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
            return this.Equals(obj as UserAccountManagementGranularInformation);
        }

        /// <summary>
        /// Returns true if UserAccountManagementGranularInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccountManagementGranularInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountManagementGranularInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CanManageAccountSecuritySettings == other.CanManageAccountSecuritySettings ||
                    this.CanManageAccountSecuritySettings != null &&
                    this.CanManageAccountSecuritySettings.Equals(other.CanManageAccountSecuritySettings)
                ) && 
                (
                    this.CanManageAccountSecuritySettingsMetadata == other.CanManageAccountSecuritySettingsMetadata ||
                    this.CanManageAccountSecuritySettingsMetadata != null &&
                    this.CanManageAccountSecuritySettingsMetadata.Equals(other.CanManageAccountSecuritySettingsMetadata)
                ) && 
                (
                    this.CanManageAccountSettings == other.CanManageAccountSettings ||
                    this.CanManageAccountSettings != null &&
                    this.CanManageAccountSettings.Equals(other.CanManageAccountSettings)
                ) && 
                (
                    this.CanManageAccountSettingsMetadata == other.CanManageAccountSettingsMetadata ||
                    this.CanManageAccountSettingsMetadata != null &&
                    this.CanManageAccountSettingsMetadata.Equals(other.CanManageAccountSettingsMetadata)
                ) && 
                (
                    this.CanManageAdmins == other.CanManageAdmins ||
                    this.CanManageAdmins != null &&
                    this.CanManageAdmins.Equals(other.CanManageAdmins)
                ) && 
                (
                    this.CanManageAdminsMetadata == other.CanManageAdminsMetadata ||
                    this.CanManageAdminsMetadata != null &&
                    this.CanManageAdminsMetadata.Equals(other.CanManageAdminsMetadata)
                ) && 
                (
                    this.CanManageGroups == other.CanManageGroups ||
                    this.CanManageGroups != null &&
                    this.CanManageGroups.Equals(other.CanManageGroups)
                ) && 
                (
                    this.CanManageGroupsMetadata == other.CanManageGroupsMetadata ||
                    this.CanManageGroupsMetadata != null &&
                    this.CanManageGroupsMetadata.Equals(other.CanManageGroupsMetadata)
                ) && 
                (
                    this.CanManageReporting == other.CanManageReporting ||
                    this.CanManageReporting != null &&
                    this.CanManageReporting.Equals(other.CanManageReporting)
                ) && 
                (
                    this.CanManageReportingMetadata == other.CanManageReportingMetadata ||
                    this.CanManageReportingMetadata != null &&
                    this.CanManageReportingMetadata.Equals(other.CanManageReportingMetadata)
                ) && 
                (
                    this.CanManageSharing == other.CanManageSharing ||
                    this.CanManageSharing != null &&
                    this.CanManageSharing.Equals(other.CanManageSharing)
                ) && 
                (
                    this.CanManageSharingMetadata == other.CanManageSharingMetadata ||
                    this.CanManageSharingMetadata != null &&
                    this.CanManageSharingMetadata.Equals(other.CanManageSharingMetadata)
                ) && 
                (
                    this.CanManageSigningGroups == other.CanManageSigningGroups ||
                    this.CanManageSigningGroups != null &&
                    this.CanManageSigningGroups.Equals(other.CanManageSigningGroups)
                ) && 
                (
                    this.CanManageSigningGroupsMetadata == other.CanManageSigningGroupsMetadata ||
                    this.CanManageSigningGroupsMetadata != null &&
                    this.CanManageSigningGroupsMetadata.Equals(other.CanManageSigningGroupsMetadata)
                ) && 
                (
                    this.CanManageUsers == other.CanManageUsers ||
                    this.CanManageUsers != null &&
                    this.CanManageUsers.Equals(other.CanManageUsers)
                ) && 
                (
                    this.CanManageUsersMetadata == other.CanManageUsersMetadata ||
                    this.CanManageUsersMetadata != null &&
                    this.CanManageUsersMetadata.Equals(other.CanManageUsersMetadata)
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
                if (this.CanManageAccountSecuritySettings != null)
                    hash = hash * 59 + this.CanManageAccountSecuritySettings.GetHashCode();
                if (this.CanManageAccountSecuritySettingsMetadata != null)
                    hash = hash * 59 + this.CanManageAccountSecuritySettingsMetadata.GetHashCode();
                if (this.CanManageAccountSettings != null)
                    hash = hash * 59 + this.CanManageAccountSettings.GetHashCode();
                if (this.CanManageAccountSettingsMetadata != null)
                    hash = hash * 59 + this.CanManageAccountSettingsMetadata.GetHashCode();
                if (this.CanManageAdmins != null)
                    hash = hash * 59 + this.CanManageAdmins.GetHashCode();
                if (this.CanManageAdminsMetadata != null)
                    hash = hash * 59 + this.CanManageAdminsMetadata.GetHashCode();
                if (this.CanManageGroups != null)
                    hash = hash * 59 + this.CanManageGroups.GetHashCode();
                if (this.CanManageGroupsMetadata != null)
                    hash = hash * 59 + this.CanManageGroupsMetadata.GetHashCode();
                if (this.CanManageReporting != null)
                    hash = hash * 59 + this.CanManageReporting.GetHashCode();
                if (this.CanManageReportingMetadata != null)
                    hash = hash * 59 + this.CanManageReportingMetadata.GetHashCode();
                if (this.CanManageSharing != null)
                    hash = hash * 59 + this.CanManageSharing.GetHashCode();
                if (this.CanManageSharingMetadata != null)
                    hash = hash * 59 + this.CanManageSharingMetadata.GetHashCode();
                if (this.CanManageSigningGroups != null)
                    hash = hash * 59 + this.CanManageSigningGroups.GetHashCode();
                if (this.CanManageSigningGroupsMetadata != null)
                    hash = hash * 59 + this.CanManageSigningGroupsMetadata.GetHashCode();
                if (this.CanManageUsers != null)
                    hash = hash * 59 + this.CanManageUsers.GetHashCode();
                if (this.CanManageUsersMetadata != null)
                    hash = hash * 59 + this.CanManageUsersMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
