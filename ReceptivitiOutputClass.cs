﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var receptivitiOutput = ReceptivitiOutput.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ReceptivitiOutput
    {
        [JsonProperty("content_tags")]
        public object[] ContentTags { get; set; }

        [JsonProperty("receptiviti_scores")]
        public ReceptivitiScores ReceptivitiScores { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("personality_snapshot")]
        public PersonalitySnapshot[] PersonalitySnapshot { get; set; }

        [JsonProperty("communication_recommendation")]
        public string CommunicationRecommendation { get; set; }

        [JsonProperty("emotional_analysis")]
        public EmotionalAnalysis EmotionalAnalysis { get; set; }

        [JsonProperty("content_source")]
        public long ContentSource { get; set; }

        [JsonProperty("liwc_scores")]
        public LiwcScores LiwcScores { get; set; }

        [JsonProperty("content_date")]
        public DateTimeOffset ContentDate { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("organa_scores")]
        public Links OrganaScores { get; set; }
    }

    public partial class EmotionalAnalysis
    {
        [JsonProperty("facets")]
        public Facets Facets { get; set; }

        [JsonProperty("emotional_tone")]
        public EmotionalTone EmotionalTone { get; set; }
    }

    public partial class EmotionalTone
    {
        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class Facets
    {
        [JsonProperty("anger")]
        public long Anger { get; set; }

        [JsonProperty("fear")]
        public long Fear { get; set; }

        [JsonProperty("sad")]
        public long Sad { get; set; }
    }

    public partial class Links
    {
    }

    public partial class LiwcScores
    {
        [JsonProperty("tone")]
        public double Tone { get; set; }

        [JsonProperty("sixLtr")]
        public double SixLtr { get; set; }

        [JsonProperty("clout")]
        public double Clout { get; set; }

        [JsonProperty("wps")]
        public double Wps { get; set; }

        [JsonProperty("analytic")]
        public double Analytic { get; set; }

        [JsonProperty("wc")]
        public long Wc { get; set; }

        [JsonProperty("dic")]
        public double Dic { get; set; }

        [JsonProperty("authentic")]
        public double Authentic { get; set; }

        [JsonProperty("categories")]
        public Dictionary<string, double> Categories { get; set; }
    }

    public partial class PersonalitySnapshot
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class ReceptivitiScores
    {
        [JsonProperty("percentiles")]
        public Dictionary<string, double> Percentiles { get; set; }

        [JsonProperty("raw_scores")]
        public Dictionary<string, double> RawScores { get; set; }

        [JsonProperty("warnings")]
        public Dictionary<string, string[]> Warnings { get; set; }
    }

    public partial class ReceptivitiOutput
    {
        public static ReceptivitiOutput FromJson(string json) => JsonConvert.DeserializeObject<ReceptivitiOutput>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ReceptivitiOutput self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}