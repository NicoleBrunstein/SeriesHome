using System.Data.SqlClient;
using Dapper;

namespace serieshome.Models;

public class Temporadas 
{
    public int IDTemporada {get;set;}
     public int IDSerie {get;set;}
     public string Numerotemporada {get;set;}
     public string Titulotemporada {get;set;}
}