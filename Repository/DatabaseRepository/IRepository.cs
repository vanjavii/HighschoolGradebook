using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DatabaseRepository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(IDomainObject obj);
        void Save(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(string kriterijum);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
        List<T> GetAllOrderBy(IDomainObject obj, string ordBy);        
        List<T> GetAllWhereStringCriteria(IDomainObject obj, string criteria);
        void Change(IDomainObject obj, string changeType, string textChange, string criteriaType, int criteriaValue);
        IDomainObject FindByCriteria(IDomainObject obj, string column, int id);        
        List<T> GetAllCriteriaNull(IDomainObject obj, string criteria);
        void DeleteByCriteria(IDomainObject obj, string column, int value);
        IDomainObject FindJoinWhere(IDomainObject o1, IDomainObject o2, string o1col, string o2col, string where, int value);
        int AddOutputInserted(IDomainObject obj);
        void Change3valWhere(IDomainObject obj, string c1, string v1, string c2, string v2, string c3, int v3, string whereCol, int whereVal);
        string GetColumnValueWhere(IDomainObject obj, string col, string whereCol, int whereValue);
        bool GetColumnWhereBool(IDomainObject obj, string col, string whereCol, int whereValue);        
        List<T> GetAllWhereLike(IDomainObject obj, string col, int year);
        List<T> GetAllJoinWhereOrderByAsc(IDomainObject o1, IDomainObject o2, string c1, string c2, string whereCol, int whereVal, string orderCol);
        List<T> TableJoin4(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string sel1, string sel2, string c1, string c2, string c3, string whereCol, int value, string notNullCol);
        bool TableJoin4IsNotNull(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string c1, string c2, string c3, string whereCol, int val1, int val2, string notNullCol);
        int AddReturnInt(IDomainObject obj);
        int GetMax(IDomainObject obj, string colMax, string colValLike, int value);
        int AddToSelColsReturnInt(IDomainObject obj, int v1, int v2, int v3, int v4, string v5);
        int AddToSelectedColsOutputInserted(IDomainObject obj, string outputInserted, string c1, string c2, string c3, string v1, int v2, int v3);
        int GetNewId(IDomainObject obj, string column);
        List<T> GetAllColIsNull4IDO(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string c1, string c2, string c3, string w1, int v1, string w2, int v2, string nullCol);
        void ChangeSetIsInt(IDomainObject obj, string col, int value, string whereCol, int whereValue);
        int AddToSelectedCols(IDomainObject obj, string c1, string c2, string c3, int v1, string v2, int v3);
        void AddOneColIsNull(IDomainObject obj, string a, string b, string c, string d, string e, int f, int g);
        bool GetCountJoin(IDomainObject o1, IDomainObject o2, string joinOn, string whereCol1, int whereVal1, string whereCol2, int whereVal2, string col);
        List<T> GetAllJoinOrderBy(IDomainObject o1, IDomainObject o2, string joinOn, string orderByCol);
        List<T> GetAlltable3OrderByAsc(IDomainObject o1, IDomainObject o2, IDomainObject o3, string joinOn1, string joinOnDiff1, string joinOnDiff2, string ordBy);
        List<T> GetAllColIsNull4IDOWhere(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string c1, string c2, string c3, string w1, int v1, string nullCol);
        List<T> GetAlltable3WhereOrderByAsc(IDomainObject o1, IDomainObject o2, IDomainObject o3, string joinOn1, string joinOnDiff1, string joinOnDiff2, string whereCol, int whereVal, string ordBy);
        IDomainObject GetAll2Where(IDomainObject obj, string c1, string v1, string c2, string v2);
        int SaveColIsNull(IDomainObject obj, string sequence);
        List<IDomainObject> GetAllColIsNull4IDOSelect(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string star, string c1, string c2, string c3, string w1, int v1, string w2, int v2, string nullCol);
        int AddToSelColsReturnIntLastColNotNull(IDomainObject obj, int v1, int v2, int v3, int v4, string v5);
        IDomainObject TableJoin4TripleWhere(IDomainObject o1, IDomainObject o2, IDomainObject o3, IDomainObject o4, string sel1, string sel2, string c1, string c2, string c3, string whereCol, int value, string where2col, int value2, string notNullCol);
        bool GetCountJoin3Where(IDomainObject o1, IDomainObject o2, string joinOn, string whereCol1, int whereVal1, string whereCol2, int whereVal2, string col);
        void SaveAllColl(IDomainObject obj, string a, string b, string c, string d, string e, int f);
        IDomainObject FindByStringCriteria(IDomainObject obj, string criteria);
        IDomainObject FindJoinStringWhere(IDomainObject o1, IDomainObject o2, string o1col, string o2col, string criteria);
    }
}
