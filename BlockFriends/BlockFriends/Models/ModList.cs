using System;
using System.Collections.Generic;

namespace BlockFriends.Models
{
    public partial class ModList
    {
        public int Id { get; set; }
        public string ModName { get; set; }
        public string FilePath { get; set; }
        public int Downloads { get; set; }
        public int? UserDownloads { get; set; }

        public BuildUser UserDownloadsNavigation { get; set; }
    }
}
