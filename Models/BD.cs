using System.Data.SqlClient;
using Dapper;

namespace SeriesHome.Models;

public class BD
{  private static string _connectionString = @"Server=localhost; DataBase=BDSeries;Trusted_Connection=True;";
  
    public static List<Series> TraerSeries() 
    {
        List<Series>  listadoSeries = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Series";
            listadoSeries = db.Query<Series>(sql).ToList();
        }
        return listadoSeries;
    }

    public static Series SerieElegida(int id)
    {
         Series serieElegida = null;
         using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Series WHERE IdSerie = @pidserie";
            serieElegida = db.QueryFirstOrDefault<Series>(sql, new {@pidserie = id});
        }
        return serieElegida;
    }

 public static List<Actores> ObtenerActores(int id)
    {
        List<Actores> actores = new List<Actores>();
        string sql = "SELECT * FROM Actores WHERE IdSerie = @id";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            actores = BD.Query<Actores>(sql, new { id }).ToList();
        }
        return actores;
    }

    public static List<Temporadas> ObtenerTemporadas(int id)
    {
        List<Temporadas> temporadas = new List<Temporadas>();
        string sql = "SELECT * FROM Temporadas WHERE IdSerie = @id";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            temporadas = BD.Query<Temporadas>(sql, new { id }).ToList();
        }
        return temporadas;
    }
}