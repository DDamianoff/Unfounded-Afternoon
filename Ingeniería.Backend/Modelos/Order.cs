namespace Ingeniería.Backend.Modelos;

public class Order
{
    public int Id
    {
        get;
        set;
    }

    public Customer Cliente
    {
        get;
        set;
    }
    
    // TODO: claves foraneas EF
    public Product Producto
    {
        get; 
        set;
    }
    
    // TODO: claves foraneas EF
    public Receipt Comprobante
    {
        get;
        set;
    }
    
    // TODO: INCLUIR ESTADO

    public User Vendedor
    {
        get;
        set;
    }

    public DateTime Fecha
    {
        get;
        set;
    }
}