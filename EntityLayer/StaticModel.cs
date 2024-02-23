using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class StaticModel
    {
        public int InboxCount { get; set; }
        public int SendboxCount { get; set; }
        public int ReadSendboxCount { get; set; }
        public int UnreadableSendboxCount { get; set; }
    }

    public class CaptchaResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error-codes")]
        public List<string> ErrorCodes { get; set; }
    }

    public class Calender
    {
        public String title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public bool allDay { get; set; }
    }
}
