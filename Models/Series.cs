using System.Data.SqlClient;
using Dapper;


public class Series
{
     public int IdSerie {get;set;}
     public string Nombre {get;set;}
     public int Anoinicio {get;set;}
     public string Sinopsis {get;set;}
     public string imgSerie {get;set;}
}