using System.Data.SqlClient;
using Dapper;

namespace serieshome.Models;

public class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=PreguntadOrt;Trusted_Connection=True;";
}