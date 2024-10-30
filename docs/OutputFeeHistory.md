# qan.qan.OutputFeeHistory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | **string** | A URL to the JSON Schema for this object. | [optional] [readonly] 
**BaseFeePerGas** | **List&lt;string&gt;** | An array of block base fees per gas. This includes the next block after the newest of the returned range, because this value can be derived from the newest block. Zeroes are returned for pre-EIP-1559 blocks | 
**GasUsedRatio** | **List&lt;double&gt;** | An array of block gas used ratios. These are calculated as the ratio of gasUsed and gasLimit | 
**OldestBlock** | **string** | The lowest number block of the returned range encoded in decimal format | 
**Reward** | **List&lt;List&lt;string&gt;&gt;** | An array of effective priority fees per gas data points from a single block. All zeroes are returned if the block is empty | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

