namespace ConsoleApplication
{
  public class Method
  {

    // basic
    public static void MyMethod() {
      Console.WriteLine("My Method is run");
    }

    // with parameter
    public static void MyName(string firstName, string lastName) {
      Console.WriteLine(firstName + " " + lastName);
    }
    
    // with default parameter
    public static void MyCountry(string country = "Indonesia") 
    {
      Console.WriteLine(country);
    }

    // return value
    public static int MyAge() {
      return 23;
    }

    // multiple return value
    public static (string name, int age) NameAndAge() {
      string name = "damar";
      int age = 23;
      return (name, age);
    }

    // named arguments
    public static void MyFamily(string mom, string dad, string sister, string brother = "Dendi") 
    {
      Console.WriteLine("My Family: " + mom);
      Console.WriteLine("My Family: " + dad);
      Console.WriteLine("My Family: " + sister);
      Console.WriteLine("My Family: " + brother);
    }

    // overlading method
    public static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    public static double PlusMethod(double x, double y)
    {
      return x + y;
    }
  }
}