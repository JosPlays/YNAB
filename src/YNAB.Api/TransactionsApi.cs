using System;
using System.Collections.Generic;
using RestSharp;
using YNAB.Client;
using YNAB.Model;

namespace YNAB.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionsApi
    {
        /// <summary>
        /// Create a single transaction or multiple transactions Creates a single transaction or multiple transactions.  If you provide a body containing a &#39;transaction&#39; object, a single transaction will be created and if you provide a body containing a &#39;transactions&#39; array, multiple transactions will be created.
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="saveTransactions">The transaction or transactions to create</param>
        /// <returns>SaveTransactionsResponse</returns>
        SaveTransactionsResponse CreateTransaction (Guid? budgetId, SaveTransactionsWrapper saveTransactions);
        /// <summary>
        /// Single transaction Returns a single transaction
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="transactionId">The id of the transaction</param>
        /// <returns>TransactionResponse</returns>
        TransactionResponse GetTransactionById (Guid? budgetId, Guid? transactionId);
        /// <summary>
        /// List transactions Returns budget transactions
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="sinceDate">Only return transactions on or after this date</param>
        /// <param name="type">Only return transactions of a certain type (&#39;uncategorized&#39; and &#39;unapproved&#39; are currently supported)</param>
        /// <returns>TransactionsResponse</returns>
        TransactionsResponse GetTransactions (Guid? budgetId, DateTime? sinceDate, string type);
        /// <summary>
        /// List account transactions Returns all transactions for a specified account
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="accountId">The id of the account</param>
        /// <param name="sinceDate">Only return transactions on or after this date</param>
        /// <param name="type">Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;)</param>
        /// <returns>TransactionsResponse</returns>
        TransactionsResponse GetTransactionsByAccount (Guid? budgetId, Guid? accountId, DateTime? sinceDate, string type);
        /// <summary>
        /// List category transactions Returns all transactions for a specified category
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="sinceDate">Only return transactions on or after this date</param>
        /// <param name="type">Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;)</param>
        /// <returns>HybridTransactionsResponse</returns>
        HybridTransactionsResponse GetTransactionsByCategory (Guid? budgetId, Guid? categoryId, DateTime? sinceDate, string type);
        /// <summary>
        /// List payee transactions Returns all transactions for a specified payee
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <param name="sinceDate">Only return transactions on or after this date</param>
        /// <param name="type">Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;)</param>
        /// <returns>HybridTransactionsResponse</returns>
        HybridTransactionsResponse GetTransactionsByPayee (Guid? budgetId, Guid? payeeId, DateTime? sinceDate, string type);
        /// <summary>
        /// Updates an existing transaction Updates a transaction
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="transactionId">The id of the transaction</param>
        /// <param name="transaction">The transaction to update</param>
        /// <returns>TransactionResponse</returns>
        TransactionResponse UpdateTransaction (Guid? budgetId, Guid? transactionId, SaveTransactionWrapper transaction);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionsApi : ITransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Create a single transaction or multiple transactions Creates a single transaction or multiple transactions.  If you provide a body containing a &#39;transaction&#39; object, a single transaction will be created and if you provide a body containing a &#39;transactions&#39; array, multiple transactions will be created.
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="saveTransactions">The transaction or transactions to create</param> 
        /// <returns>SaveTransactionsResponse</returns>            
        public SaveTransactionsResponse CreateTransaction (Guid? budgetId, SaveTransactionsWrapper saveTransactions)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling CreateTransaction");
            
            // verify the required parameter 'saveTransactions' is set
            if (saveTransactions == null) throw new ApiException(400, "Missing required parameter 'saveTransactions' when calling CreateTransaction");
            
    
            var path = "/budgets/{budget_id}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(saveTransactions); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SaveTransactionsResponse) ApiClient.Deserialize(response.Content, typeof(SaveTransactionsResponse), response.Headers);
        }
    
        /// <summary>
        /// Single transaction Returns a single transaction
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="transactionId">The id of the transaction</param> 
        /// <returns>TransactionResponse</returns>            
        public TransactionResponse GetTransactionById (Guid? budgetId, Guid? transactionId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetTransactionById");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling GetTransactionById");
            
    
            var path = "/budgets/{budget_id}/transactions/{transaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "transaction_id" + "}", ApiClient.ParameterToString(transactionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionResponse) ApiClient.Deserialize(response.Content, typeof(TransactionResponse), response.Headers);
        }
    
        /// <summary>
        /// List transactions Returns budget transactions
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="sinceDate">Only return transactions on or after this date</param> 
        /// <param name="type">Only return transactions of a certain type (&#39;uncategorized&#39; and &#39;unapproved&#39; are currently supported)</param> 
        /// <returns>TransactionsResponse</returns>            
        public TransactionsResponse GetTransactions (Guid? budgetId, DateTime? sinceDate, string type)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetTransactions");
            
    
            var path = "/budgets/{budget_id}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sinceDate != null) queryParams.Add("since_date", ApiClient.ParameterToString(sinceDate)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionsResponse) ApiClient.Deserialize(response.Content, typeof(TransactionsResponse), response.Headers);
        }
    
        /// <summary>
        /// List account transactions Returns all transactions for a specified account
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="accountId">The id of the account</param> 
        /// <param name="sinceDate">Only return transactions on or after this date</param> 
        /// <param name="type">Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;)</param> 
        /// <returns>TransactionsResponse</returns>            
        public TransactionsResponse GetTransactionsByAccount (Guid? budgetId, Guid? accountId, DateTime? sinceDate, string type)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetTransactionsByAccount");
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetTransactionsByAccount");
            
    
            var path = "/budgets/{budget_id}/accounts/{account_id}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sinceDate != null) queryParams.Add("since_date", ApiClient.ParameterToString(sinceDate)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsByAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsByAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionsResponse) ApiClient.Deserialize(response.Content, typeof(TransactionsResponse), response.Headers);
        }
    
        /// <summary>
        /// List category transactions Returns all transactions for a specified category
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="categoryId">The id of the category</param> 
        /// <param name="sinceDate">Only return transactions on or after this date</param> 
        /// <param name="type">Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;)</param> 
        /// <returns>HybridTransactionsResponse</returns>            
        public HybridTransactionsResponse GetTransactionsByCategory (Guid? budgetId, Guid? categoryId, DateTime? sinceDate, string type)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetTransactionsByCategory");
            
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling GetTransactionsByCategory");
            
    
            var path = "/budgets/{budget_id}/categories/{category_id}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "category_id" + "}", ApiClient.ParameterToString(categoryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sinceDate != null) queryParams.Add("since_date", ApiClient.ParameterToString(sinceDate)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsByCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsByCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HybridTransactionsResponse) ApiClient.Deserialize(response.Content, typeof(HybridTransactionsResponse), response.Headers);
        }
    
        /// <summary>
        /// List payee transactions Returns all transactions for a specified payee
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="payeeId">The id of the payee</param> 
        /// <param name="sinceDate">Only return transactions on or after this date</param> 
        /// <param name="type">Only return transactions of a certain type (i.e. &#39;uncategorized&#39;, &#39;unapproved&#39;)</param> 
        /// <returns>HybridTransactionsResponse</returns>            
        public HybridTransactionsResponse GetTransactionsByPayee (Guid? budgetId, Guid? payeeId, DateTime? sinceDate, string type)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetTransactionsByPayee");
            
            // verify the required parameter 'payeeId' is set
            if (payeeId == null) throw new ApiException(400, "Missing required parameter 'payeeId' when calling GetTransactionsByPayee");
            
    
            var path = "/budgets/{budget_id}/payees/{payee_id}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "payee_id" + "}", ApiClient.ParameterToString(payeeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sinceDate != null) queryParams.Add("since_date", ApiClient.ParameterToString(sinceDate)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsByPayee: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsByPayee: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HybridTransactionsResponse) ApiClient.Deserialize(response.Content, typeof(HybridTransactionsResponse), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing transaction Updates a transaction
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="transactionId">The id of the transaction</param> 
        /// <param name="transaction">The transaction to update</param> 
        /// <returns>TransactionResponse</returns>            
        public TransactionResponse UpdateTransaction (Guid? budgetId, Guid? transactionId, SaveTransactionWrapper transaction)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling UpdateTransaction");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling UpdateTransaction");
            
            // verify the required parameter 'transaction' is set
            if (transaction == null) throw new ApiException(400, "Missing required parameter 'transaction' when calling UpdateTransaction");
            
    
            var path = "/budgets/{budget_id}/transactions/{transaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "transaction_id" + "}", ApiClient.ParameterToString(transactionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(transaction); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionResponse) ApiClient.Deserialize(response.Content, typeof(TransactionResponse), response.Headers);
        }
    
    }
}
