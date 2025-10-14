public class Program{
  public static void Main(string[] args){
    int num1 = 10;
    Console.WriteLine("What would you like to divide 10 by?");
    string input = Console.ReadLine();
    int num2 = Int32.Parse(input);
    try{
      int num3 = num1/num2;
      Console.WriteLine(num3);
    }
    catch (DivideByZeroException){
      Console.WriteLine("You cannot divide a number by zero");
    }
  }
}
