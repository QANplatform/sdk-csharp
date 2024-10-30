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
    /// OutputGetBalance
    /// </summary>
    [DataContract(Name = "Output_getBalance")]
    public partial class OutputGetBalance : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputGetBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutputGetBalance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputGetBalance" /> class.
        /// </summary>
        /// <param name="balance">The balance of the specified address in decimal value, measured in wei (required).</param>
        public OutputGetBalance(string balance = default(string))
        {
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new ArgumentNullException("balance is a required property for OutputGetBalance and cannot be null");
            }
            this.Balance = balance;
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
        /// The balance of the specified address in decimal value, measured in wei
        /// </summary>
        /// <value>The balance of the specified address in decimal value, measured in wei</value>
        [DataMember(Name = "Balance", IsRequired = true, EmitDefaultValue = true)]
        public string Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutputGetBalance {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
