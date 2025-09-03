using NUnit.Framework;
using TemperatuurSensor;

namespace TemperatuurSensorTest
{
    public class Tests
    {
        [Test]
        public void TemperatuurKanWordenIngesteld()
        {
            // Arrange
            var sensor = new TemperatuurSensor();

            // Act
            sensor.SetTemperatuur(25);

            // Assert
            Assert.That(sensor.GetTemperatuur(), Is.EqualTo(25));
        }

        [Test]
        public void TemperatuurBuitenBereikWordtNietIngesteld()
        {
            // Arrange
            var sensor = new TemperatuurSensor();
            sensor.SetTemperatuur(25); // Set initial valid temperature

            // Act
            sensor.SetTemperatuur(200); // Too high
            Assert.That(sensor.GetTemperatuur(), Is.EqualTo(25));

            sensor.SetTemperatuur(-100); // Too low
            Assert.That(sensor.GetTemperatuur(), Is.EqualTo(25));
        }
    }
}
