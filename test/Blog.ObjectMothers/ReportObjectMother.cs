using System;
using Logistics.Domain.Model.Report;

namespace Blog.ObjectMothers
{
    public class ReportObjectMother
    {
        public static Report CreateReport()
        {
            var report = new Report
            {
                StartDateTime = DateTime.Now.AddDays(-7),
                EndDateTime = DateTime.Now
            };

            return report;
        }
    }
}
