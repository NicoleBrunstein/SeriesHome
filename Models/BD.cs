using System.Data.SqlClient;
using Dapper;

namespace serieshome.Models;

public class BD
{  private static string _connectionString = @"Server=localhost; DataBase=BDSeries;Trusted_Connection=True;";
  

    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "SELECT Nombre, ImagenSerie FROM Series";
        _ListadoSeries = db.Query<Series>(sql).ToList();
    }
}