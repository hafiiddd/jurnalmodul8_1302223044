using System;
using System.Text.Json;

public class uibankconfig
{
	public banktransferConfig config;
	public const string filepath = "\\C:\\Kuliah\\kpl\\jurnalmodul8_1302223044\\jurnalmodul8_1302223044\\bank_transfer_config.json\\";
	public uibankconfig()
	{
        
    }
    public void SetDefault()
    {
       
        int Treshold = 25000000;
        int low_fee = 6500;
        int high_fee = 15000;
        string[] method = ["RTO(real-time)","SKN","RTGS","BI FAST"];
        string en = "yes";
        string id = "ya";

    }
    public banktransferConfig ReadJSON()
    {
        string jsonData = File.ReadAllText(filepath);
        config = JsonSerializer.Deserialize<banktransferConfig>(jsonData);
        return config;
    }
    public void writeJSON()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        string jsonString = JsonSerializer.Serialize(config, options);
        File.WriteAllText(filepath, jsonString);
    }
}
