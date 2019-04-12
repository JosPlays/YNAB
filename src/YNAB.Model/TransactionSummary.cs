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
  public class TransactionSummary {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

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
    /// Whether or not the transaction is approved
    /// </summary>
    /// <value>Whether or not the transaction is approved</value>
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
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_id")]
    public Guid? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets PayeeId
    /// </summary>
    [DataMember(Name="payee_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee_id")]
    public Guid? PayeeId { get; set; }

    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// If a transfer transaction, the account to which it transfers
    /// </summary>
    /// <value>If a transfer transaction, the account to which it transfers</value>
    [DataMember(Name="transfer_account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transfer_account_id")]
    public Guid? TransferAccountId { get; set; }

    /// <summary>
    /// If a transfer transaction, the id of transaction on the other side of the transfer
    /// </summary>
    /// <value>If a transfer transaction, the id of transaction on the other side of the transfer</value>
    [DataMember(Name="transfer_transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transfer_transaction_id")]
    public Guid? TransferTransactionId { get; set; }

    /// <summary>
    /// If the Transaction was imported, this field is a unique (by account) import identifier.  If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: 'YNAB:[milliunit_amount]:[iso_date]:[occurrence]'.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of 'YNAB:-294230:2015-12-30:1'.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be 'YNAB:-294230:2015-12-30:2'.
    /// </summary>
    /// <value>If the Transaction was imported, this field is a unique (by account) import identifier.  If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: 'YNAB:[milliunit_amount]:[iso_date]:[occurrence]'.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of 'YNAB:-294230:2015-12-30:1'.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be 'YNAB:-294230:2015-12-30:2'.</value>
    [DataMember(Name="import_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "import_id")]
    public string ImportId { get; set; }

    /// <summary>
    /// Whether or not the transaction has been deleted.  Deleted transactions will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the transaction has been deleted.  Deleted transactions will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionSummary {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  Cleared: ").Append(Cleared).Append("\n");
      sb.Append("  Approved: ").Append(Approved).Append("\n");
      sb.Append("  FlagColor: ").Append(FlagColor).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  TransferAccountId: ").Append(TransferAccountId).Append("\n");
      sb.Append("  TransferTransactionId: ").Append(TransferTransactionId).Append("\n");
      sb.Append("  ImportId: ").Append(ImportId).Append("\n");
      sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
