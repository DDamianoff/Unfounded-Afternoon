using System.ComponentModel.DataAnnotations.Schema;

namespace Ingeniería.Backend.Modelos;

public class Order
{
    public int Id
    {
        get;
        set;
    }

    public int CustomerId
    {
        get;
        set;
    }

    public Customer? Cliente
    {
        get;
        set;
    }
    
    public int ProductId
    {
        get;
        set;
    }
    
    public ICollection<Product>? Producto
    {
        get;
        set;
    }

    public int ReceiptId
    {
        get;
        set;
    }
    
    public Receipt? Comprobante
    {
        get;
        set;
    }

    public string? Estado
    {
        get;
        set;
    }

    public User? Vendedor
    {
        get;
        set;
    }

    public DateTime Fecha
    {
        get;
        set;
    }

    [NotMapped] public static string Cancelado = nameof(Cancelado);
    [NotMapped] public static string Íntegro = nameof(Íntegro);
}