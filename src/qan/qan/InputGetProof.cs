/*
 * QAN AutoApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.2
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = qan.Client.OpenAPIDateConverter;

namespace qan.qan
{
    /// <summary>
    /// InputGetProof
    /// </summary>
    [DataContract(Name = "Input_getProof")]
    public partial class InputGetProof : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputGetProof" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputGetProof() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputGetProof" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="blockNumber">blockNumber (default to &quot;latest&quot;).</param>
        /// <param name="storageKeys">An array of storage-keys that should be proofed and included (required).</param>
        public InputGetProof(string address = default(string), string blockNumber = @"latest", List<string> storageKeys = default(List<string>))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for InputGetProof and cannot be null");
            }
            this.Address = address;
            // to ensure "storageKeys" is required (not null)
            if (storageKeys == null)
            {
                throw new ArgumentNullException("storageKeys is a required property for InputGetProof and cannot be null");
            }
            this.StorageKeys = storageKeys;
            // use default value if no "blockNumber" provided
            this.BlockNumber = blockNumber ?? @"latest";
        }

        /// <summary>
        /// A URL to the JSON Schema for this object.
        /// </summary>
        /// <value>A URL to the JSON Schema for this object.</value>
        [DataMember(Name = "$schema", EmitDefaultValue = false)]
        public string Schema { get; private set; }

        /// <summary>
        /// Returns false as Schema should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSchema()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets BlockNumber
        /// </summary>
        [DataMember(Name = "BlockNumber", EmitDefaultValue = false)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// An array of storage-keys that should be proofed and included
        /// </summary>
        /// <value>An array of storage-keys that should be proofed and included</value>
        [DataMember(Name = "StorageKeys", IsRequired = true, EmitDefaultValue = true)]
        public List<string> StorageKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InputGetProof {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  StorageKeys: ").Append(StorageKeys).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
