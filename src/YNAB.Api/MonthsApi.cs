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
    public interface IMonthsApi
    {
        /// <summary>
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-30) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>MonthDetailResponse</returns>
        MonthDetailResponse GetBudgetMonth (Guid? budgetId, DateTime? month);
        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <returns>MonthSummariesResponse</returns>
        MonthSummariesResponse GetBudgetMonths (Guid? budgetId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MonthsApi : IMonthsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MonthsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MonthsApi(String basePath)
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
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-30) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param> 
        /// <returns>MonthDetailResponse</returns>            
        public MonthDetailResponse GetBudgetMonth (Guid? budgetId, DateTime? month)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetBudgetMonth");
            
            // verify the required parameter 'month' is set
            if (month == null) throw new ApiException(400, "Missing required parameter 'month' when calling GetBudgetMonth");
            
    
            var path = "/budgets/{budget_id}/months/{month}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "month" + "}", ApiClient.ParameterToString(month));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetMonth: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetMonth: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MonthDetailResponse) ApiClient.Deserialize(response.Content, typeof(MonthDetailResponse), response.Headers);
        }
    
        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <returns>MonthSummariesResponse</returns>            
        public MonthSummariesResponse GetBudgetMonths (Guid? budgetId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetBudgetMonths");
            
    
            var path = "/budgets/{budget_id}/months";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetMonths: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBudgetMonths: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MonthSummariesResponse) ApiClient.Deserialize(response.Content, typeof(MonthSummariesResponse), response.Headers);
        }
    
    }
}
