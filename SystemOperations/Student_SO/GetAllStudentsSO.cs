using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class GetAllStudentsSO : SystemOperationBase
    {
        public List<Student> Result { get; private set; }
        Student s = new Student();
        ClassGroupDatabase cg = new ClassGroupDatabase();

        protected override void Execute()
        {
            Result = repository.GetAllJoinOrderBy(s,cg,"idclassgroup","lastname").OfType<Student>().ToList();
        }
    }
}
