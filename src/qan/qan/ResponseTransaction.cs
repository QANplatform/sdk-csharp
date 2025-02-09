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
    /// ResponseTransaction
    /// </summary>
    [DataContract(Name = "Response_Transaction")]
    public partial class ResponseTransaction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTransaction" /> class.
        /// </summary>
        /// <param name="accessList">A list of addresses and storage keys that the transaction plans to access.</param>
        /// <param name="blockHash">The hash of the block where this transaction was in. Null when it&#39;s a pending transaction.</param>
        /// <param name="blockNumber">The block number where this transaction was in. Null when it&#39;s a pending transaction.</param>
        /// <param name="chainId">The chain id of the transaction, if any.</param>
        /// <param name="from">The address of the sender.</param>
        /// <param name="gas">The gas provided by the sender, encoded as decimal.</param>
        /// <param name="gasPrice">The gas price provided by the sender in wei encoded as decimal.</param>
        /// <param name="hash">The hash of the transaction.</param>
        /// <param name="input">The data sent along with the transaction.</param>
        /// <param name="maxFeePerGas">The maximum fee per gas set in the transaction.</param>
        /// <param name="maxPriorityFeePerGas">The maximum priority gas fee set in the transaction.</param>
        /// <param name="nonce">The number of transactions made by the sender prior to this one encoded as decimal.</param>
        /// <param name="r">The R field of the signature.</param>
        /// <param name="s">The S field of the signature.</param>
        /// <param name="to">The address of the receiver. Null when its a contract creation transaction.</param>
        /// <param name="transactionIndex">The integer of the transaction&#39;s index position that the log was created from. Null when it&#39;s a pending log.</param>
        /// <param name="type">The transaction type.</param>
        /// <param name="v">The standardized V field of the signature.</param>
        /// <param name="value">The value transferred in wei encoded as decimal.</param>
        public ResponseTransaction(string accessList = default(string), string blockHash = default(string), string blockNumber = default(string), string chainId = default(string), string from = default(string), string gas = default(string), string gasPrice = default(string), string hash = default(string), string input = default(string), string maxFeePerGas = default(string), string maxPriorityFeePerGas = default(string), string nonce = default(string), string r = default(string), string s = default(string), string to = default(string), string transactionIndex = default(string), string type = default(string), string v = default(string), string value = default(string))
        {
            this.AccessList = accessList;
            this.BlockHash = blockHash;
            this.BlockNumber = blockNumber;
            this.ChainId = chainId;
            this.From = from;
            this.Gas = gas;
            this.GasPrice = gasPrice;
            this.Hash = hash;
            this.Input = input;
            this.MaxFeePerGas = maxFeePerGas;
            this.MaxPriorityFeePerGas = maxPriorityFeePerGas;
            this.Nonce = nonce;
            this.R = r;
            this.S = s;
            this.To = to;
            this.TransactionIndex = transactionIndex;
            this.Type = type;
            this.V = v;
            this.Value = value;
        }

        /// <summary>
        /// A list of addresses and storage keys that the transaction plans to access
        /// </summary>
        /// <value>A list of addresses and storage keys that the transaction plans to access</value>
        [DataMember(Name = "AccessList", EmitDefaultValue = false)]
        public string AccessList { get; set; }

        /// <summary>
        /// The hash of the block where this transaction was in. Null when it&#39;s a pending transaction
        /// </summary>
        /// <value>The hash of the block where this transaction was in. Null when it&#39;s a pending transaction</value>
        [DataMember(Name = "BlockHash", EmitDefaultValue = false)]
        public string BlockHash { get; set; }

        /// <summary>
        /// The block number where this transaction was in. Null when it&#39;s a pending transaction
        /// </summary>
        /// <value>The block number where this transaction was in. Null when it&#39;s a pending transaction</value>
        [DataMember(Name = "BlockNumber", EmitDefaultValue = false)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// The chain id of the transaction, if any
        /// </summary>
        /// <value>The chain id of the transaction, if any</value>
        [DataMember(Name = "ChainId", EmitDefaultValue = false)]
        public string ChainId { get; set; }

        /// <summary>
        /// The address of the sender
        /// </summary>
        /// <value>The address of the sender</value>
        [DataMember(Name = "From", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// The gas provided by the sender, encoded as decimal
        /// </summary>
        /// <value>The gas provided by the sender, encoded as decimal</value>
        [DataMember(Name = "Gas", EmitDefaultValue = false)]
        public string Gas { get; set; }

        /// <summary>
        /// The gas price provided by the sender in wei encoded as decimal
        /// </summary>
        /// <value>The gas price provided by the sender in wei encoded as decimal</value>
        [DataMember(Name = "GasPrice", EmitDefaultValue = false)]
        public string GasPrice { get; set; }

        /// <summary>
        /// The hash of the transaction
        /// </summary>
        /// <value>The hash of the transaction</value>
        [DataMember(Name = "Hash", EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// The data sent along with the transaction
        /// </summary>
        /// <value>The data sent along with the transaction</value>
        [DataMember(Name = "Input", EmitDefaultValue = false)]
        public string Input { get; set; }

        /// <summary>
        /// The maximum fee per gas set in the transaction
        /// </summary>
        /// <value>The maximum fee per gas set in the transaction</value>
        [DataMember(Name = "MaxFeePerGas", EmitDefaultValue = false)]
        public string MaxFeePerGas { get; set; }

        /// <summary>
        /// The maximum priority gas fee set in the transaction
        /// </summary>
        /// <value>The maximum priority gas fee set in the transaction</value>
        [DataMember(Name = "MaxPriorityFeePerGas", EmitDefaultValue = false)]
        public string MaxPriorityFeePerGas { get; set; }

        /// <summary>
        /// The number of transactions made by the sender prior to this one encoded as decimal
        /// </summary>
        /// <value>The number of transactions made by the sender prior to this one encoded as decimal</value>
        [DataMember(Name = "Nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// The R field of the signature
        /// </summary>
        /// <value>The R field of the signature</value>
        [DataMember(Name = "R", EmitDefaultValue = false)]
        public string R { get; set; }

        /// <summary>
        /// The S field of the signature
        /// </summary>
        /// <value>The S field of the signature</value>
        [DataMember(Name = "S", EmitDefaultValue = false)]
        public string S { get; set; }

        /// <summary>
        /// The address of the receiver. Null when its a contract creation transaction
        /// </summary>
        /// <value>The address of the receiver. Null when its a contract creation transaction</value>
        [DataMember(Name = "To", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// The integer of the transaction&#39;s index position that the log was created from. Null when it&#39;s a pending log
        /// </summary>
        /// <value>The integer of the transaction&#39;s index position that the log was created from. Null when it&#39;s a pending log</value>
        [DataMember(Name = "TransactionIndex", EmitDefaultValue = false)]
        public string TransactionIndex { get; set; }

        /// <summary>
        /// The transaction type
        /// </summary>
        /// <value>The transaction type</value>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The standardized V field of the signature
        /// </summary>
        /// <value>The standardized V field of the signature</value>
        [DataMember(Name = "V", EmitDefaultValue = false)]
        public string V { get; set; }

        /// <summary>
        /// The value transferred in wei encoded as decimal
        /// </summary>
        /// <value>The value transferred in wei encoded as decimal</value>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseTransaction {\n");
            sb.Append("  AccessList: ").Append(AccessList).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Gas: ").Append(Gas).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  MaxFeePerGas: ").Append(MaxFeePerGas).Append("\n");
            sb.Append("  MaxPriorityFeePerGas: ").Append(MaxPriorityFeePerGas).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  S: ").Append(S).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  TransactionIndex: ").Append(TransactionIndex).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
