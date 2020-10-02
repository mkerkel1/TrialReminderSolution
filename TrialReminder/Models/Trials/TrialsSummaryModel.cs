using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialReminder.Models.Trials
{
    public class TrialsSummaryModel
    {
        public List<TrialSummaryItemModel> Trials { get; set; }

        public int NumberOfCurrentTrials { get; set; }
        public int NumberOfExpiredTrials { get; set; }
    }

    public class TrialSummaryItemModel
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string Url { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool HasStartDate { get; set; }

        public bool HasEndDate { get; set; }
        public bool IsExpired { get; set; }
        public int DaysLeft { get; set; }

    }
}
