using System.ComponentModel.DataAnnotations;

namespace Ingeniería.Backend.Modelos;

public class Receipt
{
    [Key]
    public int Ruc
    {
        get;
        set;
    }

    // TODO: usar las monedas.

    public string Dirección
    {
        get;
        set;
    }

    public string RazónSocial
    {
        get;
        set;
    }
}