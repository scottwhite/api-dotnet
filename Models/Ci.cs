using System.ComponentModel;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
public class Ci
{
    public string id {get;set;}
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

  private IDbConnection _conn;
  private readonly ILogger _logger; //no clue on the magic to get this injected

  public CiDao(IDbConnection conn){
    _conn = conn;
  }
  public IEnumerable<dynamic> list(){
    const string sql =@"select id, name, ci_class, organization_id, created_on, last_checked, collector_id from cis";
    var result = _conn.Query<dynamic>(sql);
    return result;
  }
}