using System;
using Blog.ObjectMothers;
using Logistics.Domain.Repositories;
using Moq;
using NUnit.Framework;

namespace Logistics.Application.UnitTests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private Mock<IOrderRepository> _repositoryMock;
        private IOrderService _os;

        [SetUp]
        public void Init()
        {
            _repositoryMock = new Mock<IOrderRepository>();
            _os = new OrderService(_repositoryMock.Object);
        }


        [Test]
        public void CheckGetAllMethodCalled()
        {
            //Arrange


            //Act
            _os.GetAll();

            //Asert
            _repositoryMock.Verify(x => x.GetAll(), Times.Once);
        }

        [Test]
        public void CheckGetByIdMethodCalled()
        {
            //Arrange
            var id = new Guid();

            //Act
            _os.GetById(id);

            //Asert
            _repositoryMock.Verify(x => x.GetById(id), Times.Once);
        }

        [Test]
        public void CheckInsertMethodCalled()
        {
            //Arrange
            var order = OrderObjectMother.CreateOrder();

            //Act
            _os.Insert(order);

            //Asert
            _repositoryMock.Verify(x => x.Insert(order), Times.Once);
        }

        [Test]
        public void CheckDeleteMethodCalled()
        {
            //Arrange
            var id = new Guid();

            //Act
            _os.Delete(id);

            //Asert
            _repositoryMock.Verify(x => x.Delete(id), Times.Once);
        }

        [Test]
        public void CheckGetAllMethodReturnsEmptyList()
        {
            //Arrange

            //Act
            var result = _os.GetAll();

            //Asert
            Assert.AreEqual(0, result.Count);
        }
    }
}
