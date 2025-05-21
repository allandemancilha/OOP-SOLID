public class InstanceThisParameter
{
    public string Name { get; set; }

    public InstanceThisParameter(string nameProperty)
    {
        this.Name = nameProperty;
        // 2) REPRESENTA A INSTÂNCIA DA CLASSE
        InstanceThis instanceThis = new InstanceThis(this);
        System.Console.WriteLine($"InstanceThisParameter Name: {this.Name}");
        System.Console.WriteLine($"InstanceThis Name: {instanceThis.Name}");
    }
}