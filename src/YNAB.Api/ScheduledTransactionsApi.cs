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
    public interface IScheduledTransactionsApi
    {
        /// <summary>
        /// Single scheduled transaction Returns a single scheduled transaction
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <returns>ScheduledTransactionResponse</returns>
        ScheduledTransactionResponse GetScheduledTransactionById (Guid? budgetId, Guid? scheduledTransactionId);
        /// <summary>
        /// List scheduled transactions Returns all scheduled transactions
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <returns>ScheduledTransactionsResponse</returns>
        ScheduledTransactionsResponse GetScheduledTransactions (Guid? budgetId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScheduledTransactionsApi : IScheduledTransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ScheduledTransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScheduledTransactionsApi(String basePath)
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
        /// Single scheduled transaction Returns a single scheduled transaction
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param> 
        /// <returns>ScheduledTransactionResponse</returns>            
        public ScheduledTransactionResponse GetScheduledTransactionById (Guid? budgetId, Guid? scheduledTransactionId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetScheduledTransactionById");
            
            // verify the required parameter 'scheduledTransactionId' is set
            if (scheduledTransactionId == null) throw new ApiException(400, "Missing required parameter 'scheduledTransactionId' when calling GetScheduledTransactionById");
            
    
            var path = "/budgets/{budget_id}/scheduled_transactions/{scheduled_transaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "scheduled_transaction_id" + "}", ApiClient.ParameterToString(scheduledTransactionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetScheduledTransactionById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetScheduledTransactionById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ScheduledTransactionResponse) ApiClient.Deserialize(response.Content, typeof(ScheduledTransactionResponse), response.Headers);
        }
    
        /// <summary>
        /// List scheduled transactions Returns all scheduled transactions
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <returns>ScheduledTransactionsResponse</returns>            
        public ScheduledTransactionsResponse GetScheduledTransactions (Guid? budgetId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetScheduledTransactions");
            
    
            var path = "/budgets/{budget_id}/scheduled_transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetScheduledTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetScheduledTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ScheduledTransactionsResponse) ApiClient.Deserialize(response.Content, typeof(ScheduledTransactionsResponse), response.Headers);
        }
    
    }
}
