using System;
using System.Collections.Generic;

namespace BlockFriends.Models
{
    public partial class MaterialList
    {
        public MaterialList()
        {
            BuildTable = new HashSet<BuildTable>();
        }

        public int Id { get; set; }
        public string MaterialName { get; set; }

        public ICollection<BuildTable> BuildTable { get; set; }
    }
}
