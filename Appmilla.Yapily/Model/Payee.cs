using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Payee {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or Sets AccountIdentifications
    /// </summary>
    [DataMember(Name="accountIdentifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountIdentifications")]
    public List<AccountIdentification> AccountIdentifications { get; set; }

    /// <summary>
    /// Gets or Sets MerchantId
    /// </summary>
    [DataMember(Name="merchantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantId")]
    public string MerchantId { get; set; }

    /// <summary>
    /// Gets or Sets MerchantCategoryCode
    /// </summary>
    [DataMember(Name="merchantCategoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantCategoryCode")]
    public string MerchantCategoryCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Payee {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  AccountIdentifications: ").Append(AccountIdentifications).Append("\n");
      sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
      sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
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
