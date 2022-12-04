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
      int sum3 = sum2 / 2;
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
      
      
      /**
      * Comparison Operators
      * ==	  Equal to	                x == y	
      * !=	  Not equal	                x != y	
      * >	    Greater than	            x > y	
      * <	    Less than	                x < y	
      * >=	  Greater than or equal to	x >= y	
      * <=	  Less than or equal to	    x <= y
      **/
      int xxx = 5;
      int yyy = 3;
      Console.WriteLine(xxx == yyy);
      Console.WriteLine(xxx != yyy);
      Console.WriteLine(xxx > yyy);
      Console.WriteLine(xxx < yyy);
      Console.WriteLine(xxx >= yyy);
      Console.WriteLine(xxx <= yyy);
      
      Console.WriteLine(separator);

      /**
      * Logical Operators
      * && 	Logical and	Returns True if both statements are true	x < 5 &&  x < 10	
      * || 	Logical or	Returns True if one of the statements is true	x < 5 || x < 4	
      * !	  Logical not	Reverse the result, returns False if the result is true	!(x < 5 && x < 10)
      **/
      int q = 5;
      int w = 3;
      Console.WriteLine(q == w && q != w);
      Console.WriteLine(q != w || q == w);
      Console.WriteLine(!(q > w));
      
      Console.WriteLine(separator);

      /**
      * Math
      * The C# Math class has many methods that allows you to perform mathematical tasks on numbers.
      **/
      Console.WriteLine(Math.Max(5, 10));
      Console.WriteLine(Math.Min(5, 10));
      Console.WriteLine(Math.Sqrt(34));
      Console.WriteLine(Math.Abs(-100));
      Console.WriteLine(Math.Round(9.22));
      Console.WriteLine(Math.Ceiling(9.10));
      Console.WriteLine(Math.Floor(9.99));
      
      Console.WriteLine(separator);

      /**
      * Strings
      **/
      string txt = "Hello World";
      Console.WriteLine("The length of the txt string is: " + txt.Length);
      Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
      Console.WriteLine(txt.ToLower());   // Outputs "hello world"

      Console.WriteLine(separator);

      /* string concat */
      string firstName = "Ario ";
      string lastName = "Damar";
      string myName = string.Concat(firstName, lastName);
      Console.WriteLine(myName);
      
      /* string interpolation */
      string ss = $"My name is {firstName} {lastName}";
      Console.WriteLine(ss);

      /* access strings */
      string myString = "Damar";
      Console.WriteLine(myString[0]);  // Outputs "D"

      // Location of the letter D
      int charPos = myName.IndexOf("D");
      Console.WriteLine(charPos);

      // Get last name
      string sss = myName.Substring(charPos);
      Console.WriteLine(sss);

      Console.WriteLine(separator);

      /* special characters */
      string sp = "my age is \"" + age + "\" ";
      Console.WriteLine(sp);

      Console.WriteLine(separator);

      /**
      * Booleans
      **/
      bool isCSharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine(isCSharpFun);   // Outputs True
      Console.WriteLine(isFishTasty);   // Outputs False

      Console.WriteLine(separator);

      /* expression */
      int aa = 10;
      int bb = 9;
      Console.WriteLine(aa > bb); // returns True, because 10 is higher than 9

      Console.WriteLine(separator);

      /**
      * If ... Else
      **/
      if (true) 
      {
        Console.WriteLine("true blocks 1");
      }
      Console.WriteLine(separator);

      int time = 20;
      if (time < 10) 
      {
        Console.WriteLine("blocks true 1");
      } 
      else if (time < 20) 
      {
        Console.WriteLine("blocks true 2");
      } 
      else 
      {
        Console.WriteLine("blocks else 2");
      }

      Console.WriteLine(separator);

      /* short hand if..else with ternary operator*/
      string result = (time < 18) ? "true ternary" : "false ternary";
      Console.WriteLine(result);

      Console.WriteLine(separator);


      /**
      * Switch
      **/
      int day = 5;
      switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }
      Console.WriteLine(separator);

      /**
      * Loop
      **/
      /* While */
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }
      Console.WriteLine(separator);


      /* Do While */
      z = 0;
      do 
      {
        Console.WriteLine(z);
        z++;
      }
      while (z < 5);
      Console.WriteLine(separator);

      /* For */
      for (int fl = 0; fl < 5; fl++) 
      {
        Console.WriteLine(fl);
      }

      /* nested */
      for (int ln = 1; ln <= 2; ++ln) 
      {
        Console.WriteLine("Outer: " + ln);  // Executes 2 times

        // Inner loop
        for (int li = 1; li <= 3; li++) 
        {
          Console.WriteLine(" Inner: " + li); // Executes 6 times (2 * 3)
        }
      }
      Console.WriteLine(separator);

      /* foreach */
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      foreach (string c in cars) 
      {
        Console.WriteLine(c);
      }
      Console.WriteLine(separator);

      /**
      * Arrays
      **/
      /* delcare array */
      // Declare an array
      // string[] cars;
      string[] brands = {"gucci", "louis vuitton", "stone island"}; // array of string
      int[] nums = {10, 20, 30, 40}; // array of num
      // accessing array value
      Console.WriteLine(brands[0]);
      Console.WriteLine(nums[3]);

      Console.WriteLine(separator);

      // changing array value
      brands[1] = "off-white";
      brands[2] = "balenciaga";
      brands[0] = "channel";
      Console.WriteLine(brands[1]);
      Console.WriteLine(brands[2]);
      Console.WriteLine(brands[0]);

      Console.WriteLine(separator);

      /* array length */
      Console.WriteLine("length array brands: " + brands.Length);

      Console.WriteLine(separator);

      /* other ways create an array, and add values later */
      string[] supercar;
      supercar = new string[] {"ferrari", "lamborghini", "pagani", "bugatti"};
      
      /* loop through arrays */
      // for lop
      for (int lta = 0; lta < supercar.Length; lta++) 
      {
        Console.WriteLine(supercar[lta]);
      }

      Console.WriteLine(separator);

      // foreach
      foreach (string v in supercar) 
      {
        Console.WriteLine(v);
      }

      Console.WriteLine(separator);

      /* sorting arrays */
      /* string */
      Array.Sort(cars);
      foreach (string v in cars)
      {
        Console.WriteLine(v);
      }

      Console.WriteLine(separator);

      /* int */
      // Sort an int
      int[] myNumbers = {5, 1, 8, 9};
      Array.Sort(myNumbers);
      foreach (int v in myNumbers)
      {
        Console.WriteLine(v);
      }

      Console.WriteLine(separator);

      /* namespace using System.Linq */
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

      Console.WriteLine(separator);

      int[,] numbersQue = { {1, 4, 2}, {3, 6, 8} };
      Console.WriteLine(numbersQue[0, 2]);  // Outputs 2

      Console.WriteLine(separator);

      foreach (int v in numbersQue)
      {
        Console.WriteLine(v);
      } 

      Console.WriteLine(separator);
      
      for (int v = 0; v < numbersQue.GetLength(0); v++) 
      { 
        for (int j = 0; j < numbersQue.GetLength(1); j++) 
        { 
          Console.WriteLine(numbersQue[v, j]); 
        } 
      }  

      Console.WriteLine(separator);
      
    }
  }
}