using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ingeniería.Backend.Modelos;

public class Receipt
{
    [Key]
    [ForeignKey("Order")]
    public int ReceiptId
    {
        get;
        set;
    }
    
    [NotMapped]
    public int Ruc
    {
        get => ReceiptId;
        set => value = ReceiptId;
    }

    public int CurrencyId
    {
        get;
        set;
    }
    public Currency Moneda
    {
        get;
        set;
    }

    public string? Dirección
    {
        get;
        set;
    }

    public string? RazónSocial
    {
        get;
        set;
    }

    public Order? Order
    {
        get;
        set;
    }
}