using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class GetAllTeachersWithClassGroupSO : SystemOperationBase
    {
        private readonly Teacher t;
        private readonly Subject s;
        private readonly ClassGroupDatabase cg;

        public List<Teacher> Result { get; private set; }

        public GetAllTeachersWithClassGroupSO(Teacher t, Subject s, ClassGroupDatabase cg)
        {
            this.t = t;
            this.s = s;
            this.cg = cg;
        }
        protected override void Execute()
        {
            //select * from Teacher t join Subject s on t.IdSubject=s.IdSubject join ClassGroup cg on cg.IdClassGroup=t.IdClassHomeroomTeacher order by t.LastName asc";
            Result = repository.GetAlltable3OrderByAsc(t, s, cg, "idsubject", "idclassgroup", "IdClassHomeroomTeacher", "lastname").OfType<Teacher>().ToList();
        }
    }
}
