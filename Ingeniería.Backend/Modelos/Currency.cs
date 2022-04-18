using System.ComponentModel.DataAnnotations.Schema;

namespace Ingeniería.Backend.Modelos;

public class Currency
{
    public int Id
    {
        get;
        set;
    }

    public string? Type
    {
        get;
        set;
    }
    
    
    [NotMapped]
    public static Currency Soles = new Currency() { Type = "PEN" };
    [NotMapped]
    public static Currency Dólares = new Currency() { Type = "USD" };
    [NotMapped]
    public static Currency Éuros = new Currency() { Type = "EUR" };
}