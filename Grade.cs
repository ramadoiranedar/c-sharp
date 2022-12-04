class Grade : Student {
  public Grade(string vName) : base(vName)
  {
    name = vName;
  }

  public string? letter
  { get; set; }

  public void ShowGrade()
  {
    Console.WriteLine("name: " + name + " | " + "grade in letter: " + letter);
  }

  // polymorphism
  public override void TestPolymorphism() 
  {
    Console.WriteLine("Grade Class");
  } 
}