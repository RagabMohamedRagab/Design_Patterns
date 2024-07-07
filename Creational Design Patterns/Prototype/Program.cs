  /*
    Prototype Design Pattern : Creating a new Object by Clone or Copy existing object rather than creating it from scarch.
    it"s a creational Design Patterns Copy oe Clone Existing Object with the same properties and methods.
  */
  using System;

  namespace Prototype_DP
  {
      public class Employee
      {
          public string Department { get; set; }
          public string Name { get; set; }

          public Employee GetClone()
          {
              return (Employee)this.MemberwiseClone();
          }
      }

      internal class Program
      {
          private static void Main(string[] args)
          {
              // Copy
              Employee emp1 = new Employee();
              emp1.Name = "Anurag";
              emp1.Department = "IT";
              Employee emp2 = emp1;

              emp2.Name = "Ragab";
            //  System.Console.WriteLine($"emp1 : {emp1.Name} : {emp1.Department}");
              //System.Console.WriteLine($"emp2 : {emp2.Name} : {emp2.Department}");

              // Clone

              Employee emp = emp1.GetClone();

              emp.Name = "Ahmed";
               System.Console.WriteLine($"emp1 : {emp1.Name} : {emp1.Department}");
              System.Console.WriteLine($"emp : {emp.Name} : {emp.Department}");
          }
      }
  }
