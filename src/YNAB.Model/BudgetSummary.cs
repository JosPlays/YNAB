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
  public class BudgetSummary {
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
    /// The last time any changes were made to the budget from either a web or mobile client.
    /// </summary>
    /// <value>The last time any changes were made to the budget from either a web or mobile client.</value>
    [DataMember(Name="last_modified_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_modified_on")]
    public DateTime? LastModifiedOn { get; set; }

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
      sb.Append("class BudgetSummary {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append("\n");
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
