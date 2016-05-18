using Logistics.Common;
using Logistics.Domain;
using Logistics.Domain.Model.Report;
using Logistics.Domain.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class ReportRepository : GenericRepository<Report>, IReportRepository
    {
        public ReportRepository(AppContext context) : base(context)
        {
        }
    }
}
