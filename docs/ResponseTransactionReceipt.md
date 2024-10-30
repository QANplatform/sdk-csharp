# qan.qan.ResponseTransactionReceipt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockHash** | **string** | The hash of the block. null when pending | [optional] 
**BlockNumber** | **string** |  | [optional] 
**ContractAddress** | **string** | The contract address created if the transaction was a contract creation, otherwise null | [optional] 
**CumulativeGasUsed** | **string** | The total amount of gas used when this transaction was executed in the block | [optional] 
**EffectiveGasPrice** | **string** | The actual value per gas deducted from the sender account | [optional] 
**From** | **string** | The address of the sender | [optional] 
**GasUsed** | **string** | The amount of gas used by this specific transaction alone | [optional] 
**Logs** | [**List&lt;ResponseLog&gt;**](ResponseLog.md) | An array of log objects that generated this transaction | [optional] 
**LogsBloom** | **string** | The bloom filter for light clients to quickly retrieve related logs | [optional] 
**Status** | **string** | It is either 1 (success) or 0 (failure) encoded as a decimal | [optional] 
**To** | **string** | The address of the receiver. null when it&#39;s a contract creation transaction | [optional] 
**TransactionHash** | **string** | The hash of the transaction | [optional] 
**TransactionIndex** | **string** | An index of the transaction in the block | [optional] 
**Type** | **string** | The value type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

