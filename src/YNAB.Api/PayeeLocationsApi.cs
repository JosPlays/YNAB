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
    public interface IPayeeLocationsApi
    {
        /// <summary>
        /// Single payee location Returns a single payee location
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="payeeLocationId">id of payee location</param>
        /// <returns>PayeeLocationResponse</returns>
        PayeeLocationResponse GetPayeeLocationById (Guid? budgetId, Guid? payeeLocationId);
        /// <summary>
        /// List payee locations Returns all payee locations
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <returns>PayeeLocationsResponse</returns>
        PayeeLocationsResponse GetPayeeLocations (Guid? budgetId);
        /// <summary>
        /// List locations for a payee Returns all payee locations for the specified payee
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="payeeId">id of payee</param>
        /// <returns>PayeeLocationsResponse</returns>
        PayeeLocationsResponse GetPayeeLocationsByPayee (Guid? budgetId, Guid? payeeId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PayeeLocationsApi : IPayeeLocationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeLocationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PayeeLocationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeLocationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PayeeLocationsApi(String basePath)
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
        /// Single payee location Returns a single payee location
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="payeeLocationId">id of payee location</param> 
        /// <returns>PayeeLocationResponse</returns>            
        public PayeeLocationResponse GetPayeeLocationById (Guid? budgetId, Guid? payeeLocationId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetPayeeLocationById");
            
            // verify the required parameter 'payeeLocationId' is set
            if (payeeLocationId == null) throw new ApiException(400, "Missing required parameter 'payeeLocationId' when calling GetPayeeLocationById");
            
    
            var path = "/budgets/{budget_id}/payee_locations/{payee_location_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "payee_location_id" + "}", ApiClient.ParameterToString(payeeLocationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayeeLocationById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayeeLocationById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PayeeLocationResponse) ApiClient.Deserialize(response.Content, typeof(PayeeLocationResponse), response.Headers);
        }
    
        /// <summary>
        /// List payee locations Returns all payee locations
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <returns>PayeeLocationsResponse</returns>            
        public PayeeLocationsResponse GetPayeeLocations (Guid? budgetId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetPayeeLocations");
            
    
            var path = "/budgets/{budget_id}/payee_locations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayeeLocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayeeLocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PayeeLocationsResponse) ApiClient.Deserialize(response.Content, typeof(PayeeLocationsResponse), response.Headers);
        }
    
        /// <summary>
        /// List locations for a payee Returns all payee locations for the specified payee
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="payeeId">id of payee</param> 
        /// <returns>PayeeLocationsResponse</returns>            
        public PayeeLocationsResponse GetPayeeLocationsByPayee (Guid? budgetId, Guid? payeeId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetPayeeLocationsByPayee");
            
            // verify the required parameter 'payeeId' is set
            if (payeeId == null) throw new ApiException(400, "Missing required parameter 'payeeId' when calling GetPayeeLocationsByPayee");
            
    
            var path = "/budgets/{budget_id}/payees/{payee_id}/payee_locations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "payee_id" + "}", ApiClient.ParameterToString(payeeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayeeLocationsByPayee: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPayeeLocationsByPayee: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PayeeLocationsResponse) ApiClient.Deserialize(response.Content, typeof(PayeeLocationsResponse), response.Headers);
        }
    
    }
}
