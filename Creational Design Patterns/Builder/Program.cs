/*
 Builder Design Pattern : Build Complex Object Step By Step 
*/

using System;
namespace Builder_dp
{
    public class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string HardDisk { get; set; }
}

public class ComputerBuilder
{
    private Computer _computer = new Computer();
    public ComputerBuilder AddCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }
    public ComputerBuilder AddRAM(string ram)
    {
        _computer.RAM = ram;
        return this;
    }
    public ComputerBuilder AddHardDisk(string hardDisk)
    {
        _computer.HardDisk = hardDisk;
        return this;
    }
    public string Build()
    {
        return _computer.HardDisk +" : "+_computer.RAM +" : "+ _computer.CPU;
    }
}
    internal class Program{
        private static void Main(string []args){
              var computer = new ComputerBuilder()
                .AddCPU("Intel i7")
                .AddRAM("16GB")
                .AddHardDisk("512GB SSD");
                System.Console.WriteLine(computer.Build());
        }
    }
}