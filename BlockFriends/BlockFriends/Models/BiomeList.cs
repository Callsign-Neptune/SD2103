using System;
using System.Collections.Generic;

namespace BlockFriends.Models
{
    public partial class BiomeList
    {
        public BiomeList()
        {
            BuildTable = new HashSet<BuildTable>();
        }

        public int Id { get; set; }
        public string BiomeName { get; set; }

        public ICollection<BuildTable> BuildTable { get; set; }
    }
}
