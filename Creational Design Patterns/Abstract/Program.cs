/*
  Abstract Designn Pattern : Provides Abstract for creating object from superclass.
*/
using System;
namespace Abstract_dp
{
    public abstract class Shape{
   public abstract void Type();
    }
  
   public class Circle:Shape{
       public override void Type(){
        System.Console.WriteLine("Circle");
       }
   }
   public class Rectangle:Shape{
    public override void Type(){
        System.Console.WriteLine("Rectangle");
       }
   }
    internal class Program{
        private static void Main(string []args){
            Shape s1=new Rectangle();
            s1.Type();

            Shape s2=new Circle();
            s2.Type();
        }
    }
}
