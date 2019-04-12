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
  public class ScheduledTransactionDetail {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// The first date for which the Scheduled Transaction was scheduled.
    /// </summary>
    /// <value>The first date for which the Scheduled Transaction was scheduled.</value>
    [DataMember(Name="date_first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_first")]
    public DateTime? DateFirst { get; set; }

    /// <summary>
    /// The next date for which the Scheduled Transaction is scheduled.
    /// </summary>
    /// <value>The next date for which the Scheduled Transaction is scheduled.</value>
    [DataMember(Name="date_next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_next")]
    public DateTime? DateNext { get; set; }

    /// <summary>
    /// Gets or Sets Frequency
    /// </summary>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public string Frequency { get; set; }

    /// <summary>
    /// The scheduled transaction amount in milliunits format
    /// </summary>
    /// <value>The scheduled transaction amount in milliunits format</value>
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
    /// The scheduled transaction flag
    /// </summary>
    /// <value>The scheduled transaction flag</value>
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
    /// If a transfer, the account_id which the scheduled transaction transfers to
    /// </summary>
    /// <value>If a transfer, the account_id which the scheduled transaction transfers to</value>
    [DataMember(Name="transfer_account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transfer_account_id")]
    public Guid? TransferAccountId { get; set; }

    /// <summary>
    /// Whether or not the scheduled transaction has been deleted.  Deleted scheduled transactions will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the scheduled transaction has been deleted.  Deleted scheduled transactions will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// Gets or Sets AccountName
    /// </summary>
    [DataMember(Name="account_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_name")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or Sets PayeeName
    /// </summary>
    [DataMember(Name="payee_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee_name")]
    public string PayeeName { get; set; }

    /// <summary>
    /// Gets or Sets CategoryName
    /// </summary>
    [DataMember(Name="category_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_name")]
    public string CategoryName { get; set; }

    /// <summary>
    /// If a split scheduled transaction, the subtransactions.
    /// </summary>
    /// <value>If a split scheduled transaction, the subtransactions.</value>
    [DataMember(Name="subtransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtransactions")]
    public List<ScheduledSubTransaction> Subtransactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduledTransactionDetail {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DateFirst: ").Append(DateFirst).Append("\n");
      sb.Append("  DateNext: ").Append(DateNext).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  FlagColor: ").Append(FlagColor).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  TransferAccountId: ").Append(TransferAccountId).Append("\n");
      sb.Append("  Deleted: ").Append(Deleted).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
      sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
      sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
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
