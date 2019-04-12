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
  public class MonthDetail {
    /// <summary>
    /// Gets or Sets Month
    /// </summary>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public DateTime? Month { get; set; }

    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// The total amount in transactions categorized to 'Inflow: To be Budgeted' in the month
    /// </summary>
    /// <value>The total amount in transactions categorized to 'Inflow: To be Budgeted' in the month</value>
    [DataMember(Name="income", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "income")]
    public int? Income { get; set; }

    /// <summary>
    /// The total amount budgeted in the month
    /// </summary>
    /// <value>The total amount budgeted in the month</value>
    [DataMember(Name="budgeted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "budgeted")]
    public int? Budgeted { get; set; }

    /// <summary>
    /// The total amount in transactions in the month, excluding those categorized to 'Inflow: To be Budgeted'
    /// </summary>
    /// <value>The total amount in transactions in the month, excluding those categorized to 'Inflow: To be Budgeted'</value>
    [DataMember(Name="activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity")]
    public int? Activity { get; set; }

    /// <summary>
    /// The available amount for 'To be Budgeted'
    /// </summary>
    /// <value>The available amount for 'To be Budgeted'</value>
    [DataMember(Name="to_be_budgeted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to_be_budgeted")]
    public int? ToBeBudgeted { get; set; }

    /// <summary>
    /// The Age of Money as of the month
    /// </summary>
    /// <value>The Age of Money as of the month</value>
    [DataMember(Name="age_of_money", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "age_of_money")]
    public int? AgeOfMoney { get; set; }

    /// <summary>
    /// The budget month categories.  Amounts (budgeted, activity, balance, etc.) are specific to the {month} parameter specified.
    /// </summary>
    /// <value>The budget month categories.  Amounts (budgeted, activity, balance, etc.) are specific to the {month} parameter specified.</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<Category> Categories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MonthDetail {\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Income: ").Append(Income).Append("\n");
      sb.Append("  Budgeted: ").Append(Budgeted).Append("\n");
      sb.Append("  Activity: ").Append(Activity).Append("\n");
      sb.Append("  ToBeBudgeted: ").Append(ToBeBudgeted).Append("\n");
      sb.Append("  AgeOfMoney: ").Append(AgeOfMoney).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
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
