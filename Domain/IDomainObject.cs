using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomainObject
    {
        string TableName { get; }
        string InsertValues { get; }

        IDomainObject ReadObjectRow(SqlDataReader reader);
        IDomainObject ReadObjectNoJoin(SqlDataReader reader);
    }
}
