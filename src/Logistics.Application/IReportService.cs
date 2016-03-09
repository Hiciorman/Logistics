using System;
using Logistics.Domain;

namespace Logistics.Application
{
    public interface IReportService
    {
        Report CreateNewReport(DateTime start, DateTime end);
        Report CreateNewReport(DateTime start, DateTime end, Courier courier);
    }
}
