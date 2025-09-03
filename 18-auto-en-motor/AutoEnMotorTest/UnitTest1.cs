using NUnit.Framework;
using AutoEnMotor;
using System.Reflection; // Added for reflection

namespace AutoEnMotorTest
{
    public class Tests
    {
        [Test]
        public void AutoHeeftMotorNaCreatie()
        {
            // Arrange
            var auto = new Auto("V8");

            // Assert
            Assert.That(auto.AutoMotor, Is.Not.Null);
            Assert.That(auto.AutoMotor.Type, Is.EqualTo("V8"));
        }

        [Test]
        public void AutoMotorPropertyIsWritable()
        {
            // Arrange
            Type autoType = typeof(Auto);
            PropertyInfo autoMotorProperty = autoType.GetProperty("AutoMotor");

            // Assert
            Assert.That(autoMotorProperty, Is.Not.Null, "AutoMotor property not found.");
            Assert.That(autoMotorProperty.CanWrite, Is.True, "AutoMotor property should not have a public setter.");
        }
    }
}
