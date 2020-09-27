using System;
using System.Collections.Generic;

namespace BlockFriends.Models
{
    public partial class BuildUser
    {
        public int Id { get; set; }
        public string Displayname { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }
        public string UserAccountId { get; set; }
        public string PhotoPath { get; set; }
    }
}
