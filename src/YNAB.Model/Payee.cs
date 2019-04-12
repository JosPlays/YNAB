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
  public class Payee {
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
    /// If a transfer payee, the account_id to which this payee transfers to
    /// </summary>
    /// <value>If a transfer payee, the account_id to which this payee transfers to</value>
    [DataMember(Name="transfer_account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transfer_account_id")]
    public string TransferAccountId { get; set; }

    /// <summary>
    /// Whether or not the payee has been deleted.  Deleted payees will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the payee has been deleted.  Deleted payees will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Payee {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
