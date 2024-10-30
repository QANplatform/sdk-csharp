# qan.Api.QANApi

All URIs are relative to *https://rpc-testnet.qanplatform.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QanBlockNumber**](QANApi.md#qanblocknumber) | **GET** /blockNumber/ | Returns the latest block number of the blockchain. |
| [**QanCall**](QANApi.md#qancall) | **POST** /call/ | Executes a new message call immediately without creating a transaction on the block chain. |
| [**QanChainId**](QANApi.md#qanchainid) | **GET** /chainId/ | Returns the current network/chain ID, used to sign replay-protected transaction introduced in EIP-155. |
| [**QanEstimateGas**](QANApi.md#qanestimategas) | **POST** /estimateGas/ | Returns an estimation of gas for a given transaction. |
| [**QanFeeHistory**](QANApi.md#qanfeehistory) | **POST** /feeHistory/ | Returns the collection of historical gas information. |
| [**QanGasPrice**](QANApi.md#qangasprice) | **GET** /gasPrice/ | Returns the current gas price on the network in wei. |
| [**QanGetBalance**](QANApi.md#qangetbalance) | **GET** /getBalance/{Address}/ | Returns the balance of the account of given address. |
| [**QanGetBlockByHash**](QANApi.md#qangetblockbyhash) | **GET** /getBlockByHash/{Hash}/{TransactionDetailFlag}/ | Returns information of the block matching the given block hash. |
| [**QanGetBlockByNumber**](QANApi.md#qangetblockbynumber) | **GET** /getBlockByNumber/{BlockNumber}/{TransactionDetailFlag}/ | Returns information of the block matching the given block number. |
| [**QanGetBlockReceipts**](QANApi.md#qangetblockreceipts) | **GET** /getBlockReceipts/{BlockNumber}/ | Returns all transaction receipts for a given block. |
| [**QanGetBlockTransactionCountByHash**](QANApi.md#qangetblocktransactioncountbyhash) | **GET** /getBlockTransactionCountByHash/{Hash}/ | Returns the number of transactions for the block matching the given block hash. |
| [**QanGetBlockTransactionCountByNumber**](QANApi.md#qangetblocktransactioncountbynumber) | **GET** /getBlockTransactionCountByNumber/{BlockNumber}/ | Returns the number of transactions for the block matching the given block number. |
| [**QanGetCode**](QANApi.md#qangetcode) | **GET** /getCode/{Address}/ | Returns the compiled bytecode of a smart contract. |
| [**QanGetFilterChanges**](QANApi.md#qangetfilterchanges) | **GET** /getFilterChanges/{FilterId}/ | Polling method for a filter, which returns an array of events that have occurred since the last poll. |
| [**QanGetFilterLogs**](QANApi.md#qangetfilterlogs) | **GET** /getFilterLogs/{Id}/ | Returns an array of all logs matching filter with given id. |
| [**QanGetLogs**](QANApi.md#qangetlogs) | **POST** /getLogs/ | Returns an array of all logs matching a given filter object. |
| [**QanGetProof**](QANApi.md#qangetproof) | **POST** /getProof/ | Returns the account and storage values of the specified account including the Merkle-proof. |
| [**QanGetStorageAt**](QANApi.md#qangetstorageat) | **POST** /getStorageAt/ | Returns the value from a storage position at a given address. |
| [**QanGetTransactionByBlockHashAndIndex**](QANApi.md#qangettransactionbyblockhashandindex) | **GET** /getTransactionByBlockHashAndIndex/{blockHash}/{index}/ | Returns information about a transaction given a blockhash and transaction index position. |
| [**QanGetTransactionByBlockNumberAndIndex**](QANApi.md#qangettransactionbyblocknumberandindex) | **GET** /getTransactionByBlockNumberAndIndex/{blockNumber}/{index}/ | Returns information about a transaction given a block number and transaction index position. |
| [**QanGetTransactionByHash**](QANApi.md#qangettransactionbyhash) | **GET** /getTransactionByHash/{hash}/ | Returns the information about a transaction from a transaction hash. |
| [**QanGetTransactionCount**](QANApi.md#qangettransactioncount) | **GET** /getTransactionCount/{Address}/{BlockNumber}/ | Returns the number of transactions sent from an address. |
| [**QanGetTransactionReceipt**](QANApi.md#qangettransactionreceipt) | **GET** /getTransactionReceipt/{Hash}/ | Returns the receipt of a transaction by transaction hash. |
| [**QanMaxPriorityFeePerGas**](QANApi.md#qanmaxpriorityfeepergas) | **GET** /maxPriorityFeePerGas/ | Get the priority fee needed to be included in a block. |
| [**QanNewBlockFilter**](QANApi.md#qannewblockfilter) | **GET** /newBlockFilter/ | Creates a filter in the node, to notify when a new block arrives. |
| [**QanNewFilter**](QANApi.md#qannewfilter) | **POST** /newFilter/ | Creates a filter object, based on filter options, to notify when the state changes (logs). |
| [**QanNewPendingTransactionFilter**](QANApi.md#qannewpendingtransactionfilter) | **GET** /newPendingTransactionFilter/ | Creates a filter in the node to notify when new pending transactions arrive. |
| [**QanSendRawTransaction**](QANApi.md#qansendrawtransaction) | **POST** /sendRawTransaction/ | Creates new message call transaction or a contract creation for signed transactions. |
| [**QanSyncing**](QANApi.md#qansyncing) | **GET** /syncing/ | Returns an object with the sync status of the node if the node is out-of-sync and is syncing. Returns null when the node is already in sync. |
| [**QanUninstallFilter**](QANApi.md#qanuninstallfilter) | **GET** /uninstallFilter/{FilterId}/ | Uninstalls a filter with the given filter id. |
| [**QanXlinkValid**](QANApi.md#qanxlinkvalid) | **GET** /xlinkValid/{Address}/ | Returns the xlink validity time of the account of given address. |

<a id="qanblocknumber"></a>
# **QanBlockNumber**
> OutputBlockNumber QanBlockNumber ()

Returns the latest block number of the blockchain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanBlockNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);

            try
            {
                // Returns the latest block number of the blockchain.
                OutputBlockNumber result = apiInstance.QanBlockNumber();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanBlockNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanBlockNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the latest block number of the blockchain.
    ApiResponse<OutputBlockNumber> response = apiInstance.QanBlockNumberWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanBlockNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OutputBlockNumber**](OutputBlockNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qancall"></a>
# **QanCall**
> OutputCall QanCall (InputCall inputCall)

Executes a new message call immediately without creating a transaction on the block chain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputCall = new InputCall(); // InputCall | 

            try
            {
                // Executes a new message call immediately without creating a transaction on the block chain.
                OutputCall result = apiInstance.QanCall(inputCall);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Executes a new message call immediately without creating a transaction on the block chain.
    ApiResponse<OutputCall> response = apiInstance.QanCallWithHttpInfo(inputCall);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanCallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputCall** | [**InputCall**](InputCall.md) |  |  |

### Return type

[**OutputCall**](OutputCall.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qanchainid"></a>
# **QanChainId**
> OutputChainId QanChainId ()

Returns the current network/chain ID, used to sign replay-protected transaction introduced in EIP-155.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanChainIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);

            try
            {
                // Returns the current network/chain ID, used to sign replay-protected transaction introduced in EIP-155.
                OutputChainId result = apiInstance.QanChainId();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanChainId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanChainIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the current network/chain ID, used to sign replay-protected transaction introduced in EIP-155.
    ApiResponse<OutputChainId> response = apiInstance.QanChainIdWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanChainIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OutputChainId**](OutputChainId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qanestimategas"></a>
# **QanEstimateGas**
> OutputEstimateGas QanEstimateGas (InputEstimateGas inputEstimateGas)

Returns an estimation of gas for a given transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanEstimateGasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputEstimateGas = new InputEstimateGas(); // InputEstimateGas | 

            try
            {
                // Returns an estimation of gas for a given transaction.
                OutputEstimateGas result = apiInstance.QanEstimateGas(inputEstimateGas);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanEstimateGas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanEstimateGasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns an estimation of gas for a given transaction.
    ApiResponse<OutputEstimateGas> response = apiInstance.QanEstimateGasWithHttpInfo(inputEstimateGas);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanEstimateGasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputEstimateGas** | [**InputEstimateGas**](InputEstimateGas.md) |  |  |

### Return type

[**OutputEstimateGas**](OutputEstimateGas.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qanfeehistory"></a>
# **QanFeeHistory**
> OutputFeeHistory QanFeeHistory (InputFeeHistory inputFeeHistory)

Returns the collection of historical gas information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanFeeHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputFeeHistory = new InputFeeHistory(); // InputFeeHistory | 

            try
            {
                // Returns the collection of historical gas information.
                OutputFeeHistory result = apiInstance.QanFeeHistory(inputFeeHistory);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanFeeHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanFeeHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the collection of historical gas information.
    ApiResponse<OutputFeeHistory> response = apiInstance.QanFeeHistoryWithHttpInfo(inputFeeHistory);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanFeeHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputFeeHistory** | [**InputFeeHistory**](InputFeeHistory.md) |  |  |

### Return type

[**OutputFeeHistory**](OutputFeeHistory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangasprice"></a>
# **QanGasPrice**
> OutputGasPrice QanGasPrice ()

Returns the current gas price on the network in wei.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGasPriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);

            try
            {
                // Returns the current gas price on the network in wei.
                OutputGasPrice result = apiInstance.QanGasPrice();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGasPrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGasPriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the current gas price on the network in wei.
    ApiResponse<OutputGasPrice> response = apiInstance.QanGasPriceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGasPriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OutputGasPrice**](OutputGasPrice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetbalance"></a>
# **QanGetBalance**
> OutputGetBalance QanGetBalance (string address, string? blockNumber = null)

Returns the balance of the account of given address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var address = 0xa1e4380a3b1f749673e270229993ee55f35663b4;  // string | A 20 bytes long hexadecimal value representing an address
            var blockNumber = "\"latest\"";  // string? | The block number in hexadecimal or decimal format or the string latest, earliest, pending (optional)  (default to "latest")

            try
            {
                // Returns the balance of the account of given address.
                OutputGetBalance result = apiInstance.QanGetBalance(address, blockNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the balance of the account of given address.
    ApiResponse<OutputGetBalance> response = apiInstance.QanGetBalanceWithHttpInfo(address, blockNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | A 20 bytes long hexadecimal value representing an address |  |
| **blockNumber** | **string?** | The block number in hexadecimal or decimal format or the string latest, earliest, pending | [optional] [default to &quot;latest&quot;] |

### Return type

[**OutputGetBalance**](OutputGetBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetblockbyhash"></a>
# **QanGetBlockByHash**
> OutputGetBlockByHash QanGetBlockByHash (string hash, bool transactionDetailFlag)

Returns information of the block matching the given block hash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetBlockByHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var hash = 0x4e3a3754410177e6937ef1f84bba68ea139e8d1a2258c5f85db9f1cd715a1bdd;  // string | The hash (32 bytes) of the block
            var transactionDetailFlag = false;  // bool | The method returns the full transaction objects when this value is true otherwise, it returns only the hashes of the transactions (default to false)

            try
            {
                // Returns information of the block matching the given block hash.
                OutputGetBlockByHash result = apiInstance.QanGetBlockByHash(hash, transactionDetailFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetBlockByHash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetBlockByHashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns information of the block matching the given block hash.
    ApiResponse<OutputGetBlockByHash> response = apiInstance.QanGetBlockByHashWithHttpInfo(hash, transactionDetailFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetBlockByHashWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | **string** | The hash (32 bytes) of the block |  |
| **transactionDetailFlag** | **bool** | The method returns the full transaction objects when this value is true otherwise, it returns only the hashes of the transactions | [default to false] |

### Return type

[**OutputGetBlockByHash**](OutputGetBlockByHash.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetblockbynumber"></a>
# **QanGetBlockByNumber**
> OutputGetBlockByNumber QanGetBlockByNumber (string blockNumber, bool transactionDetailFlag)

Returns information of the block matching the given block number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetBlockByNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var blockNumber = "\"latest\"";  // string | The block number in hexadecimal or decimal format or the string latest, earliest, pending (default to "latest")
            var transactionDetailFlag = false;  // bool | The method returns the full transaction objects when this value is true otherwise, it returns only the hashes of the transactions (default to false)

            try
            {
                // Returns information of the block matching the given block number.
                OutputGetBlockByNumber result = apiInstance.QanGetBlockByNumber(blockNumber, transactionDetailFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetBlockByNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetBlockByNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns information of the block matching the given block number.
    ApiResponse<OutputGetBlockByNumber> response = apiInstance.QanGetBlockByNumberWithHttpInfo(blockNumber, transactionDetailFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetBlockByNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockNumber** | **string** | The block number in hexadecimal or decimal format or the string latest, earliest, pending | [default to &quot;latest&quot;] |
| **transactionDetailFlag** | **bool** | The method returns the full transaction objects when this value is true otherwise, it returns only the hashes of the transactions | [default to false] |

### Return type

[**OutputGetBlockByNumber**](OutputGetBlockByNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetblockreceipts"></a>
# **QanGetBlockReceipts**
> OutputGetBlockReceipts QanGetBlockReceipts (string blockNumber)

Returns all transaction receipts for a given block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetBlockReceiptsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var blockNumber = "\"latest\"";  // string | The block number in hexadecimal or decimal format or the string latest, earliest, pending (default to "latest")

            try
            {
                // Returns all transaction receipts for a given block.
                OutputGetBlockReceipts result = apiInstance.QanGetBlockReceipts(blockNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetBlockReceipts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetBlockReceiptsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all transaction receipts for a given block.
    ApiResponse<OutputGetBlockReceipts> response = apiInstance.QanGetBlockReceiptsWithHttpInfo(blockNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetBlockReceiptsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockNumber** | **string** | The block number in hexadecimal or decimal format or the string latest, earliest, pending | [default to &quot;latest&quot;] |

### Return type

[**OutputGetBlockReceipts**](OutputGetBlockReceipts.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetblocktransactioncountbyhash"></a>
# **QanGetBlockTransactionCountByHash**
> OutputGetBlockTransactionCountByHash QanGetBlockTransactionCountByHash (string hash)

Returns the number of transactions for the block matching the given block hash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetBlockTransactionCountByHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var hash = 0x4e3a3754410177e6937ef1f84bba68ea139e8d1a2258c5f85db9f1cd715a1bdd;  // string | The hash of the block

            try
            {
                // Returns the number of transactions for the block matching the given block hash.
                OutputGetBlockTransactionCountByHash result = apiInstance.QanGetBlockTransactionCountByHash(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetBlockTransactionCountByHash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetBlockTransactionCountByHashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the number of transactions for the block matching the given block hash.
    ApiResponse<OutputGetBlockTransactionCountByHash> response = apiInstance.QanGetBlockTransactionCountByHashWithHttpInfo(hash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetBlockTransactionCountByHashWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | **string** | The hash of the block |  |

### Return type

[**OutputGetBlockTransactionCountByHash**](OutputGetBlockTransactionCountByHash.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetblocktransactioncountbynumber"></a>
# **QanGetBlockTransactionCountByNumber**
> OutputGetBlockTransactionCountByNumber QanGetBlockTransactionCountByNumber (string blockNumber)

Returns the number of transactions for the block matching the given block number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetBlockTransactionCountByNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var blockNumber = latest;  // string | The block number in hexadecimal or decimal format or the string latest, earliest, pending

            try
            {
                // Returns the number of transactions for the block matching the given block number.
                OutputGetBlockTransactionCountByNumber result = apiInstance.QanGetBlockTransactionCountByNumber(blockNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetBlockTransactionCountByNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetBlockTransactionCountByNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the number of transactions for the block matching the given block number.
    ApiResponse<OutputGetBlockTransactionCountByNumber> response = apiInstance.QanGetBlockTransactionCountByNumberWithHttpInfo(blockNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetBlockTransactionCountByNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockNumber** | **string** | The block number in hexadecimal or decimal format or the string latest, earliest, pending |  |

### Return type

[**OutputGetBlockTransactionCountByNumber**](OutputGetBlockTransactionCountByNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetcode"></a>
# **QanGetCode**
> OutputGetCode QanGetCode (string address, string? blockNumber = null)

Returns the compiled bytecode of a smart contract.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var address = 0xa1e4380a3b1f749673e270229993ee55f35663b4;  // string | The address of the smart contract from which the bytecode will be obtained
            var blockNumber = latest;  // string? | The block number in hexadecimal or decimal format or the string latest, earliest, pending (optional)  (default to "latest")

            try
            {
                // Returns the compiled bytecode of a smart contract.
                OutputGetCode result = apiInstance.QanGetCode(address, blockNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the compiled bytecode of a smart contract.
    ApiResponse<OutputGetCode> response = apiInstance.QanGetCodeWithHttpInfo(address, blockNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | The address of the smart contract from which the bytecode will be obtained |  |
| **blockNumber** | **string?** | The block number in hexadecimal or decimal format or the string latest, earliest, pending | [optional] [default to &quot;latest&quot;] |

### Return type

[**OutputGetCode**](OutputGetCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetfilterchanges"></a>
# **QanGetFilterChanges**
> OutputGetFilterChanges QanGetFilterChanges (string filterId)

Polling method for a filter, which returns an array of events that have occurred since the last poll.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetFilterChangesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var filterId = "filterId_example";  // string | The filter id that is returned from getFilterChangesnewFilter, getFilterChangesnewBlockFilter or getFilterChangesnewPendingTransactionFilter

            try
            {
                // Polling method for a filter, which returns an array of events that have occurred since the last poll.
                OutputGetFilterChanges result = apiInstance.QanGetFilterChanges(filterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetFilterChanges: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetFilterChangesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Polling method for a filter, which returns an array of events that have occurred since the last poll.
    ApiResponse<OutputGetFilterChanges> response = apiInstance.QanGetFilterChangesWithHttpInfo(filterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetFilterChangesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | The filter id that is returned from getFilterChangesnewFilter, getFilterChangesnewBlockFilter or getFilterChangesnewPendingTransactionFilter |  |

### Return type

[**OutputGetFilterChanges**](OutputGetFilterChanges.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetfilterlogs"></a>
# **QanGetFilterLogs**
> OutputGetFilterLogs QanGetFilterLogs (string id)

Returns an array of all logs matching filter with given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetFilterLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var id = "id_example";  // string | The filter ID

            try
            {
                // Returns an array of all logs matching filter with given id.
                OutputGetFilterLogs result = apiInstance.QanGetFilterLogs(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetFilterLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetFilterLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns an array of all logs matching filter with given id.
    ApiResponse<OutputGetFilterLogs> response = apiInstance.QanGetFilterLogsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetFilterLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The filter ID |  |

### Return type

[**OutputGetFilterLogs**](OutputGetFilterLogs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetlogs"></a>
# **QanGetLogs**
> OutputGetLogs QanGetLogs (InputGetLogs inputGetLogs)

Returns an array of all logs matching a given filter object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputGetLogs = new InputGetLogs(); // InputGetLogs | 

            try
            {
                // Returns an array of all logs matching a given filter object.
                OutputGetLogs result = apiInstance.QanGetLogs(inputGetLogs);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns an array of all logs matching a given filter object.
    ApiResponse<OutputGetLogs> response = apiInstance.QanGetLogsWithHttpInfo(inputGetLogs);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputGetLogs** | [**InputGetLogs**](InputGetLogs.md) |  |  |

### Return type

[**OutputGetLogs**](OutputGetLogs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetproof"></a>
# **QanGetProof**
> OutputGetProof QanGetProof (InputGetProof inputGetProof)

Returns the account and storage values of the specified account including the Merkle-proof.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetProofExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputGetProof = new InputGetProof(); // InputGetProof | 

            try
            {
                // Returns the account and storage values of the specified account including the Merkle-proof.
                OutputGetProof result = apiInstance.QanGetProof(inputGetProof);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetProof: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetProofWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the account and storage values of the specified account including the Merkle-proof.
    ApiResponse<OutputGetProof> response = apiInstance.QanGetProofWithHttpInfo(inputGetProof);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetProofWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputGetProof** | [**InputGetProof**](InputGetProof.md) |  |  |

### Return type

[**OutputGetProof**](OutputGetProof.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangetstorageat"></a>
# **QanGetStorageAt**
> OutputGetStorageAt QanGetStorageAt (InputGetStorageAt inputGetStorageAt)

Returns the value from a storage position at a given address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetStorageAtExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputGetStorageAt = new InputGetStorageAt(); // InputGetStorageAt | 

            try
            {
                // Returns the value from a storage position at a given address.
                OutputGetStorageAt result = apiInstance.QanGetStorageAt(inputGetStorageAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetStorageAt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetStorageAtWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the value from a storage position at a given address.
    ApiResponse<OutputGetStorageAt> response = apiInstance.QanGetStorageAtWithHttpInfo(inputGetStorageAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetStorageAtWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputGetStorageAt** | [**InputGetStorageAt**](InputGetStorageAt.md) |  |  |

### Return type

[**OutputGetStorageAt**](OutputGetStorageAt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangettransactionbyblockhashandindex"></a>
# **QanGetTransactionByBlockHashAndIndex**
> OutputGetTransactionByBlockHashAndIndex QanGetTransactionByBlockHashAndIndex (string blockHash, string index)

Returns information about a transaction given a blockhash and transaction index position.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetTransactionByBlockHashAndIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var blockHash = 0x4e3a3754410177e6937ef1f84bba68ea139e8d1a2258c5f85db9f1cd715a1bdd;  // string | 
            var index = 0;  // string | An integer of the transaction index position

            try
            {
                // Returns information about a transaction given a blockhash and transaction index position.
                OutputGetTransactionByBlockHashAndIndex result = apiInstance.QanGetTransactionByBlockHashAndIndex(blockHash, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetTransactionByBlockHashAndIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetTransactionByBlockHashAndIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns information about a transaction given a blockhash and transaction index position.
    ApiResponse<OutputGetTransactionByBlockHashAndIndex> response = apiInstance.QanGetTransactionByBlockHashAndIndexWithHttpInfo(blockHash, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetTransactionByBlockHashAndIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockHash** | **string** |  |  |
| **index** | **string** | An integer of the transaction index position |  |

### Return type

[**OutputGetTransactionByBlockHashAndIndex**](OutputGetTransactionByBlockHashAndIndex.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangettransactionbyblocknumberandindex"></a>
# **QanGetTransactionByBlockNumberAndIndex**
> OutputGetTransactionByBlockNumberAndIndex QanGetTransactionByBlockNumberAndIndex (string blockNumber, string index)

Returns information about a transaction given a block number and transaction index position.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetTransactionByBlockNumberAndIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var blockNumber = latest;  // string | The block number in hexadecimal or decimal format or the string latest, earliest, pending
            var index = 0;  // string | An integer of the transaction index position

            try
            {
                // Returns information about a transaction given a block number and transaction index position.
                OutputGetTransactionByBlockNumberAndIndex result = apiInstance.QanGetTransactionByBlockNumberAndIndex(blockNumber, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetTransactionByBlockNumberAndIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetTransactionByBlockNumberAndIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns information about a transaction given a block number and transaction index position.
    ApiResponse<OutputGetTransactionByBlockNumberAndIndex> response = apiInstance.QanGetTransactionByBlockNumberAndIndexWithHttpInfo(blockNumber, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetTransactionByBlockNumberAndIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockNumber** | **string** | The block number in hexadecimal or decimal format or the string latest, earliest, pending |  |
| **index** | **string** | An integer of the transaction index position |  |

### Return type

[**OutputGetTransactionByBlockNumberAndIndex**](OutputGetTransactionByBlockNumberAndIndex.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangettransactionbyhash"></a>
# **QanGetTransactionByHash**
> OutputGetTransactionByHash QanGetTransactionByHash (string hash)

Returns the information about a transaction from a transaction hash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetTransactionByHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var hash = 0x5c504ed432cb51138bcf09aa5e8a410dd4a1e204ef84bfed1be16dfba1b22060;  // string | The hash of a transaction

            try
            {
                // Returns the information about a transaction from a transaction hash.
                OutputGetTransactionByHash result = apiInstance.QanGetTransactionByHash(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetTransactionByHash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetTransactionByHashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the information about a transaction from a transaction hash.
    ApiResponse<OutputGetTransactionByHash> response = apiInstance.QanGetTransactionByHashWithHttpInfo(hash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetTransactionByHashWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | **string** | The hash of a transaction |  |

### Return type

[**OutputGetTransactionByHash**](OutputGetTransactionByHash.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangettransactioncount"></a>
# **QanGetTransactionCount**
> OutputGetTransactionCount QanGetTransactionCount (string address, string blockNumber)

Returns the number of transactions sent from an address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetTransactionCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var address = 0xa1e4380a3b1f749673e270229993ee55f35663b4;  // string | The address from which the transaction count to be checked
            var blockNumber = latest;  // string | The block number in hexadecimal or decimal format or the string latest, earliest, pending

            try
            {
                // Returns the number of transactions sent from an address.
                OutputGetTransactionCount result = apiInstance.QanGetTransactionCount(address, blockNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetTransactionCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetTransactionCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the number of transactions sent from an address.
    ApiResponse<OutputGetTransactionCount> response = apiInstance.QanGetTransactionCountWithHttpInfo(address, blockNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetTransactionCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | The address from which the transaction count to be checked |  |
| **blockNumber** | **string** | The block number in hexadecimal or decimal format or the string latest, earliest, pending |  |

### Return type

[**OutputGetTransactionCount**](OutputGetTransactionCount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qangettransactionreceipt"></a>
# **QanGetTransactionReceipt**
> OutputGetTransactionReceipt QanGetTransactionReceipt (string hash)

Returns the receipt of a transaction by transaction hash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanGetTransactionReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var hash = 0x4e3a3754410177e6937ef1f84bba68ea139e8d1a2258c5f85db9f1cd715a1bdd;  // string | The hash of a transaction

            try
            {
                // Returns the receipt of a transaction by transaction hash.
                OutputGetTransactionReceipt result = apiInstance.QanGetTransactionReceipt(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanGetTransactionReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanGetTransactionReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the receipt of a transaction by transaction hash.
    ApiResponse<OutputGetTransactionReceipt> response = apiInstance.QanGetTransactionReceiptWithHttpInfo(hash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanGetTransactionReceiptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | **string** | The hash of a transaction |  |

### Return type

[**OutputGetTransactionReceipt**](OutputGetTransactionReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qanmaxpriorityfeepergas"></a>
# **QanMaxPriorityFeePerGas**
> OutputMaxPriorityFeePerGas QanMaxPriorityFeePerGas ()

Get the priority fee needed to be included in a block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanMaxPriorityFeePerGasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);

            try
            {
                // Get the priority fee needed to be included in a block.
                OutputMaxPriorityFeePerGas result = apiInstance.QanMaxPriorityFeePerGas();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanMaxPriorityFeePerGas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanMaxPriorityFeePerGasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the priority fee needed to be included in a block.
    ApiResponse<OutputMaxPriorityFeePerGas> response = apiInstance.QanMaxPriorityFeePerGasWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanMaxPriorityFeePerGasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OutputMaxPriorityFeePerGas**](OutputMaxPriorityFeePerGas.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qannewblockfilter"></a>
# **QanNewBlockFilter**
> OutputNewBlockFilter QanNewBlockFilter ()

Creates a filter in the node, to notify when a new block arrives.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanNewBlockFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);

            try
            {
                // Creates a filter in the node, to notify when a new block arrives.
                OutputNewBlockFilter result = apiInstance.QanNewBlockFilter();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanNewBlockFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanNewBlockFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a filter in the node, to notify when a new block arrives.
    ApiResponse<OutputNewBlockFilter> response = apiInstance.QanNewBlockFilterWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanNewBlockFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OutputNewBlockFilter**](OutputNewBlockFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qannewfilter"></a>
# **QanNewFilter**
> OutputNewFilter QanNewFilter (InputNewFilter inputNewFilter)

Creates a filter object, based on filter options, to notify when the state changes (logs).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanNewFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputNewFilter = new InputNewFilter(); // InputNewFilter | 

            try
            {
                // Creates a filter object, based on filter options, to notify when the state changes (logs).
                OutputNewFilter result = apiInstance.QanNewFilter(inputNewFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanNewFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanNewFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a filter object, based on filter options, to notify when the state changes (logs).
    ApiResponse<OutputNewFilter> response = apiInstance.QanNewFilterWithHttpInfo(inputNewFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanNewFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputNewFilter** | [**InputNewFilter**](InputNewFilter.md) |  |  |

### Return type

[**OutputNewFilter**](OutputNewFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qannewpendingtransactionfilter"></a>
# **QanNewPendingTransactionFilter**
> OutputNewPendingTransactionFilter QanNewPendingTransactionFilter ()

Creates a filter in the node to notify when new pending transactions arrive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanNewPendingTransactionFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);

            try
            {
                // Creates a filter in the node to notify when new pending transactions arrive.
                OutputNewPendingTransactionFilter result = apiInstance.QanNewPendingTransactionFilter();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanNewPendingTransactionFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanNewPendingTransactionFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a filter in the node to notify when new pending transactions arrive.
    ApiResponse<OutputNewPendingTransactionFilter> response = apiInstance.QanNewPendingTransactionFilterWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanNewPendingTransactionFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OutputNewPendingTransactionFilter**](OutputNewPendingTransactionFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qansendrawtransaction"></a>
# **QanSendRawTransaction**
> OutputSendRawTransaction QanSendRawTransaction (InputSendRawTransaction inputSendRawTransaction)

Creates new message call transaction or a contract creation for signed transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanSendRawTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var inputSendRawTransaction = new InputSendRawTransaction(); // InputSendRawTransaction | 

            try
            {
                // Creates new message call transaction or a contract creation for signed transactions.
                OutputSendRawTransaction result = apiInstance.QanSendRawTransaction(inputSendRawTransaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanSendRawTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanSendRawTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates new message call transaction or a contract creation for signed transactions.
    ApiResponse<OutputSendRawTransaction> response = apiInstance.QanSendRawTransactionWithHttpInfo(inputSendRawTransaction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanSendRawTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputSendRawTransaction** | [**InputSendRawTransaction**](InputSendRawTransaction.md) |  |  |

### Return type

[**OutputSendRawTransaction**](OutputSendRawTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qansyncing"></a>
# **QanSyncing**
> OutputSyncing QanSyncing ()

Returns an object with the sync status of the node if the node is out-of-sync and is syncing. Returns null when the node is already in sync.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanSyncingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);

            try
            {
                // Returns an object with the sync status of the node if the node is out-of-sync and is syncing. Returns null when the node is already in sync.
                OutputSyncing result = apiInstance.QanSyncing();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanSyncing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanSyncingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns an object with the sync status of the node if the node is out-of-sync and is syncing. Returns null when the node is already in sync.
    ApiResponse<OutputSyncing> response = apiInstance.QanSyncingWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanSyncingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OutputSyncing**](OutputSyncing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qanuninstallfilter"></a>
# **QanUninstallFilter**
> OutputUninstallFilter QanUninstallFilter (string filterId)

Uninstalls a filter with the given filter id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanUninstallFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var filterId = "filterId_example";  // string | The filter ID that needs to be uninstalled. It should always be called when watch is no longer needed. Additionally, Filters timeout when they aren't requested with getFilterChanges for a period of time

            try
            {
                // Uninstalls a filter with the given filter id.
                OutputUninstallFilter result = apiInstance.QanUninstallFilter(filterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanUninstallFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanUninstallFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Uninstalls a filter with the given filter id.
    ApiResponse<OutputUninstallFilter> response = apiInstance.QanUninstallFilterWithHttpInfo(filterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanUninstallFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | The filter ID that needs to be uninstalled. It should always be called when watch is no longer needed. Additionally, Filters timeout when they aren&#39;t requested with getFilterChanges for a period of time |  |

### Return type

[**OutputUninstallFilter**](OutputUninstallFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="qanxlinkvalid"></a>
# **QanXlinkValid**
> OutputXlinkValid QanXlinkValid (string address)

Returns the xlink validity time of the account of given address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using qan.Api;
using qan.Client;
using qan.qan;

namespace Example
{
    public class QanXlinkValidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rpc-testnet.qanplatform.com";
            var apiInstance = new QANApi(config);
            var address = "address_example";  // string | 

            try
            {
                // Returns the xlink validity time of the account of given address.
                OutputXlinkValid result = apiInstance.QanXlinkValid(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QANApi.QanXlinkValid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QanXlinkValidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the xlink validity time of the account of given address.
    ApiResponse<OutputXlinkValid> response = apiInstance.QanXlinkValidWithHttpInfo(address);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QANApi.QanXlinkValidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** |  |  |

### Return type

[**OutputXlinkValid**](OutputXlinkValid.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

