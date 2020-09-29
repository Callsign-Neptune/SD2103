using System;
using System.Collections.Generic;

namespace FriendsV2.Models
{
    public partial class MailMessages
    {
        public int Id { get; set; }
        public int? FromProfileId { get; set; }
        public int? ToProfileId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageText { get; set; }
        public bool IsRead { get; set; }

        public BuildUser FromProfile { get; set; }
        public BuildUser ToProfile { get; set; }
    }
}
