using System;
using Blog.ObjectMothers;
using Logistics.Domain.Repositories;
using Moq;
using NUnit.Framework;

namespace Logistics.Application.UnitTests
{
    [TestFixture]
    public class ReportServiceTests
    {
        private Mock<IReportRepository> _repositoryMock;
        private IReportService _rs;

        [SetUp]
        public void Init()
        {
            _repositoryMock = new Mock<IReportRepository>();
            _rs = new ReportService(_repositoryMock.Object);
        }


        [Test]
        public void CheckGetAllMethodCalled()
        {
            //Arrange


            //Act
            _rs.GetAll();

            //Asert
            _repositoryMock.Verify(x => x.GetAll(), Times.Once);
        }

        [Test]
        public void CheckGetByIdMethodCalled()
        {
            //Arrange
            var id = new Guid();

            //Act
            _rs.GetById(id);

            //Asert
            _repositoryMock.Verify(x => x.GetById(id), Times.Once);
        }

        [Test]
        public void CheckInsertMethodCalled()
        {
            //Arrange
            var report = ReportObjectMother.CreateReport();

            //Act
            _rs.Insert(report);

            //Asert
            _repositoryMock.Verify(x => x.Insert(report), Times.Once);
        }

        [Test]
        public void CheckDeleteMethodCalled()
        {
            //Arrange
            var id = new Guid();

            //Act
            _rs.Delete(id);

            //Asert
            _repositoryMock.Verify(x => x.Delete(id), Times.Once);
        }

        [Test]
        public void CheckGetAllMethodReturnsEmptyList()
        {
            //Arrange

            //Act
            var result = _rs.GetAll();

            //Asert
            Assert.AreEqual(0, result.Count);
        }
    }
}