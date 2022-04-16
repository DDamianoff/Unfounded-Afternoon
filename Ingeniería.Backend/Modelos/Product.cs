namespace Ingeniería.Backend.Modelos;

public class Product
{
    public int Id
    {
        get;
        set;
    }

    public int Stock
    {
        get;
        set;
    }
    
    public string Nombre
    {
        get; 
        set;
    }

    public string Marca
    {
        get; 
        set;
    }

    public string Categoría
    {
        get; 
        set;
    }

    public string Descripción
    {
        get; 
        set;
    }
    
    public double Precio 
    { 
        get; 
        set;
    }
}