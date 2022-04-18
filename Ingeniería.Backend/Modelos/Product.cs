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
    
    public string? Nombre
    {
        get; 
        set;
    }

    public int BrandId
    {
        get;
        set;
    }

    public Brand? Marca
    {
        get; 
        set;
    }

    public int CategoryId
    {
        get;
        set;
    }

    public Category? Categoría
    {
        get; 
        set;
    }

    public string? Descripción
    {
        get; 
        set;
    }

    public virtual ICollection<Order>? Pedidos

    { 
        get;
        set;
    }

    public double Precio 
    { 
        get; 
        set;
    }

    public bool IsEnabled
    {
        get;
        set;
    }

    public override string ToString() => $"{Nombre}";
}