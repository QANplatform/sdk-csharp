# qan.qan.ResponseBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseFeePerGas** | **string** | A string of the base fee encoded in decimal format. Please note that this response field will not be included in a block requested before the EIP-1559 upgrade | 
**Difficulty** | **string** | The integer of the difficulty for this block encoded as a decimal | 
**ExtraData** | **string** | The “extra data” field of this block | 
**GasLimit** | **string** | The maximum gas allowed in this block encoded as a decimal | 
**GasUsed** | **string** | The total used gas by all transactions in this block encoded as a decimal | 
**Hash** | **string** | The block hash of the requested block. null if pending | 
**LogsBloom** | **string** | The bloom filter for the logs of the block. null if pending | 
**Miner** | **string** | The address of the beneficiary to whom the mining rewards were given | 
**MixHash** | **string** | A string of a 256-bit hash encoded as a decimal | 
**Nonce** | **string** | The hash of the generated proof-of-work. null if pending | 
**Number** | **string** | The block number of the requested block encoded as a decimal. null if pending | 
**ParentHash** | **string** | The hash of the parent block | 
**ReceiptsRoot** | **string** | The root of the receipts trie of the bloc | 
**Sha3Uncles** | **string** | The SHA3 of the uncles data in the block | 
**Size** | **string** | The size of this block in bytes as an Integer value encoded as decimal | 
**StateRoot** | **string** | The root of the final state trie of the block | 
**Timestamp** | **string** | The unix timestamp for when the block was collated | 
**TotalDifficulty** | **string** | The integer of the total difficulty of the chain until this block encoded as a decimal | 
**Transactions** | [**List&lt;ResponseTransaction&gt;**](ResponseTransaction.md) | An array of transaction objects - please see getTransactionByHash for exact shape | 
**TransactionsRoot** | **string** | The root of the transaction trie of the block | 
**Uncles** | **List&lt;string&gt;** | An array of uncle hashes | 
**Withdrawals** | [**ResponseWithdrawals**](ResponseWithdrawals.md) | A withdrawals object contains information about withdrawals made by validators. Please note that this field will not be included in a block requested before the EIP-4895 upgrade | 
**WithdrawalsRoot** | **string** | The Merkle root of withdrawal data. Also, please note that this field will not be included in a block requested before the EIP-4895 upgrade | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

