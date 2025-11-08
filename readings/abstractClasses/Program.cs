public class Program
{
  public static void Main(String[] args)
  {
    Honkable[] honkArray = new Honkable[3];
    honkArray[0] = new Goose();
    honkArray[1] = new Car();
    honkArray[2] = new Clown();

    foreach (Honkable item in honkArray)
    {
      item.Honk();
    }
  }
}

public class Goose : Honkable
{
  public override void Honk()
  {
    Console.WriteLine("annoying honk!");
  }
}

public class Car : Honkable
{
}

public class Clown : Honkable
{
  public override void Honk()
  {
    Console.WriteLine("squeaky nose!");
  }
}
