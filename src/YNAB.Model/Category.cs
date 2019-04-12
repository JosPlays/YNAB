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
  public class Category {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets CategoryGroupId
    /// </summary>
    [DataMember(Name="category_group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_group_id")]
    public Guid? CategoryGroupId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether or not the category is hidden
    /// </summary>
    /// <value>Whether or not the category is hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// If category is hidden this is the id of the category group it originally belonged to before it was hidden.
    /// </summary>
    /// <value>If category is hidden this is the id of the category group it originally belonged to before it was hidden.</value>
    [DataMember(Name="original_category_group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_category_group_id")]
    public Guid? OriginalCategoryGroupId { get; set; }

    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// Budgeted amount in milliunits format
    /// </summary>
    /// <value>Budgeted amount in milliunits format</value>
    [DataMember(Name="budgeted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "budgeted")]
    public int? Budgeted { get; set; }

    /// <summary>
    /// Activity amount in milliunits format
    /// </summary>
    /// <value>Activity amount in milliunits format</value>
    [DataMember(Name="activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity")]
    public int? Activity { get; set; }

    /// <summary>
    /// Balance in milliunits format
    /// </summary>
    /// <value>Balance in milliunits format</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public int? Balance { get; set; }

    /// <summary>
    /// The type of goal, if the cagegory has a goal (TB=Target Category Balance, TBD=Target Category Balance by Date, MF=Monthly Funding)
    /// </summary>
    /// <value>The type of goal, if the cagegory has a goal (TB=Target Category Balance, TBD=Target Category Balance by Date, MF=Monthly Funding)</value>
    [DataMember(Name="goal_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goal_type")]
    public string GoalType { get; set; }

    /// <summary>
    /// The month a goal was created
    /// </summary>
    /// <value>The month a goal was created</value>
    [DataMember(Name="goal_creation_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goal_creation_month")]
    public DateTime? GoalCreationMonth { get; set; }

    /// <summary>
    /// The goal target amount in milliunits
    /// </summary>
    /// <value>The goal target amount in milliunits</value>
    [DataMember(Name="goal_target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goal_target")]
    public int? GoalTarget { get; set; }

    /// <summary>
    /// If the goal type is 'TBD' (Target Category Balance by Date), this is the target month for the goal to be completed
    /// </summary>
    /// <value>If the goal type is 'TBD' (Target Category Balance by Date), this is the target month for the goal to be completed</value>
    [DataMember(Name="goal_target_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goal_target_month")]
    public DateTime? GoalTargetMonth { get; set; }

    /// <summary>
    /// The percentage completion of the goal
    /// </summary>
    /// <value>The percentage completion of the goal</value>
    [DataMember(Name="goal_percentage_complete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goal_percentage_complete")]
    public int? GoalPercentageComplete { get; set; }

    /// <summary>
    /// Whether or not the category has been deleted.  Deleted categories will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the category has been deleted.  Deleted categories will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Category {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CategoryGroupId: ").Append(CategoryGroupId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  OriginalCategoryGroupId: ").Append(OriginalCategoryGroupId).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Budgeted: ").Append(Budgeted).Append("\n");
      sb.Append("  Activity: ").Append(Activity).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  GoalType: ").Append(GoalType).Append("\n");
      sb.Append("  GoalCreationMonth: ").Append(GoalCreationMonth).Append("\n");
      sb.Append("  GoalTarget: ").Append(GoalTarget).Append("\n");
      sb.Append("  GoalTargetMonth: ").Append(GoalTargetMonth).Append("\n");
      sb.Append("  GoalPercentageComplete: ").Append(GoalPercentageComplete).Append("\n");
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
