/*
  Factory Designn Pattern : Provides interface for creating object from superclass.
*/
using System;
namespace Factory_DP
{
    public interface Shape{
        void Type();
    }
  
   public class Circle:Shape{
       public void Type(){
        System.Console.WriteLine("Circle");
       }
   }
   public class Rectangle:Shape{
    public void Type(){
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
