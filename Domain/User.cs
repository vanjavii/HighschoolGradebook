using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class User : IDomainObject
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string TableName => "Users";

        public string InsertValues => $"'{FirstName}','{LastName}','{Username}','{Password}'";

        public IDomainObject ReadObjectNoJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            User u = new User();
            u.IdUser = (int)reader["IdUser"];
            u.FirstName = (string)reader["FirstName"]; 
            u.LastName = (string)reader["LastName"];
            u.Username = (string)reader["Username"];
            u.Password = (string)reader["Password"];
            return u;
        }
    }
}
