using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace YNAB.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BudgetDetail {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The last time any changes were made to the budget from either a web or mobile client.
    /// </summary>
    /// <value>The last time any changes were made to the budget from either a web or mobile client.</value>
    [DataMember(Name="last_modified_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_modified_on")]
    public DateTime? LastModifiedOn { get; set; }

    /// <summary>
    /// Gets or Sets DateFormat
    /// </summary>
    [DataMember(Name="date_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_format")]
    public DateFormat DateFormat { get; set; }

    /// <summary>
    /// Gets or Sets CurrencyFormat
    /// </summary>
    [DataMember(Name="currency_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_format")]
    public CurrencyFormat CurrencyFormat { get; set; }

    /// <summary>
    /// Gets or Sets Accounts
    /// </summary>
    [DataMember(Name="accounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accounts")]
    public List<Account> Accounts { get; set; }

    /// <summary>
    /// Gets or Sets Payees
    /// </summary>
    [DataMember(Name="payees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payees")]
    public List<Payee> Payees { get; set; }

    /// <summary>
    /// Gets or Sets PayeeLocations
    /// </summary>
    [DataMember(Name="payee_locations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee_locations")]
    public List<PayeeLocation> PayeeLocations { get; set; }

    /// <summary>
    /// Gets or Sets CategoryGroups
    /// </summary>
    [DataMember(Name="category_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_groups")]
    public List<CategoryGroup> CategoryGroups { get; set; }

    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<Category> Categories { get; set; }

    /// <summary>
    /// Gets or Sets Months
    /// </summary>
    [DataMember(Name="months", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "months")]
    public List<MonthDetail> Months { get; set; }

    /// <summary>
    /// Gets or Sets Transactions
    /// </summary>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public List<TransactionSummary> Transactions { get; set; }

    /// <summary>
    /// Gets or Sets Subtransactions
    /// </summary>
    [DataMember(Name="subtransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtransactions")]
    public List<SubTransaction> Subtransactions { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledTransactions
    /// </summary>
    [DataMember(Name="scheduled_transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduled_transactions")]
    public List<ScheduledTransactionSummary> ScheduledTransactions { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledSubtransactions
    /// </summary>
    [DataMember(Name="scheduled_subtransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduled_subtransactions")]
    public List<ScheduledSubTransaction> ScheduledSubtransactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BudgetDetail {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append("\n");
      sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
      sb.Append("  CurrencyFormat: ").Append(CurrencyFormat).Append("\n");
      sb.Append("  Accounts: ").Append(Accounts).Append("\n");
      sb.Append("  Payees: ").Append(Payees).Append("\n");
      sb.Append("  PayeeLocations: ").Append(PayeeLocations).Append("\n");
      sb.Append("  CategoryGroups: ").Append(CategoryGroups).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  Months: ").Append(Months).Append("\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
      sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
      sb.Append("  ScheduledTransactions: ").Append(ScheduledTransactions).Append("\n");
      sb.Append("  ScheduledSubtransactions: ").Append(ScheduledSubtransactions).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
