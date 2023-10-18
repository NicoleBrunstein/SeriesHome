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

      
}