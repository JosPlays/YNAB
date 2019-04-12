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
  public class BudgetDetailWrapper {
    /// <summary>
    /// Gets or Sets Budget
    /// </summary>
    [DataMember(Name="budget", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "budget")]
    public BudgetDetail Budget { get; set; }

    /// <summary>
    /// The knowledge of the server
    /// </summary>
    /// <value>The knowledge of the server</value>
    [DataMember(Name="server_knowledge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "server_knowledge")]
    public int? ServerKnowledge { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BudgetDetailWrapper {\n");
      sb.Append("  Budget: ").Append(Budget).Append("\n");
      sb.Append("  ServerKnowledge: ").Append(ServerKnowledge).Append("\n");
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
