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
    public interface ICategoriesApi
    {
        /// <summary>
        /// List categories Returns all categories grouped by category group.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <returns>CategoriesResponse</returns>
        CategoriesResponse GetCategories (Guid? budgetId);
        /// <summary>
        /// Single category Returns a single category.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>CategoryResponse</returns>
        CategoryResponse GetCategoryById (Guid? budgetId, Guid? categoryId);
        /// <summary>
        /// Single category for a specific budget month Returns a single category for a specific budget month.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-30) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <param name="categoryId">The id of the category</param>
        /// <returns>CategoryResponse</returns>
        CategoryResponse GetMonthCategoryById (Guid? budgetId, DateTime? month, Guid? categoryId);
        /// <summary>
        /// Update an existing month category Update an existing month category
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-30) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <param name="categoryId">The id of the category</param>
        /// <param name="monthCategory">The month category to update</param>
        /// <returns>CategoryResponse</returns>
        CategoryResponse UpdateMonthCategory (Guid? budgetId, DateTime? month, Guid? categoryId, SaveMonthCategoryWrapper monthCategory);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CategoriesApi : ICategoriesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CategoriesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CategoriesApi(String basePath)
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
        /// List categories Returns all categories grouped by category group.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <returns>CategoriesResponse</returns>            
        public CategoriesResponse GetCategories (Guid? budgetId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetCategories");
            
    
            var path = "/budgets/{budget_id}/categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CategoriesResponse) ApiClient.Deserialize(response.Content, typeof(CategoriesResponse), response.Headers);
        }
    
        /// <summary>
        /// Single category Returns a single category.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="categoryId">The id of the category</param> 
        /// <returns>CategoryResponse</returns>            
        public CategoryResponse GetCategoryById (Guid? budgetId, Guid? categoryId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetCategoryById");
            
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling GetCategoryById");
            
    
            var path = "/budgets/{budget_id}/categories/{category_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "category_id" + "}", ApiClient.ParameterToString(categoryId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCategoryById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCategoryById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CategoryResponse) ApiClient.Deserialize(response.Content, typeof(CategoryResponse), response.Headers);
        }
    
        /// <summary>
        /// Single category for a specific budget month Returns a single category for a specific budget month.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-30) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param> 
        /// <param name="categoryId">The id of the category</param> 
        /// <returns>CategoryResponse</returns>            
        public CategoryResponse GetMonthCategoryById (Guid? budgetId, DateTime? month, Guid? categoryId)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling GetMonthCategoryById");
            
            // verify the required parameter 'month' is set
            if (month == null) throw new ApiException(400, "Missing required parameter 'month' when calling GetMonthCategoryById");
            
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling GetMonthCategoryById");
            
    
            var path = "/budgets/{budget_id}/months/{month}/categories/{category_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "month" + "}", ApiClient.ParameterToString(month));
path = path.Replace("{" + "category_id" + "}", ApiClient.ParameterToString(categoryId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMonthCategoryById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMonthCategoryById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CategoryResponse) ApiClient.Deserialize(response.Content, typeof(CategoryResponse), response.Headers);
        }
    
        /// <summary>
        /// Update an existing month category Update an existing month category
        /// </summary>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can also be used to specify the last used budget)</param> 
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-30) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param> 
        /// <param name="categoryId">The id of the category</param> 
        /// <param name="monthCategory">The month category to update</param> 
        /// <returns>CategoryResponse</returns>            
        public CategoryResponse UpdateMonthCategory (Guid? budgetId, DateTime? month, Guid? categoryId, SaveMonthCategoryWrapper monthCategory)
        {
            
            // verify the required parameter 'budgetId' is set
            if (budgetId == null) throw new ApiException(400, "Missing required parameter 'budgetId' when calling UpdateMonthCategory");
            
            // verify the required parameter 'month' is set
            if (month == null) throw new ApiException(400, "Missing required parameter 'month' when calling UpdateMonthCategory");
            
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling UpdateMonthCategory");
            
            // verify the required parameter 'monthCategory' is set
            if (monthCategory == null) throw new ApiException(400, "Missing required parameter 'monthCategory' when calling UpdateMonthCategory");
            
    
            var path = "/budgets/{budget_id}/months/{month}/categories/{category_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "budget_id" + "}", ApiClient.ParameterToString(budgetId));
path = path.Replace("{" + "month" + "}", ApiClient.ParameterToString(month));
path = path.Replace("{" + "category_id" + "}", ApiClient.ParameterToString(categoryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(monthCategory); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMonthCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMonthCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CategoryResponse) ApiClient.Deserialize(response.Content, typeof(CategoryResponse), response.Headers);
        }
    
    }
}
