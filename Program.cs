
namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /**
      * HELLO WORLD
      **/
      Console.WriteLine("HELLO WORLD"); // print ln

      /**
      * data type
      **/
      string name = "damar";    // String
      int age = 23;             // Integer
      long weight = 15000000000L;   // Floating number
      float height = 1.35F;    // Floating number
      double length = 15.99D;   // Floating number
      bool isMarried = false;   // Boolean
      char blood = 'A';         // Character
      string country, city;
      country = "Indonesia";
      city = "Bekasi";
      const string macbook = "MacBook Pro";
      const string men = "Men";
      const string women = "Women";
      string gender = men;
      int x = 1, y = 2, z = 30;
      int simpleCalculation = x + y + z;

      Console.WriteLine(name);
      Console.WriteLine(age);
      Console.WriteLine(weight);
      Console.WriteLine(height);
      Console.WriteLine(length);
      Console.WriteLine(isMarried);
      Console.WriteLine(blood);
      Console.WriteLine(country);
      Console.WriteLine(city);
      Console.WriteLine(macbook);
      Console.WriteLine(men);
      Console.WriteLine(women);
      Console.WriteLine("Hello my name is " + name + " (" + age + "). i am a " + gender + " with weight " + weight + " and i was live in " + city + ", " + country + ". My blood is \"" + blood + "\", my married status is " + isMarried + ". I have device " + macbook + " for coding.");
      Console.WriteLine("simpleCalculation " + simpleCalculation);
    }
  }
}