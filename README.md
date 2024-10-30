# QAN C# SDK

This repository is guaranteed up-to-date with the upstream QAN API definitions, and leverages OpenAPI technology to stay consistent.

Versioning is based on SEMVER, meaning:

- Stable releases guarantee backwards compatibility for the same major versions.
- Minor releases will not contain breaking changes.
- Patch releases only focus on fixing issues.

## Documentation for API Endpoints

All URIs are relative to *https://rpc-testnet.qanplatform.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*QANApi* | [**QanBlockNumber**](docs/QANApi.md#qanblocknumber) | **GET** /blockNumber/ | Returns the latest block number of the blockchain.
*QANApi* | [**QanCall**](docs/QANApi.md#qancall) | **POST** /call/ | Executes a new message call immediately without creating a transaction on the block chain.
*QANApi* | [**QanChainId**](docs/QANApi.md#qanchainid) | **GET** /chainId/ | Returns the current network/chain ID, used to sign replay-protected transaction introduced in EIP-155.
*QANApi* | [**QanEstimateGas**](docs/QANApi.md#qanestimategas) | **POST** /estimateGas/ | Returns an estimation of gas for a given transaction.
*QANApi* | [**QanFeeHistory**](docs/QANApi.md#qanfeehistory) | **POST** /feeHistory/ | Returns the collection of historical gas information.
*QANApi* | [**QanGasPrice**](docs/QANApi.md#qangasprice) | **GET** /gasPrice/ | Returns the current gas price on the network in wei.
*QANApi* | [**QanGetBalance**](docs/QANApi.md#qangetbalance) | **GET** /getBalance/{Address}/ | Returns the balance of the account of given address.
*QANApi* | [**QanGetBlockByHash**](docs/QANApi.md#qangetblockbyhash) | **GET** /getBlockByHash/{Hash}/{TransactionDetailFlag}/ | Returns information of the block matching the given block hash.
*QANApi* | [**QanGetBlockByNumber**](docs/QANApi.md#qangetblockbynumber) | **GET** /getBlockByNumber/{BlockNumber}/{TransactionDetailFlag}/ | Returns information of the block matching the given block number.
*QANApi* | [**QanGetBlockReceipts**](docs/QANApi.md#qangetblockreceipts) | **GET** /getBlockReceipts/{BlockNumber}/ | Returns all transaction receipts for a given block.
*QANApi* | [**QanGetBlockTransactionCountByHash**](docs/QANApi.md#qangetblocktransactioncountbyhash) | **GET** /getBlockTransactionCountByHash/{Hash}/ | Returns the number of transactions for the block matching the given block hash.
*QANApi* | [**QanGetBlockTransactionCountByNumber**](docs/QANApi.md#qangetblocktransactioncountbynumber) | **GET** /getBlockTransactionCountByNumber/{BlockNumber}/ | Returns the number of transactions for the block matching the given block number.
*QANApi* | [**QanGetCode**](docs/QANApi.md#qangetcode) | **GET** /getCode/{Address}/ | Returns the compiled bytecode of a smart contract.
*QANApi* | [**QanGetFilterChanges**](docs/QANApi.md#qangetfilterchanges) | **GET** /getFilterChanges/{FilterId}/ | Polling method for a filter, which returns an array of events that have occurred since the last poll.
*QANApi* | [**QanGetFilterLogs**](docs/QANApi.md#qangetfilterlogs) | **GET** /getFilterLogs/{Id}/ | Returns an array of all logs matching filter with given id.
*QANApi* | [**QanGetLogs**](docs/QANApi.md#qangetlogs) | **POST** /getLogs/ | Returns an array of all logs matching a given filter object.
*QANApi* | [**QanGetProof**](docs/QANApi.md#qangetproof) | **POST** /getProof/ | Returns the account and storage values of the specified account including the Merkle-proof.
*QANApi* | [**QanGetStorageAt**](docs/QANApi.md#qangetstorageat) | **POST** /getStorageAt/ | Returns the value from a storage position at a given address.
*QANApi* | [**QanGetTransactionByBlockHashAndIndex**](docs/QANApi.md#qangettransactionbyblockhashandindex) | **GET** /getTransactionByBlockHashAndIndex/{blockHash}/{index}/ | Returns information about a transaction given a blockhash and transaction index position.
*QANApi* | [**QanGetTransactionByBlockNumberAndIndex**](docs/QANApi.md#qangettransactionbyblocknumberandindex) | **GET** /getTransactionByBlockNumberAndIndex/{blockNumber}/{index}/ | Returns information about a transaction given a block number and transaction index position.
*QANApi* | [**QanGetTransactionByHash**](docs/QANApi.md#qangettransactionbyhash) | **GET** /getTransactionByHash/{hash}/ | Returns the information about a transaction from a transaction hash.
*QANApi* | [**QanGetTransactionCount**](docs/QANApi.md#qangettransactioncount) | **GET** /getTransactionCount/{Address}/{BlockNumber}/ | Returns the number of transactions sent from an address.
*QANApi* | [**QanGetTransactionReceipt**](docs/QANApi.md#qangettransactionreceipt) | **GET** /getTransactionReceipt/{Hash}/ | Returns the receipt of a transaction by transaction hash.
*QANApi* | [**QanMaxPriorityFeePerGas**](docs/QANApi.md#qanmaxpriorityfeepergas) | **GET** /maxPriorityFeePerGas/ | Get the priority fee needed to be included in a block.
*QANApi* | [**QanNewBlockFilter**](docs/QANApi.md#qannewblockfilter) | **GET** /newBlockFilter/ | Creates a filter in the node, to notify when a new block arrives.
*QANApi* | [**QanNewFilter**](docs/QANApi.md#qannewfilter) | **POST** /newFilter/ | Creates a filter object, based on filter options, to notify when the state changes (logs).
*QANApi* | [**QanNewPendingTransactionFilter**](docs/QANApi.md#qannewpendingtransactionfilter) | **GET** /newPendingTransactionFilter/ | Creates a filter in the node to notify when new pending transactions arrive.
*QANApi* | [**QanSendRawTransaction**](docs/QANApi.md#qansendrawtransaction) | **POST** /sendRawTransaction/ | Creates new message call transaction or a contract creation for signed transactions.
*QANApi* | [**QanSyncing**](docs/QANApi.md#qansyncing) | **GET** /syncing/ | Returns an object with the sync status of the node if the node is out-of-sync and is syncing. Returns null when the node is already in sync.
*QANApi* | [**QanUninstallFilter**](docs/QANApi.md#qanuninstallfilter) | **GET** /uninstallFilter/{FilterId}/ | Uninstalls a filter with the given filter id.
*QANApi* | [**QanXlinkValid**](docs/QANApi.md#qanxlinkvalid) | **GET** /xlinkValid/{Address}/ | Returns the xlink validity time of the account of given address.


## Documentation For Models

 - [qan.ErrorDetail](docs/ErrorDetail.md)
 - [qan.ErrorModel](docs/ErrorModel.md)
 - [qan.EstimateGasObject](docs/EstimateGasObject.md)
 - [qan.FilterObject](docs/FilterObject.md)
 - [qan.InputCall](docs/InputCall.md)
 - [qan.InputEstimateGas](docs/InputEstimateGas.md)
 - [qan.InputFeeHistory](docs/InputFeeHistory.md)
 - [qan.InputGetLogs](docs/InputGetLogs.md)
 - [qan.InputGetProof](docs/InputGetProof.md)
 - [qan.InputGetStorageAt](docs/InputGetStorageAt.md)
 - [qan.InputNewFilter](docs/InputNewFilter.md)
 - [qan.InputSendRawTransaction](docs/InputSendRawTransaction.md)
 - [qan.OutputBlockNumber](docs/OutputBlockNumber.md)
 - [qan.OutputCall](docs/OutputCall.md)
 - [qan.OutputChainId](docs/OutputChainId.md)
 - [qan.OutputEstimateGas](docs/OutputEstimateGas.md)
 - [qan.OutputFeeHistory](docs/OutputFeeHistory.md)
 - [qan.OutputGasPrice](docs/OutputGasPrice.md)
 - [qan.OutputGetBalance](docs/OutputGetBalance.md)
 - [qan.OutputGetBlockByHash](docs/OutputGetBlockByHash.md)
 - [qan.OutputGetBlockByNumber](docs/OutputGetBlockByNumber.md)
 - [qan.OutputGetBlockReceipts](docs/OutputGetBlockReceipts.md)
 - [qan.OutputGetBlockTransactionCountByHash](docs/OutputGetBlockTransactionCountByHash.md)
 - [qan.OutputGetBlockTransactionCountByNumber](docs/OutputGetBlockTransactionCountByNumber.md)
 - [qan.OutputGetCode](docs/OutputGetCode.md)
 - [qan.OutputGetFilterChanges](docs/OutputGetFilterChanges.md)
 - [qan.OutputGetFilterLogs](docs/OutputGetFilterLogs.md)
 - [qan.OutputGetLogs](docs/OutputGetLogs.md)
 - [qan.OutputGetProof](docs/OutputGetProof.md)
 - [qan.OutputGetStorageAt](docs/OutputGetStorageAt.md)
 - [qan.OutputGetTransactionByBlockHashAndIndex](docs/OutputGetTransactionByBlockHashAndIndex.md)
 - [qan.OutputGetTransactionByBlockNumberAndIndex](docs/OutputGetTransactionByBlockNumberAndIndex.md)
 - [qan.OutputGetTransactionByHash](docs/OutputGetTransactionByHash.md)
 - [qan.OutputGetTransactionCount](docs/OutputGetTransactionCount.md)
 - [qan.OutputGetTransactionReceipt](docs/OutputGetTransactionReceipt.md)
 - [qan.OutputMaxPriorityFeePerGas](docs/OutputMaxPriorityFeePerGas.md)
 - [qan.OutputNewBlockFilter](docs/OutputNewBlockFilter.md)
 - [qan.OutputNewFilter](docs/OutputNewFilter.md)
 - [qan.OutputNewPendingTransactionFilter](docs/OutputNewPendingTransactionFilter.md)
 - [qan.OutputSendRawTransaction](docs/OutputSendRawTransaction.md)
 - [qan.OutputSyncing](docs/OutputSyncing.md)
 - [qan.OutputUninstallFilter](docs/OutputUninstallFilter.md)
 - [qan.OutputXlinkValid](docs/OutputXlinkValid.md)
 - [qan.ParamsTransaction](docs/ParamsTransaction.md)
 - [qan.ResponseBlock](docs/ResponseBlock.md)
 - [qan.ResponseLog](docs/ResponseLog.md)
 - [qan.ResponseStorageEntry](docs/ResponseStorageEntry.md)
 - [qan.ResponseTransaction](docs/ResponseTransaction.md)
 - [qan.ResponseTransactionReceipt](docs/ResponseTransactionReceipt.md)
 - [qan.ResponseWithdrawals](docs/ResponseWithdrawals.md)
 - [qan.SyncStatus](docs/SyncStatus.md)

## Acknowledgements

We would like to thank Smartbear and OpenAPITools tech for making building declarative APIs possible.
A huge benefit for the whole industry!
