using System;
using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.Model.Report;
using Logistics.Domain.Repositories;

namespace Logistics.Application
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public Report Insert(Report obj)
        {
            return _reportRepository.Insert(obj);
        }

        public bool Update(Report obj)
        {
            return _reportRepository.Update(obj);
        }

        public bool Delete(Guid id)
        {
            return _reportRepository.Delete(id);
        }

        public void Save()
        {
            _reportRepository.Save();
        }

        public Report GetById(Guid id)
        {
            return _reportRepository.GetById(id);
        }

        public IList<Report> GetAll()
        {
            return _reportRepository.GetAll().ToList();
        }
    }
}
