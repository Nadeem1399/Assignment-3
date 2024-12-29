public class Person
{
    private string v1;
    private int v2;

    public Person(string v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public Person Parent { get; set; }
    public object Parents { get; internal set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Parent's Name: {(Parent != null ? Parent.Name : "Unknown")}");
    }
}



