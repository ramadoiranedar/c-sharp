class Student : People
{
  // ACCESS MODIFIERS
  /*
    public	      The code is accessible for all classes
    private	      The code is only accessible within the same class
    protected	    The code is accessible within the same class, or i
                  n a class that is inherited from that class. You will learn more about inheritance in a later chapter
    internal	    The code is only accessible within its own assembly, 
                  but not from another assembly. You will learn more about this in a later chapter
  */
  public string name;
  public int age;

  // enum
  public enum Level 
  {
    Junior,
    Middle,
    High
  }

  public Level GetLevel(Level level = Level.Junior) {
    switch (level)
    {
      case Level.Junior:
        return Level.Junior;
      case Level.Middle:
        return Level.Middle;
      case Level.High:
        return Level.High;
      default:
        return Level.Junior;
    }
  }

  public Student(string vName)
  {
    name = vName;
  }

  // Encapsulation with getter and setter
  public int Age   // property
  {
    get { return age; }   // get method
    set { age = value; }  // set method
  }
  // with short hand
  public string? email // nullable field email
  { get; set; }

  // old way getter
  public string GetName() {
    return name;
  }

  // polymorphism
  // by adding the virtual keyword to the method inside the base class, and by using the override keyword for each derived class methods
  public virtual void TestPolymorphism() {
    Console.WriteLine("Student Class");
  }

  // abstract
  public override void TestAbstract() 
  {
    Console.WriteLine("Abstract from People");
  }
}