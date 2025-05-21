public class Class2
{
    public string Name { get; set; } = "Class2";
    public Class3 Class3 { get; set; }

    public Class2()
    {
        this.Class3 = new Class3();
        System.Console.WriteLine($"Class3 Name: {this.Class3.Name}");
    }
}