// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;


// Tutorial
//https://www.tutorialspoint.com/csharp/csharp_basic_syntax.htm

/*
namespace HelloWorld {
  class Program {
    static void Main(string[] args) {
    // My first C# program
      Console.WriteLine("Hello World!");
      Console.ReadKey();    
    }
  }
}
*/
/*
namespace RectangleApp{
  class Rectangle {
    // declaring variables
    double length;
    double width;

    // assigning values
    public void Acceptdetails() {
      length = 4.5;
      width = 3.5;

    }
    // maths function
      public double GetArea() {
      return length * width;
    }
    // display
    public void Display() {
      Console.WriteLine("Length: {0}", length);
      Console.WriteLine("Width: {0}", width);
      Console.WriteLine("Area: {0}", GetArea());
    }
  }
  //The Main program. Runs the functions with variables
  class ExecuteRectangle {
    static void Main(string[] args) {
      Rectangle r = new Rectangle();
      r.Acceptdetails();
      r.Display();
      Console.ReadLine();
    }
  }
}


namespace DataTypeApplication {
   class Program {
      static void Main(string[] args) {
         Console.WriteLine("Size of int: {0}", sizeof(int));
         Console.ReadLine();
      }
   }
}

*/

namespace TypeConversionApplication{
  class ExplicitConversion{
    static void Main(string[] args){
      double d = 5673.74;
      int i;

      Console.WriteLine(d.ToString());
      i = (int)d;
      Console.WriteLine(i);

    }
  }
}