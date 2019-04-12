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
  public class SaveTransactionsResponseData {
    /// <summary>
    /// The transaction ids that were saved
    /// </summary>
    /// <value>The transaction ids that were saved</value>
    [DataMember(Name="transaction_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_ids")]
    public List<string> TransactionIds { get; set; }

    /// <summary>
    /// If a single transaction was specified, the transaction that was saved
    /// </summary>
    /// <value>If a single transaction was specified, the transaction that was saved</value>
    [DataMember(Name="transaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction")]
    public TransactionDetail Transaction { get; set; }

    /// <summary>
    /// If multiple transactions were specified, the transactions that were saved
    /// </summary>
    /// <value>If multiple transactions were specified, the transactions that were saved</value>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public List<TransactionDetail> Transactions { get; set; }

    /// <summary>
    /// If multiple transactions were specified, a list of import_ids that were not were created because of an existing import_id found on the same account
    /// </summary>
    /// <value>If multiple transactions were specified, a list of import_ids that were not were created because of an existing import_id found on the same account</value>
    [DataMember(Name="duplicate_import_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duplicate_import_ids")]
    public List<string> DuplicateImportIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaveTransactionsResponseData {\n");
      sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
      sb.Append("  Transaction: ").Append(Transaction).Append("\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
