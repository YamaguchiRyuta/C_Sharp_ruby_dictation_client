using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

[JsonObject("NteResponse")]
class NteResponse
{
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("reference")]
    public string Reference { get; set; }

    [JsonProperty("language_pack")]
    public string LanguagePack { get; set; }

    [JsonProperty("operating_mode")]
    public string OperatingMode { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("channels")]
    public ChannelsRes Channels { get; set; }

    [JsonProperty("statistics")]
    public Statistics2 Statistics2 { get; set; }

    // あとでしらべる
    [JsonProperty("errors")]
    public string[] Errors { get; set; }
}

[JsonObject("channels")]
class ChannelsRes
{
    [JsonProperty("firstChannelLabel")]
    public FirstChannelLabelRes FirstChannelLabel { get; set; }
}

[JsonObject("firstChannelLabel")]
class FirstChannelLabelRes
{
    [JsonProperty("errors")]
    public Error[] Errors { get; set; }

    [JsonProperty("statistics")]
    public Statistics1 Statistics { get; set; }

    [JsonProperty("transcript")]
    public Transcript[] Transcript { get; set; }

    [JsonProperty("lattice")]
    public Lattice Lattice { get; set; }
}

[JsonObject("transcript")]
class Transcript
{
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("speaker")]
    public string Speaker { get; set; }

    [JsonProperty("start")]
    public float Start { get; set; }

    [JsonProperty("end")]
    public float End { get; set; }

    [JsonProperty("alignment")]
    public Alignment[] Alignment { get; set; }
}

[JsonObject("Alignment")]
class Alignment{
    [JsonProperty("word")]
    public string Word { get; set; }

    [JsonProperty("start_time")]
    public float StartTime { get; set; }

    [JsonProperty("end_time")]
    public float EndTime { get; set; }

    [JsonProperty("lattice")]
    public int Lattice { get; set; }

    [JsonProperty("lattice_first_node")]
    public int LatticeFirstNode { get; set; }

    [JsonProperty("lattice_last_node")]
    public int LatticeLastNode { get; set; }

    [JsonProperty("lattice_links")]
    public int[] LatticeLinks { get; set; }

    [JsonProperty("confidence")]
    public float Confidence { get; set; }
}

[JsonObject("lattice")]
class Lattice {
    /*
    [JsonProperty("1")]
    public string One {get;set;}

    [JsonProperty("2")]
    public string Two { get; set; }
    */
}

[JsonObject("links")]
class Links
{

}

[JsonObject("LatticeData")]
class LatticeData
{
    [JsonProperty("source")]
    public int Source { get; set; }

    [JsonProperty("destination")]
    public int Destination { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }

    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("weight")]
    public int Weight { get; set; }

    [JsonProperty("word_confidence")]
    public int WordConfidence { get; set; }

    [JsonProperty("best_path")]
    public int BestPath { get; set; }

    [JsonProperty("speaker")]
    public int Speaker { get; set; }

    [JsonProperty("word")]
    public int Word { get; set; }

    [JsonProperty("intensity")]
    public int Intensity { get; set; }

    public static explicit operator LatticeData(KeyValuePair<string, JToken> v)
    {
        throw new NotImplementedException();
    }
}

[JsonObject("error")]
class Error
{
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("start_time")]
    public float StartTime { get; set; }

    [JsonProperty("end_time")]
    public float EndTime { get; set; }
}

[JsonObject("Statistics1")]
class Statistics1
{
    [JsonProperty("content_fetch_time")]
    public float ContentFetchTime { get; set; }

    [JsonProperty("audio_length")]
    public float AudioLength { get; set; }

    [JsonProperty("audio_channels")]
    public int AudioChannels { get; set; }

    [JsonProperty("audio_analysis_time")]
    public float AudioAnalysisTime { get; set; }

    [JsonProperty("segmentation_time")]
    public float SegmentationTime { get; set; }

    [JsonProperty("transcription_time")]
    public float TranscriptionTime { get; set; }

    [JsonProperty("diarization_time")]
    public float DiarizationTime { get; set; }

    [JsonProperty("music_detection_time")]
    public float MusicDetectionTime { get; set; }

    [JsonProperty("merge_time")]
    public float MergeTime { get; set; }

    [JsonProperty("formatting_time")]
    public float FormattingTime { get; set; }

    [JsonProperty("execution_time")]
    public int ExecutionTime { get; set; }
}

[JsonObject("Statistics2")]
class Statistics2
{
    [JsonProperty("request_processing_time")]
    public float RequestProcessingTime { get; set; }

    [JsonProperty("content_fetch_time")]
    public float ContentFetchTime { get; set; }

    [JsonProperty("job_preparation_time")]
    public float JobPreparationTime { get; set; }

    [JsonProperty("audio_analysis_time")]
    public float AudioAnalysisTime { get; set; }

    [JsonProperty("segmentation_time")]
    public float SegmentationTime { get; set; }

    [JsonProperty("transcription_time")]
    public float TranscriptionTime { get; set; }

    [JsonProperty("diarization_time")]
    public float DiarizationTime { get; set; }

    [JsonProperty("music_detection_time")]
    public float MusicDetectionTime { get; set; }

    [JsonProperty("merge_time")]
    public float MergeTime { get; set; }

    [JsonProperty("formatting_time")]
    public float FormattingTime { get; set; }
}