using System.ComponentModel.DataAnnotations.Schema;

namespace Ingeniería.Backend.Modelos;

public class Currency
{
    public int Id
    {
        get;
        set;
    }

    public string Type
    {
        get;
        set;
    }
    
    
    [NotMapped]
    public static string Soles = nameof(Soles);
    [NotMapped]
    public static string Dólares = nameof(Dólares);
    [NotMapped]
    public static string Éuros = nameof(Éuros);
    [NotMapped]
    public static IEnumerable<string> AllCurrencyTypes { get; } 
        = new List<String>
        {
            Soles,
            Dólares,
            Éuros
        };
}