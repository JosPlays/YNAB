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
  public class ScheduledTransactionWrapper {
    /// <summary>
    /// Gets or Sets ScheduledTransaction
    /// </summary>
    [DataMember(Name="scheduled_transaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduled_transaction")]
    public ScheduledTransactionDetail ScheduledTransaction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduledTransactionWrapper {\n");
      sb.Append("  ScheduledTransaction: ").Append(ScheduledTransaction).Append("\n");
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
