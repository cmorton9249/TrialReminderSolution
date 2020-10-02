using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TrialReminder.Models.Trials
{
	public class TrialSummaryModel
	{
		public List<Trial> Trials { get; set; }
		public int NumberOfCurrentTrials { get; set; }
		public int NumberOfExpiredTrials { get; set; }
	}

	public class TrialSummaryItemModel
	{
		public int Id { get; set; }

		[DisplayName("Name of Service")]
		public string ServiceName { get; set; }
		public string Url { get; set; }
		public DateTime? StartDate { get; set; }
		public bool HasStartDate
		{
			get
			{
				return StartDate != null;
			}

		}
		public DateTime? EndDate { get; set; }
		public bool HasEndDate
		{
			get
			{
				return EndDate != null;
			}
		}
	}
}
