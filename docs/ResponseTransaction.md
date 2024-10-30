# qan.qan.ResponseTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessList** | **string** | A list of addresses and storage keys that the transaction plans to access | [optional] 
**BlockHash** | **string** | The hash of the block where this transaction was in. Null when it&#39;s a pending transaction | [optional] 
**BlockNumber** | **string** | The block number where this transaction was in. Null when it&#39;s a pending transaction | [optional] 
**ChainId** | **string** | The chain id of the transaction, if any | [optional] 
**From** | **string** | The address of the sender | [optional] 
**Gas** | **string** | The gas provided by the sender, encoded as decimal | [optional] 
**GasPrice** | **string** | The gas price provided by the sender in wei encoded as decimal | [optional] 
**Hash** | **string** | The hash of the transaction | [optional] 
**Input** | **string** | The data sent along with the transaction | [optional] 
**MaxFeePerGas** | **string** | The maximum fee per gas set in the transaction | [optional] 
**MaxPriorityFeePerGas** | **string** | The maximum priority gas fee set in the transaction | [optional] 
**Nonce** | **string** | The number of transactions made by the sender prior to this one encoded as decimal | [optional] 
**R** | **string** | The R field of the signature | [optional] 
**S** | **string** | The S field of the signature | [optional] 
**To** | **string** | The address of the receiver. Null when its a contract creation transaction | [optional] 
**TransactionIndex** | **string** | The integer of the transaction&#39;s index position that the log was created from. Null when it&#39;s a pending log | [optional] 
**Type** | **string** | The transaction type | [optional] 
**V** | **string** | The standardized V field of the signature | [optional] 
**Value** | **string** | The value transferred in wei encoded as decimal | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

