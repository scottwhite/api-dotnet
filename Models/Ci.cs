using System.ComponentModel;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
public struct Ci
{
    public string name {get;set;}
    public string ci_class {get;set;}
    public string model_name {get;set;}
    public string model_manufacturer {get;set;}
    public string model_number {get;set;}
    public string state_id {get;set;}
    public string location_name {get;set;}
    public string location_lat {get;set;}
    public string location_lon {get;set;}
    public string organization_id {get;set;}
    public string os_version_name {get;set;}
    public string os_name {get;set;}
    public DateTime created_on {get;set;}
    public string ip_address {get;set;}
    public string collector_id {get;set;}
    public DateTime last_checked {get;set;}

}

public class CiDao{

  private Npgsql.NpgsqlConnection conn;// GetOpenNpgsqlConnection() => (Npgsql.NpgsqlConnection)Provider.GetOpenConnection();
  private readonly IConfiguration _config;
  private readonly ILogger _logger;

  public CiDao(ILogger logger, IConfiguration config){
    _logger = logger;
    _config = config;
    var sc = _config.GetConnectionString("dbConnection");
    _logger.LogInformation("sc string is {sc}", sc);
    conn = new Npgsql.NpgsqlConnection(sc);
  }
  public IEnumerable<Ci> list(){
    const string sql =@"select * from cis";
    var result = conn.Query<Ci>(sql);
    return result;
  }
}