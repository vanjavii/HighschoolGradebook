﻿using DatabaseBroker;
using Domain;
using Repository.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        //protected Broker broker = new Broker();
        protected IRepository<IDomainObject> repository = new GenericDbRepository();
        public void ExecuteTemplate()
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute();
                repository.Commit();
            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void Execute();
        
    }
}
