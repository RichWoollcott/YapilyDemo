using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentResponses {
    /// <summary>
    /// Gets or Sets Payments
    /// </summary>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public List<PaymentResponse> Payments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentResponses {\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
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
