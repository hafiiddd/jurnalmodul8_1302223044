using System;
using System.Text.Json.Serialization;

public class banktransferConfig
{
    public string lang { get; set; }

    [JsonPropertyName("Transfer")]
    public transfer[] Transfer { get; set; }
    public string[] method { get; set; }
    [JsonPropertyName("confirmation")]
    public confirmation[] Confirmation { get; set; }

    public class transfer
    {
        [JsonPropertyName("treshold")]
        public int treshold { get; set; }
        [JsonPropertyName("low_fee")]
        public int low_fee { get; set; }
        [JsonPropertyName("high_fee")]
        public int high_fee { get; set; }
    }
    public class confirmation
    {
        [JsonPropertyName("en")]
        public string en { get; set; }
        [JsonPropertyName("id")]
        public string id{ get; set; }
      
    }

    public banktransferConfig()
	{

	}
}
