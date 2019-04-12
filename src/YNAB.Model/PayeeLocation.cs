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
  public class PayeeLocation {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets PayeeId
    /// </summary>
    [DataMember(Name="payee_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee_id")]
    public Guid? PayeeId { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public string Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public string Longitude { get; set; }

    /// <summary>
    /// Whether or not the payee location has been deleted.  Deleted payee locations will only be included in delta requests.
    /// </summary>
    /// <value>Whether or not the payee location has been deleted.  Deleted payee locations will only be included in delta requests.</value>
    [DataMember(Name="deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PayeeLocation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
