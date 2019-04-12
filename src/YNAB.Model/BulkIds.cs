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
  public class BulkIds {
    /// <summary>
    /// The list of Transaction ids that were created.
    /// </summary>
    /// <value>The list of Transaction ids that were created.</value>
    [DataMember(Name="transaction_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_ids")]
    public List<string> TransactionIds { get; set; }

    /// <summary>
    /// If any Transactions were not created because they had an import_id matching a transaction already on the same account, the specified import_id(s) will be included in this list.
    /// </summary>
    /// <value>If any Transactions were not created because they had an import_id matching a transaction already on the same account, the specified import_id(s) will be included in this list.</value>
    [DataMember(Name="duplicate_import_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duplicate_import_ids")]
    public List<string> DuplicateImportIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BulkIds {\n");
      sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
      sb.Append("  DuplicateImportIds: ").Append(DuplicateImportIds).Append("\n");
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
