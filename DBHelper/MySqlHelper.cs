using System;
using System.Collections.Generic;
using System.Text;

namespace XQ.DBHelper
{
    public class MySqlHelper:ADBHelper,IDBHelper
    {
        public int GetMaxID(string FieldName, string TableName)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string strSql)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string strSql, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSql(string connectionstr, string SQLString)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSql(string connectionstr, System.Data.CommandType cmdType, string SQLString)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSql(string connectionstr, System.Data.CommandType cmdType, string SQLString, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlByTime(string SQLString, int Times)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlByTime(string connectionstr, string SQLString, int Times)
        {
            throw new NotImplementedException();
        }

        public void ExecuteSqlTran(List<string> SQLStringList)
        {
            throw new NotImplementedException();
        }

        public void ExecuteSqlTran(System.Collections.Hashtable SQLStringList)
        {
            throw new NotImplementedException();
        }

        public void ExecuteSqlTran(string connectionstr, System.Collections.Hashtable SQLStringList, System.Data.CommandType cmdType)
        {
            throw new NotImplementedException();
        }

        public object GetSingle(string SQLString)
        {
            throw new NotImplementedException();
        }

        public object GetSingle(string SQLString, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public object GetSingle(string connectionstr, System.Data.CommandType cmdType, string SQLString, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public System.Data.Common.DbDataReader ExecuteReader(string SQLString, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public System.Data.Common.DbDataReader ExecuteReader(string connectionstr, System.Data.CommandType cmdType, string SQLString, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet Query(string SQLString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet Query(string SQLString, int Times)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet Query(string SQLString, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet Query(string connectionstr, string SQLString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet Query(string connectionstr, System.Data.CommandType cmdType, string SQLString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet Query(string connectionstr, System.Data.CommandType cmdType, string SQLString, params System.Data.IDbDataParameter[] cmdParms)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetPagingList(string primaryKey, string queryFields, string tableName, string condition, string orderBy, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetPagingList(string connectionString, string primaryKey, string queryFields, string tableName, string condition, string orderBy, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

        public int GetRecordCount(string connectionString, string _ID, string _tbName, string _strCondition, int _Dist)
        {
            throw new NotImplementedException();
        }

        public int GetRecordCount(string _ID, string _tbName, string _strCondition, int _Dist)
        {
            throw new NotImplementedException();
        }

        public override string getPageListSql(string primaryKey, string queryFields, string tableName, string condition, string orderBy, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }
    }
}
