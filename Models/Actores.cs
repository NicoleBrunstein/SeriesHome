using System.Data.SqlClient;
using Dapper;

namespace serieshome.Models;

public class Actores
{
     public int IdActor {get;set;}
     public int IDSerie {get;set;}
     public string Nombre {get;set;}
     
}