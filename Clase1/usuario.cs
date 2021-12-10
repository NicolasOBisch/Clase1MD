public class usuario
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public usuario()
    {
    
    }
    public usuario(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public string full()
    {

        return $"{Name} {Surname}";
    }
}