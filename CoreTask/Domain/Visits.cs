﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTask.Domain
{
    public class Visits
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Serial { get; set; }
        public int SalesID { get; set; }
        public int CustomerID { get; set; }
        public string VisitSummary { get; set; }
        [Column(TypeName = "Date")]
        public DateTime VisitDate { get; set; }

        public Sales sales { get; set; }
        public Customer customer { get; set; }

    }
}
