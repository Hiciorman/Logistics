using System;
using Blog.ObjectMothers;
using Logistics.Domain.Repositories;
using Moq;
using NUnit.Framework;

namespace Logistics.Application.UnitTests
{
    [TestFixture]
    public class CourierServiceTests
    {
        private Mock<ICourierRepository> _repositoryMock;
        private ICourierService _cs;

        [SetUp]
        public void Init()
        {
            _repositoryMock = new Mock<ICourierRepository>();
            _cs = new CourierService(_repositoryMock.Object);
        }


        [Test]
        public void CheckGetAllMethodCalled()
        {
            //Arrange


            //Act
            _cs.GetAll();

            //Asert
            _repositoryMock.Verify(x => x.GetAll(), Times.Once);
        }

        [Test]
        public void CheckGetByIdMethodCalled()
        {
            //Arrange
            var id = new Guid();

            //Act
            _cs.GetById(id);

            //Asert
            _repositoryMock.Verify(x => x.GetById(id), Times.Once);
        }

        [Test]
        public void CheckInsertMethodCalled()
        {
            //Arrange
            var courier = CourierObjectMother.CreateCourier();

            //Act
            _cs.Insert(courier);

            //Asert
            _repositoryMock.Verify(x => x.Insert(courier), Times.Once);
        }

        [Test]
        public void CheckDeleteMethodCalled()
        {
            //Arrange
            var id = new Guid();

            //Act
            _cs.Delete(id);

            //Asert
            _repositoryMock.Verify(x => x.Delete(id), Times.Once);
        }

        [Test]
        public void CheckGetAllMethodReturnsEmptyList()
        {
            //Arrange

            //Act
            var result = _cs.GetAll();

            //Asert
            Assert.AreEqual(0, result.Count);
        }
    }
}