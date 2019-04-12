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
  public class SubTransaction {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets TransactionId
    /// </summary>
    [DataMember(Name="transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_id")]
    public Guid? TransactionId { get; set; }

    /// <summary>
    /// The subtransaction amount in milliunits format
    /// </summary>
    /// <value>The subtransaction amount in milliunits format</value>
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
    /// If a transfer, the account_id which the subtransaction transfers to
    /// </summary>
    /// <value>If a transfer, the account_id which the subtransaction transfers to</value>
    [DataMember(Name="transfer_account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transfer_account_id")]
    public Guid? TransferAccountId { get; set; }

    /// <summary>
    /// Whether or not the subtransaction has been deleted.  Deleted subtransactions will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the subtransaction has been deleted.  Deleted subtransactions will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubTransaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Memo: ").Append(Memo).Append("\n");
      sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  TransferAccountId: ").Append(TransferAccountId).Append("\n");
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
