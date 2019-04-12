using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace YNAB.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Account {
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
    /// The type of account. Note: payPal, merchantAccount, investmentAccount, and mortgage types have been deprecated and will be removed in the future.
    /// </summary>
    /// <value>The type of account. Note: payPal, merchantAccount, investmentAccount, and mortgage types have been deprecated and will be removed in the future.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Whether this account is on budget or not
    /// </summary>
    /// <value>Whether this account is on budget or not</value>
    [DataMember(Name="on_budget", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on_budget")]
    public bool? OnBudget { get; set; }

    /// <summary>
    /// Whether this account is closed or not
    /// </summary>
    /// <value>Whether this account is closed or not</value>
    [DataMember(Name="closed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed")]
    public bool? Closed { get; set; }

    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// The current balance of the account in milliunits format
    /// </summary>
    /// <value>The current balance of the account in milliunits format</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public int? Balance { get; set; }

    /// <summary>
    /// The current cleared balance of the account in milliunits format
    /// </summary>
    /// <value>The current cleared balance of the account in milliunits format</value>
    [DataMember(Name="cleared_balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleared_balance")]
    public int? ClearedBalance { get; set; }

    /// <summary>
    /// The current uncleared balance of the account in milliunits format
    /// </summary>
    /// <value>The current uncleared balance of the account in milliunits format</value>
    [DataMember(Name="uncleared_balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uncleared_balance")]
    public int? UnclearedBalance { get; set; }

    /// <summary>
    /// The payee id which should be used when transferring to this account
    /// </summary>
    /// <value>The payee id which should be used when transferring to this account</value>
    [DataMember(Name="transfer_payee_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transfer_payee_id")]
    public Guid? TransferPayeeId { get; set; }

    /// <summary>
    /// Whether or not the account has been deleted.  Deleted accounts will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the account has been deleted.  Deleted accounts will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Account {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  OnBudget: ").Append(OnBudget).Append("\n");
      sb.Append("  Closed: ").Append(Closed).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  ClearedBalance: ").Append(ClearedBalance).Append("\n");
      sb.Append("  UnclearedBalance: ").Append(UnclearedBalance).Append("\n");
      sb.Append("  TransferPayeeId: ").Append(TransferPayeeId).Append("\n");
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
