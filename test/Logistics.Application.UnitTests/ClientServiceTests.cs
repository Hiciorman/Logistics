using System;
using Blog.ObjectMothers;
using Logistics.Domain.Repositories;
using Moq;
using NUnit.Framework;

namespace Logistics.Application.UnitTests
{
    [TestFixture]
    public class ClientServiceTests
    {
        private Mock<IClientRepository> _repositoryMock;
        private IClientService _cs;

        [SetUp]
        public void Init()
        {
            _repositoryMock = new Mock<IClientRepository>();
            _cs = new ClientService(_repositoryMock.Object);
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
            var client = ClientObjectMother.CreateClient();

            //Act
            _cs.Insert(client);

            //Asert
            _repositoryMock.Verify(x => x.Insert(client), Times.Once);
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