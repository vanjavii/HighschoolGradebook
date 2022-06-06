using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class ClassGroupDatabase : IDomainObject
    {
        public int IdClassGroup{ get; set; }
        public string Name { get; set; }
        public int Stream { get; set; }

        public string TableName => "ClassGroup";

        public string InsertValues => $"{IdClassGroup},'{Name}',{Stream}";

        public IDomainObject ReadObjectNoJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            ClassGroupDatabase cg = new ClassGroupDatabase();
            cg.IdClassGroup = (int)reader["IdClassGroup"];
            cg.Name = (string)reader["ClassGroupName"];
            cg.Stream = (int)reader["Stream"];
            return cg;
        }

        //public Teacher HomeroomTeacher { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
