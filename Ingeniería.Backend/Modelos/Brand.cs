namespace Ingeniería.Backend.Modelos;

public class Brand
{
    public int Id
    {
        get;
        set;
    }

    public string? Nombre
    {
        get;
        set;
    }

    public override string ToString() => $"{Nombre}";

}