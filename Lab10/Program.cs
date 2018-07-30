using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Lab10
{ 
    class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("Wecome to the Circle Tester");
            
            Console.Write("Please enter a radius:  ");
            double radius = double.Parse (Console.ReadLine());
            Circle c1 = new Circle();
            c1.Circumference = 2 * radius * Math.PI;
            c1.Area = radius * radius * Math.PI;
             
             Console.WriteLine($"Circumference = {c1.Circumference} \n Area = {c1.Area}");
             Console.ReadLine();
             Console.WriteLine("Continue? y/n");
             string answer = Console.ReadLine();
          
            if (answer == "n")
            {   
             Console.WriteLine("Goodbye. You created 2 Circle objects.");
             Console.ReadLine();
            }
         }

     class Circle 
     {
        
        public double Circumference;
        public double Area;
        

        public Circle (double radius)
         {
          this.Circumference = Circumference;
          this.Area = Area;
         }
        
          public Circle()
           {
            Circumference = 0;
            Area = 0;
            
           } 
        
      }


   } 
}  

