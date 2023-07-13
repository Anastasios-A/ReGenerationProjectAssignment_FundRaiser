﻿using System.ComponentModel.DataAnnotations;

namespace ReGenerationProjectAssignment_FundRaiser.Models
{
    public class Funding_Package
    {
        [Key]
        public int PackageId { get; set; }
        public Project Project { get; set; }
        public string PackageName { get; set; }
        public int PackageValue { get; set; }
        public string PackageRewared { get; set; }

        public virtual IEnumerable<Transaction_Tracker> Transaction_Trackers { get; set; } = new List<Transaction_Tracker>();
    }
}
