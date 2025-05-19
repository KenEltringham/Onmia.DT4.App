using Newtonsoft.Json;
namespace Onmia.DT4.App.Models
{ 
    public class ProsodicModel
    {
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("globalScore")]
        public double GlobalScore { get; set; }

        [JsonProperty("globalScoreGrade")]
        public string GlobalScoreGrade { get; set; }

        [JsonProperty("teamScore")]
        public double TeamScore { get; set; }

        [JsonProperty("teamScoreGrade")]
        public string TeamScoreGrade { get; set; }

        [JsonProperty("teamAccommodation")]
        public double TeamAccommodation { get; set; }

        [JsonProperty("accommodationScore")]
        public double AccommodationScore { get; set; }

        [JsonProperty("accommodationScoreGrade")]
        public string AccommodationScoreGrade { get; set; }

        [JsonProperty("pilotABalance")]
        public double PilotABalance { get; set; }

        [JsonProperty("pilotBBalance")]
        public double PilotBBalance { get; set; }

        [JsonProperty("globalSpeaking")]
        public double GlobalSpeaking { get; set; }

        [JsonProperty("globalListening")]
        public double GlobalListening { get; set; }

        [JsonProperty("globalTalkingA")]
        public double GlobalTalkingA { get; set; }

        [JsonProperty("globalTalkingB")]
        public double GlobalTalkingB { get; set; }

        [JsonProperty("overlap")]
        public double Overlap { get; set; }

        [JsonProperty("overlapGrade")]
        public string OverlapGrade { get; set; }

        [JsonProperty("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public object ErrorCode { get; set; }

        [JsonProperty("timedData")]
        public TimedDatum[] TimedData { get; set; }
    }

    public class TimedDatum
    {
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("communicationPerformance")]
        public double CommunicationPerformance { get; set; }

        [JsonProperty("pilotASpeaking")]
        public double PilotASpeaking { get; set; }

        [JsonProperty("pilotAListening")]
        public double PilotAListening { get; set; }

        [JsonProperty("pilotBSpeaking")]
        public double PilotBSpeaking { get; set; }

        [JsonProperty("pilotBListening")]
        public double PilotBListening { get; set; }

        [JsonProperty("overlapPercentage")]
        public double OverlapPercentage { get; set; }
    }
}
