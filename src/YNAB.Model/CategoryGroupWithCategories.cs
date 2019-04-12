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
  public class CategoryGroupWithCategories {
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
    /// Whether or not the category group is hidden
    /// </summary>
    /// <value>Whether or not the category group is hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Whether or not the category group has been deleted.  Deleted category groups will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the category group has been deleted.  Deleted category groups will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// Category group categories.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
    /// </summary>
    /// <value>Category group categories.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<Category> Categories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoryGroupWithCategories {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
