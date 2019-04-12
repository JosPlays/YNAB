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
  public class BudgetSettings {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BudgetSettings {\n");
      sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
      sb.Append("  CurrencyFormat: ").Append(CurrencyFormat).Append("\n");
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
