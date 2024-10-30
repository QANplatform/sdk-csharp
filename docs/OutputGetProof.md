# qan.qan.OutputGetProof

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | **string** | A URL to the JSON Schema for this object. | [optional] [readonly] 
**AccountProof** | **string** | An array of rlp-serialized MerkleTree-Nodes which starts with the stateRoot-Node and follows the path of the SHA3 address as key | 
**Address** | **string** | The address associated with the account | 
**Balance** | **string** | The current balance of the account in wei | 
**CodeHash** | **string** | A 32 byte hash of the code of the account | 
**Nonce** | **string** | The hash of the generated proof-of-work. Null if pending | 
**StorageHash** | **string** | A 32 byte SHA3 of the storageRoot. All storage will deliver a MerkleProof starting with this rootHash | 
**StorageProof** | [**List&lt;ResponseStorageEntry&gt;**](ResponseStorageEntry.md) | An array of storage-entries as requested. Each entry is an object with the following fields: | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

