public class Employer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Employer(string Name, string Email)
    {
        // EVITA AMBIGUIDADES ENTRE OS NOMES DOS PARÂMETROS E AS PROPRIEDADES
        this.Name  = Name;
        this.Email = Email;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employer Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }
}