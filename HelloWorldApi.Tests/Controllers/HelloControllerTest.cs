using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApi.Controllers;
using HelloWorldModel.HelloWorldModels;

namespace HelloWorldApi.Tests.Controllers
{
    [TestClass]
    public class HelloControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            IEnumerable<HelloModel> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Hello World", result.ElementAt(0).Message);
            
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("Hello World", result.Message);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
