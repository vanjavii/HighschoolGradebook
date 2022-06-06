using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DatabaseRepository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();

        #region standardne broker funkcije
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public List<IDomainObject> Search(string kriterijum)
        {
            throw new NotImplementedException();
        }

        public void Update(IDomainObject obj)
        {
            throw new NotImplementedException();
        }
        
        public void Delete(IDomainObject obj)
        {
            throw new NotImplementedException();
        }
        #endregion

        public List<IDomainObject> GetAll(IDomainObject obj)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public List<IDomainObject> GetAllOrderBy(IDomainObject obj, string ordBy)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} order by {ordBy} asc";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public List<IDomainObject> GetAllJoinOrd(IDomainObject o1,IDomainObject o2, string joinCol, string orderBy)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {o1.TableName} a join {o2.TableName} b on (a.{joinCol}=b.{joinCol}) order by a.{orderBy} asc";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public void Save(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} values ({obj.InsertValues})";
            int brojRedova = command.ExecuteNonQuery();
        }

        public void SaveAllColl(IDomainObject obj, string a,string b, string c, string d, string e, int f)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} values ('{a}','{b}','{c}','{d}','{e}',{f})";
            int brojRedova = command.ExecuteNonQuery();
        }

        public int SaveColIsNull(IDomainObject obj, string sequence)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} values ({sequence})";
            int brojRedova = command.ExecuteNonQuery();
            return brojRedova;
        }

        public void Change(IDomainObject obj, string changeType, string textChange, string criteriaType, int criteriaValue)
        {       
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"update {obj.TableName} set {changeType}='{textChange}' where {criteriaType}={criteriaValue}";
            command.ExecuteNonQuery();
        }

        public IDomainObject FindByCriteria(IDomainObject obj,string column, int id)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} where {column}={id}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectNoJoin(reader);
                    result.Add(rowObject);
                }
            }
            return result[0];
        }

        public List<IDomainObject> GetAllCriteriaNull(IDomainObject obj, string criteria)
        {
            List<IDomainObject> result= new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} where {criteria} is null";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                IDomainObject rowObject = obj.ReadObjectNoJoin(reader);
                result.Add(rowObject);
            }
            return result;
        }

        public void DeleteByCriteria(IDomainObject obj, string column, int value)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"delete from {obj.TableName} where {column}={value}";
            command.ExecuteNonQuery();
        }

        public List<IDomainObject> GetAllWhereStringCriteria(IDomainObject obj, string criteria)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} where {criteria}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public IDomainObject FindJoinWhere(IDomainObject o1, IDomainObject o2, string o1col, string o2col, string where, int value)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {o1.TableName} a join {o2.TableName} b on (a.{o1col}=b.{o2col}) where a.{where}={value}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result[0];
        }

        public IDomainObject FindJoinStringWhere(IDomainObject o1, IDomainObject o2, string o1col, string o2col, string criteria)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {o1.TableName} a join {o2.TableName} b on (a.{o1col}=b.{o2col}) where {criteria}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result[0];
        }

        public int AddOutputInserted(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} output inserted.id{obj.TableName} values ({obj.InsertValues})";
            int id = (int)command.ExecuteScalar();
            return id;
        }

        public void Change3valWhere(IDomainObject obj, string c1, string v1, string c2, string v2, string c3, int v3, string whereCol, int whereVal)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"update {obj.TableName} set {c1}='{v1}', {c2}='{v2}',{c3}={v3} where {whereCol}={whereVal}";
            command.ExecuteNonQuery();
        }

        public string GetColumnValueWhere(IDomainObject obj, string col, string whereCol, int whereValue)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select {col} from {obj.TableName} where {whereCol}={whereValue}";
            return (string)command.ExecuteScalar();
        }
        
        public bool GetColumnWhereBool(IDomainObject obj, string col, string whereCol, int whereValue)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select {col} from {obj.TableName} where {whereCol}={whereValue}";
            int val = (int)command.ExecuteScalar();
            if (val == 1) return true;
            return false;
        }

        public List<IDomainObject> GetAllWhereLike(IDomainObject obj,string col, int year)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            //SELECT * FROM ClassGroup WHERE IdClassGroup LIKE '1%'
            command.CommandText = $"SELECT * FROM {obj.TableName} WHERE {col} LIKE '{year}%'";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }            
            }
            return result;
        }
        
        public List<IDomainObject> GetAllJoinWhereOrderByAsc(IDomainObject o1, IDomainObject o2, string c1, string c2, string whereCol, int whereVal, string orderCol)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            //select *from Teacher t join Subject s on t.IdSubject=s.IdSubject join ClassGroup cg on cg.IdClassGroup=t.IdClassHomeroomTeacher where s.IdSubject={subjectId} order by t.lastname asc";
            command.CommandText = $"select * from {o1.TableName} a join {o2.TableName} b on a.{c1}=b.{c2} where a.{whereCol}={whereVal} order by a.{orderCol} asc";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public List<IDomainObject> TableJoin4(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string sel1, string sel2, string c1, string c2, string c3, string whereCol, int value, string notNullCol)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select s.{sel1},m.{sel2} from {o1.TableName} m join {o2.TableName} c on (m.{c1} = c.{c1}) join {o3.TableName} t on (c.{c2} = t.{c2}) join subject s on (t.{c3} = s.{c3}) where m.{whereCol} = {value} and m.{notNullCol} is not null";
            //$"select s.subjectname,m.Value from mark m join Class c on (m.IdClass = c.IdClass) join teacher t on (c.IdTeacher = t.IdTeacher) join subject s on (t.IdSubject = s.IdSubject) where m.IdStudent = {idStudent} and m.FinalValue is not null";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectNoJoin(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public IDomainObject TableJoin4TripleWhere(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string sel1, string sel2, string c1, string c2, string c3, string whereCol, int value, string where2col, int value2, string notNullCol)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select m.{sel1},c.{sel2} from {o1.TableName} m join {o2.TableName} c on (m.{c1} = c.{c1}) join {o3.TableName} t on (c.{c2} = t.{c2}) join subject s on (t.{c3} = s.{c3}) where m.{whereCol} = {value} and s.{where2col}={value2} and m.{notNullCol} is not null";
            //$"select s.subjectname,m.Value from mark m join Class c on (m.IdClass = c.IdClass) join teacher t on (c.IdTeacher = t.IdTeacher) join subject s on (t.IdSubject = s.IdSubject) where m.IdStudent = {idStudent} and m.FinalValue is not null";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result[0];
        }

        public bool TableJoin4IsNotNull(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string c1, string c2, string c3, string whereCol, int val1, int val2, string notNullCol)
        {
            SqlCommand command = broker.CreateCommand();
            //$"select count(*) from mark m join Class c on (m.IdClass = c.IdClass) join teacher t on (c.IdTeacher = t.IdTeacher) join subject s on (t.IdSubject = s.IdSubject) where m.IdStudent = {idStudent} and s.IdSubject ={idSubject} and m.FinalValue is not null";
            command.CommandText = $"select count(*) from {o1.TableName} m join {o2.TableName} c on (m.{c1} = c.{c1}) join {o3.TableName} t on (c.{c2} = t.{c2}) join {o4.TableName} s on (t.{c3} = s.{c3}) where m.{whereCol} = {val1} and s.{c3} ={val2} and m.{notNullCol} is not null";
            int check = (int)command.ExecuteScalar();
            if (check == 1) return true;
            return false;
        }

        public int AddReturnInt(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} values ({obj.InsertValues})";
            //insert into [Class] output inserted.idClass values ('20120618 10:34:09',3457,12)
            int x = command.ExecuteNonQuery();
            return x;
        }

        public int GetMax(IDomainObject obj, string colMax, string colValLike, int value)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select max({colMax}) from {obj.TableName} where {colValLike} like '{value}_%'";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                int currentMax = (int)result;
                int firstFree = currentMax + 1;
                return firstFree;
            }
        }
        
        public int AddToSelColsReturnInt(IDomainObject obj, int v1, int v2, int v3, int v4, string v5)
        {
            SqlCommand command = broker.CreateCommand();
            //insert into mark values ({mark.Student.IdStudent},{mark.Class.IdClass},{mark.Value},{(int)mark.ExaminationType},'{mark.DateOfExamination}',null)";
            command.CommandText = $"insert into {obj.TableName} values ({v1},{v2},{v3},{v4},'{v5}',null)";
            //insert into [Class] output inserted.idClass values ('20120618 10:34:09',3457,12)
            int x = command.ExecuteNonQuery();
            return x;
        }

        public int AddToSelColsReturnIntLastColNotNull(IDomainObject obj, int v1, int v2, int v3, int v4, string v5)
        {
            SqlCommand command = broker.CreateCommand();
            //insert into mark values ({mark.Student.IdStudent},{mark.Class.IdClass},{mark.Value},{(int)mark.ExaminationType},'{mark.DateOfExamination}',null)";
            command.CommandText = $"insert into {obj.TableName} values ({v1},{v2},{v3},{v4},'{v5}',1)";
            //insert into [Class] output inserted.idClass values ('20120618 10:34:09',3457,12)
            int x = command.ExecuteNonQuery();
            return x;
        }

        public int AddToSelectedColsOutputInserted(IDomainObject obj, string outputInserted, string c1, string c2, string c3, string v1, int v2, int v3)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into [{obj.TableName}] ({c1},{c2},{c3}) output inserted.{outputInserted} values ('{v1}',{v2},{v3})";
            //insert into [Class] output inserted.idClass values ('20120618 10:34:09',3457,12)
            int Id = (int)command.ExecuteScalar();
            return Id;
        }
      
        public int AddToSelectedCols(IDomainObject obj, string c1, string c2, string c3, int v1, string v2, int v3)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} ({c1},{c2},{c3}) values ({v1},'{v2}',{v3})";
            return command.ExecuteNonQuery();
        }      

        public int GetNewId(IDomainObject obj, string column)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select max({column}) from {obj.TableName}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                int currentMax = (int)result;
                int firstFree = currentMax + 1;
                return firstFree;
            }
        }
        
        public List<IDomainObject> GetAllColIsNull4IDO(IDomainObject o1, IDomainObject o2,IDomainObject o3, IDomainObject o4, string c1, string c2, string c3, string w1, int v1, string w2, int v2, string nullCol)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            //$"select m.IdStudent,mfrom             mark        m join     Class c on (m.IdClass=c.IdClass) join teacher t on (c.IdTeacher=t.IdTeacher) join subject s on (t.IdSubject=s.IdSubject) where m.IdStudent={idStudent} and s.idsubject={idSubject} and m.finalvalue is null
            command.CommandText = $"select * from {o1.TableName} m join {o2.TableName} c on (m.{c1}=c.{c1}) join {o3.TableName} t on (c.{c2}=t.{c2}) join {o4.TableName} s on (t.{c3}=s.{c3}) where m.{w1}={v1} and s.{w2}={v2} and m.{nullCol} is null";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public List<IDomainObject> GetAllColIsNull4IDOSelect(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string star,string c1, string c2, string c3, string w1, int v1, string w2, int v2, string nullCol)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            //$"select m.IdStudent,mfrom             mark        m join     Class c on (m.IdClass=c.IdClass) join teacher t on (c.IdTeacher=t.IdTeacher) join subject s on (t.IdSubject=s.IdSubject) where m.IdStudent={idStudent} and s.idsubject={idSubject} and m.finalvalue is null
            command.CommandText = $"select {star} from {o1.TableName} m join {o2.TableName} c on (m.{c1}=c.{c1}) join {o3.TableName} t on (c.{c2}=t.{c2}) join {o4.TableName} s on (t.{c3}=s.{c3}) where m.{w1}={v1} and s.{w2}={v2} and m.{nullCol} is null";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public List<IDomainObject> GetAllColIsNull4IDOWhere(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string c1, string c2, string c3, string w1, int v1, string nullCol)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            //$"select m.IdStudent,mfrom             mark        m join     Class c on (m.IdClass=c.IdClass) join teacher t on (c.IdTeacher=t.IdTeacher) join subject s on (t.IdSubject=s.IdSubject) where m.IdStudent={idStudent} and s.idsubject={idSubject} and m.finalvalue is null
            command.CommandText = $"select * from {o1.TableName} m join {o2.TableName} c on (m.{c1}=c.{c1}) join {o3.TableName} t on (c.{c2}=t.{c2}) join {o4.TableName} s on (t.{c3}=s.{c3}) where m.{w1}={v1} and m.{nullCol} is null";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public void ChangeSetIsInt(IDomainObject obj, string col, int value, string whereCol, int whereValue)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"update {obj.TableName} set {col}={value} where {whereCol}={whereValue}";
            command.ExecuteNonQuery();
        }

        public void AddOneColIsNull(IDomainObject obj, string a, string b, string c, string d, string e, int f, int g)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} values ('{a}','{b}','{c}','{d}','{e}',{f},{g}, null)";
            int brojRedova = command.ExecuteNonQuery();
        }

        public bool GetCountJoin(IDomainObject o1, IDomainObject o2, string joinOn, string whereCol1, int whereVal1, string whereCol2, int whereVal2, string col)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select count(*) from  {o1.TableName} c join {o2.TableName} t on (c.{joinOn}=t.{joinOn}) where t.{whereCol1}={whereVal1} and c.{whereCol2}={whereVal2} and datediff(day, c.{col}, CURRENT_TIMESTAMP) = 0";
            int x = (int)command.ExecuteScalar();
            if (x == 1) return true;
            return false;
        }

        public bool GetCountJoin3Where(IDomainObject o1, IDomainObject o2, string joinOn, string whereCol1, int whereVal1, string whereCol2, int whereVal2, string col)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select count(*) from  {o1.TableName} c join {o2.TableName} t on (c.{joinOn}=t.{joinOn}) where t.{whereCol1}={whereVal1} and c.{whereCol2}={whereVal2} and datediff(day, c.{col}, CURRENT_TIMESTAMP) = 0";
            int x = (int)command.ExecuteScalar();
            if (x >= 1) return true;
            return false;
        }

        public List<IDomainObject> GetAllJoinOrderBy(IDomainObject o1, IDomainObject o2, string joinOn, string orderByCol)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {o1.TableName} t join {o2.TableName} s on t.{joinOn}=s.{joinOn} order by t.{orderByCol} asc";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public List<IDomainObject> GetAlltable3OrderByAsc(IDomainObject o1, IDomainObject o2, IDomainObject o3, string joinOn1, string joinOnDiff1, string joinOnDiff2, string ordBy)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            //select t.IdTeacher,t.FirstName,t.LastName,t.BirthDate,t.Address,t.PhoneNumber,t.AcademicLevel, s.SubjectName " +
            //"from Teacher t join Subject s on t.IdSubject=s.IdSubject order by t.LastName asc";
            command.CommandText = $"select * from {o1.TableName} t join {o2.TableName} s on (t.{joinOn1}=s.{joinOn1}) join {o3.TableName} cg on (cg.{joinOnDiff1}=t.{joinOnDiff2}) order by t.{ordBy} asc";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public List<IDomainObject> GetAlltable3WhereOrderByAsc(IDomainObject o1, IDomainObject o2, IDomainObject o3, string joinOn1, string joinOnDiff1, string joinOnDiff2, string whereCol, int whereVal, string ordBy)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            //select t.IdTeacher,t.FirstName,t.LastName,t.BirthDate,t.Address,t.PhoneNumber,t.AcademicLevel, s.SubjectName " +
            //"from Teacher t join Subject s on t.IdSubject=s.IdSubject order by t.LastName asc";
            command.CommandText = $"select * from {o1.TableName} t join {o2.TableName} s on (t.{joinOn1}=s.{joinOn1}) join {o3.TableName} cg on (cg.{joinOnDiff1}=t.{joinOnDiff2}) where s.{whereCol}={whereVal} order by t.{ordBy} asc";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = o1.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
        
        public IDomainObject GetAll2Where(IDomainObject obj, string c1,string v1, string c2, string v2)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} where {c1}='{v1}' and {c2}='{v2}'";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result[0];
        }

        public IDomainObject FindByStringCriteria(IDomainObject obj, string criteria)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} where {criteria}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectNoJoin(reader);
                    result.Add(rowObject);
                }
            }
            return result[0];
        }
    }
}
