using NUnit.Framework;
using ComputerEnCPU;
using System.Reflection; // Added for reflection

namespace ComputerEnCPUTest
{
    public class Tests
    {
        [Test]
        public void ComputerHeeftCPUNaCreatie()
        {
            // Arrange
            var computer = new Computer("Mijn PC", "Intel i9");

            // Assert
            Assert.That(computer.Processor, Is.Not.Null);
            Assert.That(computer.Processor.Model, Is.EqualTo("Intel i9"));
        }

        [Test]
        public void ProcessorPropertyIsWritable()
        {
            // Arrange
            Type computerType = typeof(Computer);
            PropertyInfo processorProperty = computerType.GetProperty("Processor");

            // Assert
            Assert.That(processorProperty, Is.Not.Null, "Processor property not found.");
            Assert.That(processorProperty.CanWrite, Is.True, "Processor property should have a public setter.");
        }
    }
}
