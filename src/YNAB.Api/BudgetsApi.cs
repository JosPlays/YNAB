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
    public interface IBudgetsApi
    {
        /// <summary>
        /// Single budget Returns a single budget with all related entities.  This resource is effectively a full budget export.
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included.</param>
        /// <returns>BudgetDetailResponse</returns>
        BudgetDetailResponse GetBudgetById (Guid? budgetId, int? lastKnowledgeOfServer);
        /// <summary>
        /// Budget Settings Returns settings for a budget
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <returns>BudgetSettingsResponse</returns>
        BudgetSettingsResponse GetBudgetSettingsById (Guid? budgetId);
        /// <summary>
        /// List budgets Returns budgets list with summary information
        /// </summary>
        /// <returns>BudgetSummaryResponse</returns>
        BudgetSummaryResponse GetBudgets ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BudgetsApi : IBudgetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BudgetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BudgetsApi(String basePath)
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
        /// Single budget Returns a single budget with all related entities.  This resource is effectively a full budget export.
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included.</param> 
        /// <returns>BudgetDetailResponse</returns>            
        public BudgetDetailResponse GetBudgetById (Guid? budgetId, int? lastKnowledgeOfServer)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetBudgetById");
            
    
            var path = "/budgets/{budget_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastKnowledgeOfServer != null) queryParams.Add("last_knowledge_of_server", ApiClient.ParameterToString(lastKnowledgeOfServer)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BudgetDetailResponse) ApiClient.Deserialize(response.Content, typeof(BudgetDetailResponse), response.Headers);
        }
    
        /// <summary>
        /// Budget Settings Returns settings for a budget
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <returns>BudgetSettingsResponse</returns>            
        public BudgetSettingsResponse GetBudgetSettingsById (Guid? budgetId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetBudgetSettingsById");
            
    
            var path = "/budgets/{budget_id}/settings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetSettingsById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetSettingsById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BudgetSettingsResponse) ApiClient.Deserialize(response.Content, typeof(BudgetSettingsResponse), response.Headers);
        }
    
        /// <summary>
        /// List budgets Returns budgets list with summary information
        /// </summary>
        /// <returns>BudgetSummaryResponse</returns>            
        public BudgetSummaryResponse GetBudgets ()
        {
            
    
            var path = "/budgets";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BudgetSummaryResponse) ApiClient.Deserialize(response.Content, typeof(BudgetSummaryResponse), response.Headers);
        }
    
    }
}
