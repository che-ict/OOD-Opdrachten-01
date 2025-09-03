namespace AutoEnMotor
{
    public class Motor
    {
        public string Type { get; }
        public Motor(string type) { Type = type; }
    }

    public class Auto
    {
        public Motor AutoMotor { get; }

        public Auto(string motorType)
        {
            // TODO: implement
        }
    }
}