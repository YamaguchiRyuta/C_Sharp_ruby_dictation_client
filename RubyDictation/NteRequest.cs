using Newtonsoft.Json;

[JsonObject("NteRequest")]
class NteRequest
{
    [JsonProperty("job_type")]
    public string JobType { get; set; }

    [JsonProperty("operating_mode")]
    public string OperatingMode { get; set; }

    [JsonProperty("callback_url")]
    public string CallbackUrl { get; set; }

    [JsonProperty("model")]
    public Model Model { get; set; }

    [JsonProperty("channels")]
    public ChannelsReq Channels { get; set; }
}


[JsonObject("Model")]
class Model
{
    [JsonProperty("name")]
    public string Name { get; set; }
}

[JsonObject("Channels")]
class ChannelsReq
{
    [JsonProperty("firstChannelLabel")]
    public FirstChannelLabelReq FirstChannelLabel { get; set; }
}

[JsonObject("FirstChannelLabel")]
class FirstChannelLabelReq
{
    [JsonProperty("result_format")]
    public string ResultFormat { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("diarize")]
    public bool Diarize { get; set; }
}
