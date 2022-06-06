using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO
{
    public class AddSubjectSO : SystemOperationBase
    {
        private readonly Subject s;
        public int Result { get; private set; }

        public AddSubjectSO(Subject s)
        {
            this.s = s;
        }
        protected override void Execute()
        {
            try
            {                
                Result = repository.AddOutputInserted(s);
            }
            catch (Exception)
            {
                Result = 0;                
            }
        }
    }
}
