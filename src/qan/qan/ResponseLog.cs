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
    /// ResponseLog
    /// </summary>
    [DataContract(Name = "Response_Log")]
    public partial class ResponseLog : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLog" /> class.
        /// </summary>
        /// <param name="address">An address from which this log originated (required).</param>
        /// <param name="blockHash">The hash of the block where this log was in. null when its a pending log (required).</param>
        /// <param name="blockNumber">The block number where this log was in. null when its a pending log (required).</param>
        /// <param name="data">It contains one or more 32 Bytes non-indexed arguments of the log (required).</param>
        /// <param name="logIndex">The integer of the log index position in the block. null when its a pending log (required).</param>
        /// <param name="removed">It is true when the log was removed due to a chain reorganization, and false if it&#39;s a valid log (required).</param>
        /// <param name="topics">An array of zero to four 32 Bytes DATA of indexed log arguments. In Solidity, the first topic is the hash of the signature of the event (e.g. Deposit(address, bytes32, uint256)), except you declare the event with the anonymous specifier (required).</param>
        /// <param name="transactionHash">The hash of the transactions this log was created from. null when its a pending log (required).</param>
        /// <param name="transactionIndex">The integer of the transaction&#39;s index position that the log was created from. null when it&#39;s a pending log (required).</param>
        public ResponseLog(string address = default(string), string blockHash = default(string), string blockNumber = default(string), string data = default(string), string logIndex = default(string), bool removed = default(bool), List<string> topics = default(List<string>), string transactionHash = default(string), string transactionIndex = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for ResponseLog and cannot be null");
            }
            this.Address = address;
            // to ensure "blockHash" is required (not null)
            if (blockHash == null)
            {
                throw new ArgumentNullException("blockHash is a required property for ResponseLog and cannot be null");
            }
            this.BlockHash = blockHash;
            // to ensure "blockNumber" is required (not null)
            if (blockNumber == null)
            {
                throw new ArgumentNullException("blockNumber is a required property for ResponseLog and cannot be null");
            }
            this.BlockNumber = blockNumber;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for ResponseLog and cannot be null");
            }
            this.Data = data;
            // to ensure "logIndex" is required (not null)
            if (logIndex == null)
            {
                throw new ArgumentNullException("logIndex is a required property for ResponseLog and cannot be null");
            }
            this.LogIndex = logIndex;
            this.Removed = removed;
            // to ensure "topics" is required (not null)
            if (topics == null)
            {
                throw new ArgumentNullException("topics is a required property for ResponseLog and cannot be null");
            }
            this.Topics = topics;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for ResponseLog and cannot be null");
            }
            this.TransactionHash = transactionHash;
            // to ensure "transactionIndex" is required (not null)
            if (transactionIndex == null)
            {
                throw new ArgumentNullException("transactionIndex is a required property for ResponseLog and cannot be null");
            }
            this.TransactionIndex = transactionIndex;
        }

        /// <summary>
        /// An address from which this log originated
        /// </summary>
        /// <value>An address from which this log originated</value>
        [DataMember(Name = "Address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The hash of the block where this log was in. null when its a pending log
        /// </summary>
        /// <value>The hash of the block where this log was in. null when its a pending log</value>
        [DataMember(Name = "BlockHash", IsRequired = true, EmitDefaultValue = true)]
        public string BlockHash { get; set; }

        /// <summary>
        /// The block number where this log was in. null when its a pending log
        /// </summary>
        /// <value>The block number where this log was in. null when its a pending log</value>
        [DataMember(Name = "BlockNumber", IsRequired = true, EmitDefaultValue = true)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// It contains one or more 32 Bytes non-indexed arguments of the log
        /// </summary>
        /// <value>It contains one or more 32 Bytes non-indexed arguments of the log</value>
        [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// The integer of the log index position in the block. null when its a pending log
        /// </summary>
        /// <value>The integer of the log index position in the block. null when its a pending log</value>
        [DataMember(Name = "LogIndex", IsRequired = true, EmitDefaultValue = true)]
        public string LogIndex { get; set; }

        /// <summary>
        /// It is true when the log was removed due to a chain reorganization, and false if it&#39;s a valid log
        /// </summary>
        /// <value>It is true when the log was removed due to a chain reorganization, and false if it&#39;s a valid log</value>
        [DataMember(Name = "Removed", IsRequired = true, EmitDefaultValue = true)]
        public bool Removed { get; set; }

        /// <summary>
        /// An array of zero to four 32 Bytes DATA of indexed log arguments. In Solidity, the first topic is the hash of the signature of the event (e.g. Deposit(address, bytes32, uint256)), except you declare the event with the anonymous specifier
        /// </summary>
        /// <value>An array of zero to four 32 Bytes DATA of indexed log arguments. In Solidity, the first topic is the hash of the signature of the event (e.g. Deposit(address, bytes32, uint256)), except you declare the event with the anonymous specifier</value>
        [DataMember(Name = "Topics", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// The hash of the transactions this log was created from. null when its a pending log
        /// </summary>
        /// <value>The hash of the transactions this log was created from. null when its a pending log</value>
        [DataMember(Name = "TransactionHash", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// The integer of the transaction&#39;s index position that the log was created from. null when it&#39;s a pending log
        /// </summary>
        /// <value>The integer of the transaction&#39;s index position that the log was created from. null when it&#39;s a pending log</value>
        [DataMember(Name = "TransactionIndex", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseLog {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  LogIndex: ").Append(LogIndex).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  TransactionIndex: ").Append(TransactionIndex).Append("\n");
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
