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
  public class CurrencyFormat {
    /// <summary>
    /// Gets or Sets IsoCode
    /// </summary>
    [DataMember(Name="iso_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iso_code")]
    public string IsoCode { get; set; }

    /// <summary>
    /// Gets or Sets ExampleFormat
    /// </summary>
    [DataMember(Name="example_format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "example_format")]
    public string ExampleFormat { get; set; }

    /// <summary>
    /// Gets or Sets DecimalDigits
    /// </summary>
    [DataMember(Name="decimal_digits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decimal_digits")]
    public int? DecimalDigits { get; set; }

    /// <summary>
    /// Gets or Sets DecimalSeparator
    /// </summary>
    [DataMember(Name="decimal_separator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decimal_separator")]
    public string DecimalSeparator { get; set; }

    /// <summary>
    /// Gets or Sets SymbolFirst
    /// </summary>
    [DataMember(Name="symbol_first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "symbol_first")]
    public bool? SymbolFirst { get; set; }

    /// <summary>
    /// Gets or Sets GroupSeparator
    /// </summary>
    [DataMember(Name="group_separator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_separator")]
    public string GroupSeparator { get; set; }

    /// <summary>
    /// Gets or Sets CurrencySymbol
    /// </summary>
    [DataMember(Name="currency_symbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_symbol")]
    public string CurrencySymbol { get; set; }

    /// <summary>
    /// Gets or Sets DisplaySymbol
    /// </summary>
    [DataMember(Name="display_symbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_symbol")]
    public bool? DisplaySymbol { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CurrencyFormat {\n");
      sb.Append("  IsoCode: ").Append(IsoCode).Append("\n");
      sb.Append("  ExampleFormat: ").Append(ExampleFormat).Append("\n");
      sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append("\n");
      sb.Append("  DecimalSeparator: ").Append(DecimalSeparator).Append("\n");
      sb.Append("  SymbolFirst: ").Append(SymbolFirst).Append("\n");
      sb.Append("  GroupSeparator: ").Append(GroupSeparator).Append("\n");
      sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
      sb.Append("  DisplaySymbol: ").Append(DisplaySymbol).Append("\n");
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
