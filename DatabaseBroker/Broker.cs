using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
 
        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }

        #region Standardne Broker funkcije
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            if(connection!=null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }
        #endregion 
    }
}

