namespace ComputerEnCPU
{
    public class CPU
    {
        public string Model { get; }
        public CPU(string model) { Model = model; }
    }

    public class Computer
    {
        public string Naam { get; }
        public CPU Processor { get; }

        public Computer(string naam, string cpuModel)
        {
            Naam = naam;
            // TODO: implement
        }
    }
}
