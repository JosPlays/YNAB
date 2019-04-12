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
  public class SaveMonthCategory {
    /// <summary>
    /// Budgeted amount in milliunits format
    /// </summary>
    /// <value>Budgeted amount in milliunits format</value>
    [DataMember(Name="budgeted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "budgeted")]
    public int? Budgeted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaveMonthCategory {\n");
      sb.Append("  Budgeted: ").Append(Budgeted).Append("\n");
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
