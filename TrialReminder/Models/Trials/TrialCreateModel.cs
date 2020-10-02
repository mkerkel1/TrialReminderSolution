﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrialReminder.Models.Trials
{
    public class TrialCreateModel
    {
        [Required]
        [DisplayName("Name of Service")]
        public string ServiceName { get; set; }
        public string Url { get; set; }
        public DateTime? StartDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
    }
}
