namespace Ingeniería.Backend.Modelos;

public class Category
{
    public int Id
    {
        get;
        set;
    }

    public string? Categoría
    {
        get;
        set;
    }

    public override string ToString() => $"{Categoría}";
}