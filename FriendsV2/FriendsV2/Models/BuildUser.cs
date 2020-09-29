using System;
using System.Collections.Generic;

namespace FriendsV2.Models
{
    public partial class BuildUser
    {
        public BuildUser()
        {
            MailMessagesFromProfile = new HashSet<MailMessages>();
            MailMessagesToProfile = new HashSet<MailMessages>();
            ModList = new HashSet<ModList>();
        }

        public int Id { get; set; }
        public string Displayname { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }
        public string UserAccountId { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<MailMessages> MailMessagesFromProfile { get; set; }
        public ICollection<MailMessages> MailMessagesToProfile { get; set; }
        public ICollection<ModList> ModList { get; set; }
    }
}
