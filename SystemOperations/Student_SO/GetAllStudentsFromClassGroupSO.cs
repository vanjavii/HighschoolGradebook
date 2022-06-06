using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Student_SO
{
    public class GetAllStudentsFromClassGroupSO : SystemOperationBase
    {
        public List<Student> Result { get; private set; }
        Student s = new Student();
        ClassGroupDatabase cg = new ClassGroupDatabase();
        private readonly int selectedClassgroup;

        public GetAllStudentsFromClassGroupSO(int selectedClassgroup)
        {
            this.selectedClassgroup = selectedClassgroup;
        }

        protected override void Execute()
        {
            Result = repository.GetAllJoinWhereOrderByAsc(s, cg, "idclassgroup", "idclassgroup", "idclassgroup", selectedClassgroup, "lastname").OfType<Student>().ToList();
        }
    }
}
