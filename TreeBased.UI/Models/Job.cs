namespace TreeBased.UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        public int ID { get; set; }

        [StringLength(12)]
        public string CodeYegan { get; set; }

        [StringLength(16)]
        public string CodeYeganNum { get; set; }

        [StringLength(10)]
        public string CodeJob { get; set; }

        [StringLength(250)]
        public string TitlePost { get; set; }

        [StringLength(50)]
        public string KeyPost { get; set; }

        [StringLength(12)]
        public string JobID { get; set; }

        public int? ParentCode { get; set; }
    }
}
