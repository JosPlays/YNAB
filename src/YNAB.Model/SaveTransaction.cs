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
  public class SaveTransaction {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_id")]
    public Guid? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// The transaction amount in milliunits format
    /// </summary>
    /// <value>The transaction amount in milliunits format</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// The payee for the transaction
    /// </summary>
    /// <value>The payee for the transaction</value>
    [DataMember(Name="payee_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee_id")]
    public Guid? PayeeId { get; set; }

    /// <summary>
    /// The payee name.  If a payee_name value is provided and payee_id has a null value, the payee_name value will be used to resolve the payee by either (1) a matching payee rename rule (only if import_id is also specified) or (2) a payee with the same name or (3) creation of a new payee.
    /// </summary>
    /// <value>The payee name.  If a payee_name value is provided and payee_id has a null value, the payee_name value will be used to resolve the payee by either (1) a matching payee rename rule (only if import_id is also specified) or (2) a payee with the same name or (3) creation of a new payee.</value>
    [DataMember(Name="payee_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee_name")]
    public string PayeeName { get; set; }

    /// <summary>
    /// The category for the transaction.  Split and Credit Card Payment categories are not permitted and will be ignored if supplied.  If an existing transaction has a Split category it cannot be changed.
    /// </summary>
    /// <value>The category for the transaction.  Split and Credit Card Payment categories are not permitted and will be ignored if supplied.  If an existing transaction has a Split category it cannot be changed.</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// Gets or Sets Memo
    /// </summary>
    [DataMember(Name="memo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memo")]
    public string Memo { get; set; }

    /// <summary>
    /// The cleared status of the transaction
    /// </summary>
    /// <value>The cleared status of the transaction</value>
    [DataMember(Name="cleared", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleared")]
    public string Cleared { get; set; }

    /// <summary>
    /// Whether or not the transaction is approved.  If not supplied, transaction will be unapproved by default.
    /// </summary>
    /// <value>Whether or not the transaction is approved.  If not supplied, transaction will be unapproved by default.</value>
    [DataMember(Name="approved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approved")]
    public bool? Approved { get; set; }

    /// <summary>
    /// The transaction flag
    /// </summary>
    /// <value>The transaction flag</value>
    [DataMember(Name="flag_color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flag_color")]
    public string FlagColor { get; set; }

    /// <summary>
    /// If specified for a new transaction, the transaction will be treated as Imported and assigned this import_id.  If another transaction on the same account with this same import_id is later attempted to be created, it will be skipped to prevent duplication.  Transactions imported through File Based Import or Direct Import and not through the API, are assigned an import_id in the format: 'YNAB:[milliunit_amount]:[iso_date]:[occurrence]'.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of 'YNAB:-294230:2015-12-30:1'.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be 'YNAB:-294230:2015-12-30:2'.  Using a consistent format will prevent duplicates through Direct Import and File Based Import.  If import_id is specified as null, the transaction will be treated as a user entered transaction.
    /// </summary>
    /// <value>If specified for a new transaction, the transaction will be treated as Imported and assigned this import_id.  If another transaction on the same account with this same import_id is later attempted to be created, it will be skipped to prevent duplication.  Transactions imported through File Based Import or Direct Import and not through the API, are assigned an import_id in the format: 'YNAB:[milliunit_amount]:[iso_date]:[occurrence]'.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of 'YNAB:-294230:2015-12-30:1'.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be 'YNAB:-294230:2015-12-30:2'.  Using a consistent format will prevent duplicates through Direct Import and File Based Import.  If import_id is specified as null, the transaction will be treated as a user entered transaction.</value>
    [DataMember(Name="import_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "import_id")]
    public string ImportId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaveTransaction {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
      sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  Cleared: ").Append(Cleared).Append("\n");
      sb.Append("  Approved: ").Append(Approved).Append("\n");
      sb.Append("  FlagColor: ").Append(FlagColor).Append("\n");
      sb.Append("  ImportId: ").Append(ImportId).Append("\n");
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
