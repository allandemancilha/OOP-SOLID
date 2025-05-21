public class InstanceThisParameter
{
    public string Name { get; set; }

    public InstanceThisParameter(string Name)
    {
        // 1) EVITA AMBIGUIDADES ENTRE OS NOMES DOS PARÂMETROS E AS PROPRIEDADES
        this.Name = Name;
        // 2) REPRESENTA A INSTÂNCIA DA CLASSE
        InstanceThis instanceThis = new InstanceThis(this);
        System.Console.WriteLine($"InstanceThisParameter Name: {this.Name}");
        System.Console.WriteLine($"InstanceThis Name: {instanceThis.Name}");
    }
}