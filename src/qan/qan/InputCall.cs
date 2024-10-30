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
    /// InputCall
    /// </summary>
    [DataContract(Name = "Input_call")]
    public partial class InputCall : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputCall" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputCall() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputCall" /> class.
        /// </summary>
        /// <param name="blockNumber">blockNumber (required).</param>
        /// <param name="transaction">The transaction call object (required).</param>
        public InputCall(string blockNumber = default(string), ParamsTransaction transaction = default(ParamsTransaction))
        {
            // to ensure "blockNumber" is required (not null)
            if (blockNumber == null)
            {
                throw new ArgumentNullException("blockNumber is a required property for InputCall and cannot be null");
            }
            this.BlockNumber = blockNumber;
            // to ensure "transaction" is required (not null)
            if (transaction == null)
            {
                throw new ArgumentNullException("transaction is a required property for InputCall and cannot be null");
            }
            this.Transaction = transaction;
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
        /// Gets or Sets BlockNumber
        /// </summary>
        [DataMember(Name = "BlockNumber", IsRequired = true, EmitDefaultValue = true)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// The transaction call object
        /// </summary>
        /// <value>The transaction call object</value>
        [DataMember(Name = "Transaction", IsRequired = true, EmitDefaultValue = true)]
        public ParamsTransaction Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InputCall {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
