using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CC.Common.UserQuery.Data
{
  [TypeConverter(typeof(UserQueryConfigConverter))]
  public class UserQueryConfig
  {
    //(string ServerName, string DatabaseName, string Username, string Password, string ApplicationName);

    public String ServerName { get; set; }
    public String DatabaseName { get; set; }
    public String Username { get; set; }
    public String Password { get; set; }

    public UserQueryConfig()
    {
      this.ServerName = string.Empty;
      this.DatabaseName = string.Empty;
      this.Username = string.Empty;
      this.Password = string.Empty;
    }

    public UserQueryConfig(string ServerName, string DatabaseName, string Username, string Password)
    {
      this.ServerName = ServerName;
      this.DatabaseName = DatabaseName;
      this.Username = Username;
      this.Password = Password;
    }
  }
}
