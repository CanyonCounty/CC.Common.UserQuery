using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CC.Common.UserQuery.Data
{
  public partial class DataHandler
  {
    //private CCSqlDataAccess _da;
    private DataTable _table;
    private string _msg;
    private string _connectionString;

    public DataHandler(UserQueryConfig config)
    {
      //_da = new CCSqlDataAccess("ccsql12prod1", "POInventory", "poiuser", "poiuserpwd", "CC.BOCC.IT.POInventoryQuery");
      //_da = new CCSqlDataAccess(config.ServerName, config.DatabaseName, config.Username, config.Password, "CC.Common.UserQuery");

      SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
      csb.DataSource = config.ServerName;
      csb.InitialCatalog = config.DatabaseName;
      csb.UserID = config.Username;
      csb.Password = config.Password;
      _connectionString = csb.ToString();

      _msg = String.Empty;
    }
    
    public String Message
    {
      get { return _msg; }
    }

    //private bool HandleSelect(string sql)
    //{
    //  bool ret = false;

    //  _msg = String.Empty;
    //  _da.Command.SetSelect(sql, CommandType.Text);
    //  _da.Execute();
    //  ret = !_da.IsError;
    //  if (ret == false) _msg = _da.Message;

    //  return ret;
    //}

    private bool HandleSelect(string sql)
    {
      bool ret = true;
      try
      {
        // Reset our message
        _msg = String.Empty;

        using (SqlConnection con = new SqlConnection(_connectionString))
        {
          con.Open();

          using (SqlCommand cmd = con.CreateCommand())
          {
            cmd.CommandText = sql;

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
              //da.SelectCommand = new SqlCommand(sql, con);
              _table = new DataTable();
              da.Fill(_table);
            }
          }

          con.Close();
        }
      }
      catch (Exception e)
      {
        _msg = e.Message;
        ret = false;
      }

      return ret;
    }

    public string[] GetFields(string tableName)
    {
      string[] ret = { };

      if (HandleSelect(String.Format("select * from {0} where 1 = 0", tableName)))
      {
        //DataTable table = _da.Command.Result.DataTable;
        int count = _table.Columns.Count;
        ret = new string[count];
        for (int i = 0; i < count; i++)
        {
          ret[i] = _table.Columns[i].ColumnName;
        }
      }
      return ret;
    }
  }
}
