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
    /// ResponseBlock
    /// </summary>
    [DataContract(Name = "Response_Block")]
    public partial class ResponseBlock : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBlock" /> class.
        /// </summary>
        /// <param name="baseFeePerGas">A string of the base fee encoded in decimal format. Please note that this response field will not be included in a block requested before the EIP-1559 upgrade (required).</param>
        /// <param name="difficulty">The integer of the difficulty for this block encoded as a decimal (required).</param>
        /// <param name="extraData">The “extra data” field of this block (required).</param>
        /// <param name="gasLimit">The maximum gas allowed in this block encoded as a decimal (required).</param>
        /// <param name="gasUsed">The total used gas by all transactions in this block encoded as a decimal (required).</param>
        /// <param name="hash">The block hash of the requested block. null if pending (required).</param>
        /// <param name="logsBloom">The bloom filter for the logs of the block. null if pending (required).</param>
        /// <param name="miner">The address of the beneficiary to whom the mining rewards were given (required).</param>
        /// <param name="mixHash">A string of a 256-bit hash encoded as a decimal (required).</param>
        /// <param name="nonce">The hash of the generated proof-of-work. null if pending (required).</param>
        /// <param name="number">The block number of the requested block encoded as a decimal. null if pending (required).</param>
        /// <param name="parentHash">The hash of the parent block (required).</param>
        /// <param name="receiptsRoot">The root of the receipts trie of the bloc (required).</param>
        /// <param name="sha3Uncles">The SHA3 of the uncles data in the block (required).</param>
        /// <param name="size">The size of this block in bytes as an Integer value encoded as decimal (required).</param>
        /// <param name="stateRoot">The root of the final state trie of the block (required).</param>
        /// <param name="timestamp">The unix timestamp for when the block was collated (required).</param>
        /// <param name="totalDifficulty">The integer of the total difficulty of the chain until this block encoded as a decimal (required).</param>
        /// <param name="transactions">An array of transaction objects - please see getTransactionByHash for exact shape (required).</param>
        /// <param name="transactionsRoot">The root of the transaction trie of the block (required).</param>
        /// <param name="uncles">An array of uncle hashes (required).</param>
        /// <param name="withdrawals">A withdrawals object contains information about withdrawals made by validators. Please note that this field will not be included in a block requested before the EIP-4895 upgrade (required).</param>
        /// <param name="withdrawalsRoot">The Merkle root of withdrawal data. Also, please note that this field will not be included in a block requested before the EIP-4895 upgrade (required).</param>
        public ResponseBlock(string baseFeePerGas = default(string), string difficulty = default(string), string extraData = default(string), string gasLimit = default(string), string gasUsed = default(string), string hash = default(string), string logsBloom = default(string), string miner = default(string), string mixHash = default(string), string nonce = default(string), string number = default(string), string parentHash = default(string), string receiptsRoot = default(string), string sha3Uncles = default(string), string size = default(string), string stateRoot = default(string), string timestamp = default(string), string totalDifficulty = default(string), List<ResponseTransaction> transactions = default(List<ResponseTransaction>), string transactionsRoot = default(string), List<string> uncles = default(List<string>), ResponseWithdrawals withdrawals = default(ResponseWithdrawals), string withdrawalsRoot = default(string))
        {
            // to ensure "baseFeePerGas" is required (not null)
            if (baseFeePerGas == null)
            {
                throw new ArgumentNullException("baseFeePerGas is a required property for ResponseBlock and cannot be null");
            }
            this.BaseFeePerGas = baseFeePerGas;
            // to ensure "difficulty" is required (not null)
            if (difficulty == null)
            {
                throw new ArgumentNullException("difficulty is a required property for ResponseBlock and cannot be null");
            }
            this.Difficulty = difficulty;
            // to ensure "extraData" is required (not null)
            if (extraData == null)
            {
                throw new ArgumentNullException("extraData is a required property for ResponseBlock and cannot be null");
            }
            this.ExtraData = extraData;
            // to ensure "gasLimit" is required (not null)
            if (gasLimit == null)
            {
                throw new ArgumentNullException("gasLimit is a required property for ResponseBlock and cannot be null");
            }
            this.GasLimit = gasLimit;
            // to ensure "gasUsed" is required (not null)
            if (gasUsed == null)
            {
                throw new ArgumentNullException("gasUsed is a required property for ResponseBlock and cannot be null");
            }
            this.GasUsed = gasUsed;
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new ArgumentNullException("hash is a required property for ResponseBlock and cannot be null");
            }
            this.Hash = hash;
            // to ensure "logsBloom" is required (not null)
            if (logsBloom == null)
            {
                throw new ArgumentNullException("logsBloom is a required property for ResponseBlock and cannot be null");
            }
            this.LogsBloom = logsBloom;
            // to ensure "miner" is required (not null)
            if (miner == null)
            {
                throw new ArgumentNullException("miner is a required property for ResponseBlock and cannot be null");
            }
            this.Miner = miner;
            // to ensure "mixHash" is required (not null)
            if (mixHash == null)
            {
                throw new ArgumentNullException("mixHash is a required property for ResponseBlock and cannot be null");
            }
            this.MixHash = mixHash;
            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new ArgumentNullException("nonce is a required property for ResponseBlock and cannot be null");
            }
            this.Nonce = nonce;
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for ResponseBlock and cannot be null");
            }
            this.Number = number;
            // to ensure "parentHash" is required (not null)
            if (parentHash == null)
            {
                throw new ArgumentNullException("parentHash is a required property for ResponseBlock and cannot be null");
            }
            this.ParentHash = parentHash;
            // to ensure "receiptsRoot" is required (not null)
            if (receiptsRoot == null)
            {
                throw new ArgumentNullException("receiptsRoot is a required property for ResponseBlock and cannot be null");
            }
            this.ReceiptsRoot = receiptsRoot;
            // to ensure "sha3Uncles" is required (not null)
            if (sha3Uncles == null)
            {
                throw new ArgumentNullException("sha3Uncles is a required property for ResponseBlock and cannot be null");
            }
            this.Sha3Uncles = sha3Uncles;
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new ArgumentNullException("size is a required property for ResponseBlock and cannot be null");
            }
            this.Size = size;
            // to ensure "stateRoot" is required (not null)
            if (stateRoot == null)
            {
                throw new ArgumentNullException("stateRoot is a required property for ResponseBlock and cannot be null");
            }
            this.StateRoot = stateRoot;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for ResponseBlock and cannot be null");
            }
            this.Timestamp = timestamp;
            // to ensure "totalDifficulty" is required (not null)
            if (totalDifficulty == null)
            {
                throw new ArgumentNullException("totalDifficulty is a required property for ResponseBlock and cannot be null");
            }
            this.TotalDifficulty = totalDifficulty;
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new ArgumentNullException("transactions is a required property for ResponseBlock and cannot be null");
            }
            this.Transactions = transactions;
            // to ensure "transactionsRoot" is required (not null)
            if (transactionsRoot == null)
            {
                throw new ArgumentNullException("transactionsRoot is a required property for ResponseBlock and cannot be null");
            }
            this.TransactionsRoot = transactionsRoot;
            // to ensure "uncles" is required (not null)
            if (uncles == null)
            {
                throw new ArgumentNullException("uncles is a required property for ResponseBlock and cannot be null");
            }
            this.Uncles = uncles;
            // to ensure "withdrawals" is required (not null)
            if (withdrawals == null)
            {
                throw new ArgumentNullException("withdrawals is a required property for ResponseBlock and cannot be null");
            }
            this.Withdrawals = withdrawals;
            // to ensure "withdrawalsRoot" is required (not null)
            if (withdrawalsRoot == null)
            {
                throw new ArgumentNullException("withdrawalsRoot is a required property for ResponseBlock and cannot be null");
            }
            this.WithdrawalsRoot = withdrawalsRoot;
        }

        /// <summary>
        /// A string of the base fee encoded in decimal format. Please note that this response field will not be included in a block requested before the EIP-1559 upgrade
        /// </summary>
        /// <value>A string of the base fee encoded in decimal format. Please note that this response field will not be included in a block requested before the EIP-1559 upgrade</value>
        [DataMember(Name = "BaseFeePerGas", IsRequired = true, EmitDefaultValue = true)]
        public string BaseFeePerGas { get; set; }

        /// <summary>
        /// The integer of the difficulty for this block encoded as a decimal
        /// </summary>
        /// <value>The integer of the difficulty for this block encoded as a decimal</value>
        [DataMember(Name = "Difficulty", IsRequired = true, EmitDefaultValue = true)]
        public string Difficulty { get; set; }

        /// <summary>
        /// The “extra data” field of this block
        /// </summary>
        /// <value>The “extra data” field of this block</value>
        [DataMember(Name = "ExtraData", IsRequired = true, EmitDefaultValue = true)]
        public string ExtraData { get; set; }

        /// <summary>
        /// The maximum gas allowed in this block encoded as a decimal
        /// </summary>
        /// <value>The maximum gas allowed in this block encoded as a decimal</value>
        [DataMember(Name = "GasLimit", IsRequired = true, EmitDefaultValue = true)]
        public string GasLimit { get; set; }

        /// <summary>
        /// The total used gas by all transactions in this block encoded as a decimal
        /// </summary>
        /// <value>The total used gas by all transactions in this block encoded as a decimal</value>
        [DataMember(Name = "GasUsed", IsRequired = true, EmitDefaultValue = true)]
        public string GasUsed { get; set; }

        /// <summary>
        /// The block hash of the requested block. null if pending
        /// </summary>
        /// <value>The block hash of the requested block. null if pending</value>
        [DataMember(Name = "Hash", IsRequired = true, EmitDefaultValue = true)]
        public string Hash { get; set; }

        /// <summary>
        /// The bloom filter for the logs of the block. null if pending
        /// </summary>
        /// <value>The bloom filter for the logs of the block. null if pending</value>
        [DataMember(Name = "LogsBloom", IsRequired = true, EmitDefaultValue = true)]
        public string LogsBloom { get; set; }

        /// <summary>
        /// The address of the beneficiary to whom the mining rewards were given
        /// </summary>
        /// <value>The address of the beneficiary to whom the mining rewards were given</value>
        [DataMember(Name = "Miner", IsRequired = true, EmitDefaultValue = true)]
        public string Miner { get; set; }

        /// <summary>
        /// A string of a 256-bit hash encoded as a decimal
        /// </summary>
        /// <value>A string of a 256-bit hash encoded as a decimal</value>
        [DataMember(Name = "MixHash", IsRequired = true, EmitDefaultValue = true)]
        public string MixHash { get; set; }

        /// <summary>
        /// The hash of the generated proof-of-work. null if pending
        /// </summary>
        /// <value>The hash of the generated proof-of-work. null if pending</value>
        [DataMember(Name = "Nonce", IsRequired = true, EmitDefaultValue = true)]
        public string Nonce { get; set; }

        /// <summary>
        /// The block number of the requested block encoded as a decimal. null if pending
        /// </summary>
        /// <value>The block number of the requested block encoded as a decimal. null if pending</value>
        [DataMember(Name = "Number", IsRequired = true, EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// The hash of the parent block
        /// </summary>
        /// <value>The hash of the parent block</value>
        [DataMember(Name = "ParentHash", IsRequired = true, EmitDefaultValue = true)]
        public string ParentHash { get; set; }

        /// <summary>
        /// The root of the receipts trie of the bloc
        /// </summary>
        /// <value>The root of the receipts trie of the bloc</value>
        [DataMember(Name = "ReceiptsRoot", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiptsRoot { get; set; }

        /// <summary>
        /// The SHA3 of the uncles data in the block
        /// </summary>
        /// <value>The SHA3 of the uncles data in the block</value>
        [DataMember(Name = "Sha3Uncles", IsRequired = true, EmitDefaultValue = true)]
        public string Sha3Uncles { get; set; }

        /// <summary>
        /// The size of this block in bytes as an Integer value encoded as decimal
        /// </summary>
        /// <value>The size of this block in bytes as an Integer value encoded as decimal</value>
        [DataMember(Name = "Size", IsRequired = true, EmitDefaultValue = true)]
        public string Size { get; set; }

        /// <summary>
        /// The root of the final state trie of the block
        /// </summary>
        /// <value>The root of the final state trie of the block</value>
        [DataMember(Name = "StateRoot", IsRequired = true, EmitDefaultValue = true)]
        public string StateRoot { get; set; }

        /// <summary>
        /// The unix timestamp for when the block was collated
        /// </summary>
        /// <value>The unix timestamp for when the block was collated</value>
        [DataMember(Name = "Timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// The integer of the total difficulty of the chain until this block encoded as a decimal
        /// </summary>
        /// <value>The integer of the total difficulty of the chain until this block encoded as a decimal</value>
        [DataMember(Name = "TotalDifficulty", IsRequired = true, EmitDefaultValue = true)]
        public string TotalDifficulty { get; set; }

        /// <summary>
        /// An array of transaction objects - please see getTransactionByHash for exact shape
        /// </summary>
        /// <value>An array of transaction objects - please see getTransactionByHash for exact shape</value>
        [DataMember(Name = "Transactions", IsRequired = true, EmitDefaultValue = true)]
        public List<ResponseTransaction> Transactions { get; set; }

        /// <summary>
        /// The root of the transaction trie of the block
        /// </summary>
        /// <value>The root of the transaction trie of the block</value>
        [DataMember(Name = "TransactionsRoot", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionsRoot { get; set; }

        /// <summary>
        /// An array of uncle hashes
        /// </summary>
        /// <value>An array of uncle hashes</value>
        [DataMember(Name = "Uncles", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Uncles { get; set; }

        /// <summary>
        /// A withdrawals object contains information about withdrawals made by validators. Please note that this field will not be included in a block requested before the EIP-4895 upgrade
        /// </summary>
        /// <value>A withdrawals object contains information about withdrawals made by validators. Please note that this field will not be included in a block requested before the EIP-4895 upgrade</value>
        [DataMember(Name = "Withdrawals", IsRequired = true, EmitDefaultValue = true)]
        public ResponseWithdrawals Withdrawals { get; set; }

        /// <summary>
        /// The Merkle root of withdrawal data. Also, please note that this field will not be included in a block requested before the EIP-4895 upgrade
        /// </summary>
        /// <value>The Merkle root of withdrawal data. Also, please note that this field will not be included in a block requested before the EIP-4895 upgrade</value>
        [DataMember(Name = "WithdrawalsRoot", IsRequired = true, EmitDefaultValue = true)]
        public string WithdrawalsRoot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseBlock {\n");
            sb.Append("  BaseFeePerGas: ").Append(BaseFeePerGas).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  LogsBloom: ").Append(LogsBloom).Append("\n");
            sb.Append("  Miner: ").Append(Miner).Append("\n");
            sb.Append("  MixHash: ").Append(MixHash).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ParentHash: ").Append(ParentHash).Append("\n");
            sb.Append("  ReceiptsRoot: ").Append(ReceiptsRoot).Append("\n");
            sb.Append("  Sha3Uncles: ").Append(Sha3Uncles).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StateRoot: ").Append(StateRoot).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TotalDifficulty: ").Append(TotalDifficulty).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  TransactionsRoot: ").Append(TransactionsRoot).Append("\n");
            sb.Append("  Uncles: ").Append(Uncles).Append("\n");
            sb.Append("  Withdrawals: ").Append(Withdrawals).Append("\n");
            sb.Append("  WithdrawalsRoot: ").Append(WithdrawalsRoot).Append("\n");
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
