using System.Data.SqlClient;
using Dapper;


public class Series
{
public int IdSerie {get; set;}
    public string Nombre {get; set;}
    public int AnoInicio {get; set;}
    public string Sinopsis {get; set;}
    public string ImagenSerie {get; set;}

     public Series(int idSerie, string nombre, int anoInicio, string sinopsis, string imagenSerie)
    {
        IdSerie = idSerie;
        Nombre = nombre;
        AnoInicio = anoInicio;
        Sinopsis = sinopsis;
        ImagenSerie = imagenSerie;
    }

    public Series() { }
}