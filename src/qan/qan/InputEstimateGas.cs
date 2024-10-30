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
    /// InputEstimateGas
    /// </summary>
    [DataContract(Name = "Input_estimateGas")]
    public partial class InputEstimateGas : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputEstimateGas" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputEstimateGas() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputEstimateGas" /> class.
        /// </summary>
        /// <param name="varObject">The state override set with address-to-state mapping where each address maps to an object containing.</param>
        /// <param name="transaction">The transaction call object (required).</param>
        public InputEstimateGas(EstimateGasObject varObject = default(EstimateGasObject), ParamsTransaction transaction = default(ParamsTransaction))
        {
            // to ensure "transaction" is required (not null)
            if (transaction == null)
            {
                throw new ArgumentNullException("transaction is a required property for InputEstimateGas and cannot be null");
            }
            this.Transaction = transaction;
            this.Object = varObject;
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
        /// The state override set with address-to-state mapping where each address maps to an object containing
        /// </summary>
        /// <value>The state override set with address-to-state mapping where each address maps to an object containing</value>
        [DataMember(Name = "Object", EmitDefaultValue = false)]
        public EstimateGasObject Object { get; set; }

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
            sb.Append("class InputEstimateGas {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
