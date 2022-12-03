
namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string separator = "--------------------------------------------------------------------------";
      /**
      * HELLO WORLD
      **/
      Console.WriteLine("HELLO WORLD"); // print ln

      /**
      * comment, variables, and data types
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

      Console.WriteLine(separator);

      /**
      * Type Casting
      **/
      /* implicit */
      int simpleInt = 8;
      double simpleDouble = simpleInt;

      Console.WriteLine(simpleInt);
      Console.WriteLine(simpleDouble);

      /* explicit */
      double myDouble = 7.89D;
      int myInt = (int) myDouble;

      Console.WriteLine(myDouble);
      Console.WriteLine(myInt);

      /* Conversion Methods */
      int testInt = 10;
      double testDouble = 5.25;
      bool testBool = true;

      Console.WriteLine(Convert.ToString(testInt));    // int to string
      Console.WriteLine(Convert.ToDouble(testInt));    // int to double
      Console.WriteLine(Convert.ToInt32(testDouble));  // double to int
      Console.WriteLine(Convert.ToString(testBool));   // bool to string

      Console.WriteLine(separator);


      /**
      * User Input
      **/
      Console.WriteLine("Enter username:");

      /* string */
      string? userName = Console.ReadLine();
      // Console.WriteLine(userName.GetType());
      if (userName == "") {
        userName = "administrator";
      } 
      Console.WriteLine("Username is: " + userName);

      /* int */
      Console.WriteLine("Enter your age:");
      string? input = Console.ReadLine();
      int? testAge = int.TryParse(input, out var a) ? a : default;
      Console.WriteLine("Your age is: " + testAge);
      
      Console.WriteLine(separator);

      /**
      * Operators
      * (+)	Addition	        Adds together two values	              x + y	
      * (-)	Subtraction	      Subtracts one value from another	      x - y	
      * (*)	Multiplication	  Multiplies two values	                  x * y	
      * (/)	Division          Divides one value by another	          x / y	
      * (%)	Modulus	          Returns the division remainder	        x % y	
      * (++)	Increment	      Increases the value of a variable by 1	x++	
      * (--) Decrement        Decreases the value of a variable by 1	x--
      **/
      int sum = 100 + 100;
      int sum1 = sum - 200;
      int sum2 = sum1 * 100;
      int sum3 = sum2 / sum2;
      int sum4 = sum3 % 2;
      int sum5 = 0;
      int sum6 = sum5++;
      int sum7 = sum6--;
      int sum8 = ++sum7;
      int sum9 = --sum8;

      Console.WriteLine(sum);
      Console.WriteLine(sum1);
      Console.WriteLine(sum2);
      Console.WriteLine(sum3);
      Console.WriteLine(sum4);
      Console.WriteLine(sum5);
      Console.WriteLine(sum6);
      Console.WriteLine(sum7);
      Console.WriteLine(sum8);
      Console.WriteLine(sum9);

      Console.WriteLine(separator);

      /**
      * Assignment Operators
      * (=)   x = 5	    x = 5	
      * (+=)	x += 3	  x = x + 3	
      * (-=)	x -= 3	  x = x - 3	
      * (*=)	x *= 3	  x = x * 3	
      * (/=)	x /= 3	  x = x / 3	
      * (%=)	x %= 3	  x = x % 3	
      * (&=)	x &= 3	  x = x & 3	
      * (|=)	x |= 3	  x = x | 3	
      * (^=)	x ^= 3	  x = x ^ 3	
      * (>>=)	x >>= 3	  x = x >> 3	
      * (<<=)	x <<= 3	  x = x << 3
      **/
      int xx = 10;
      xx += 100;
      Console.WriteLine(xx);
      xx -= 1;
      Console.WriteLine(xx);
      xx *= 2;
      Console.WriteLine(xx);
      xx /= 2;
      Console.WriteLine(xx);
      xx %= 2;
      Console.WriteLine(xx);
      xx &= 1;
      Console.WriteLine(xx);
      xx |= 1;
      Console.WriteLine(xx);
      xx ^= 1;
      Console.WriteLine(xx);
      xx >>= 1;
      Console.WriteLine(xx);
      xx <<= 1;
      Console.WriteLine(xx);

      Console.WriteLine(separator);
      
    }
  }
}