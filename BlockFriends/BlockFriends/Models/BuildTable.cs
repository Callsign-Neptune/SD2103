using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlockFriends.Models
{
    public partial class BuildTable
    {
        [Key]
        public int Id { get; set; }
        public string Buildname { get; set; }
        public string BuildContent { get; set; }
        public int? MaterialUsed { get; set; }
        public int BuildTime { get; set; }
        public int? BuildBiome { get; set; }
        public int? ProfileId { get; set; }
        public int BuilderNum { get; set; }
        public string WorldSeed { get; set; }
        public string BuildPhoto { get; set; }
        public DateTime BuildDate { get; set; }

        public BiomeList BuildBiomeNavigation { get; set; }
        public MaterialList MaterialUsedNavigation { get; set; }
        public BuildUser Profile { get; set; }
    }
}
