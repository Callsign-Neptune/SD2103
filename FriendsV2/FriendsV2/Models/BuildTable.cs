using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FriendsV2.Models
{
    public partial class BuildTable
    {
        [Key]
        public int Id { get; set; }
        public string Buildname { get; set; }
        public string BuildContent { get; set; }
        public int BuildTime { get; set; }
        public int BuilderNum { get; set; }
        public string WorldSeed { get; set; }
        public string BuildPhoto { get; set; }
        public DateTime BuildDate { get; set; }
    }
}
