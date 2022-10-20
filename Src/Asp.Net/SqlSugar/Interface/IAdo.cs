using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SqlSugar
{
    public partial interface IAdo
    {
        string SqlParameterKeyWord { get; }
        IDbConnection Connection { get; set; }
        IDbTransaction Transaction { get; set; }
        IDataParameter[] ToIDbDataParameter(params SugarParameter[] pars);
        SugarParameter[] GetParameters(object obj, PropertyInfo[] propertyInfo = null);
        SqlSugarProvider Context { get; set; }
        void ExecuteBefore(string sql, SugarParameter[] pars);
        void ExecuteAfter(string sql, SugarParameter[] pars);
        bool IsAnyTran();
        bool IsNoTran();
        bool IsEnableLogEvent{get;set;}
        StackTraceInfo SqlStackTrace { get; }
        IDataParameterCollection DataReaderParameters { get; set; }
        CommandType CommandType { get; set; }
        CancellationToken? CancellationToken { get; set; }
        bool IsDisableMasterSlaveSeparation { get; set; }
        bool IsClearParameters { get; set; }
        int CommandTimeOut { get; set; }
        TimeSpan SqlExecutionTime { get; }
        IDbBind DbBind { get; }
        void SetCommandToAdapter(IDataAdapter adapter, DbCommand command);
        IDataAdapter GetAdapter();
        DbCommand GetCommand(string sql, SugarParameter[] parameters);


        DataTable GetDataTable(string sql, object parameters);
        DataTable GetDataTable(string sql, params SugarParameter[] parameters);
        DataTable GetDataTable(string sql, List<SugarParameter> parameters);

        Task<DataTable> GetDataTableAsync(string sql, object parameters);
        Task<DataTable> GetDataTableAsync(string sql, params SugarParameter[] parameters);
        Task<DataTable> GetDataTableAsync(string sql, List<SugarParameter> parameters);

        DataSet GetDataSetAll(string sql, object parameters);
        DataSet GetDataSetAll(string sql, params SugarParameter[] parameters);
        DataSet GetDataSetAll(string sql, List<SugarParameter> parameters);

        Task<DataSet> GetDataSetAllAsync(string sql, object parameters);
        Task<DataSet> GetDataSetAllAsync(string sql, params SugarParameter[] parameters);
        Task<DataSet> GetDataSetAllAsync(string sql, List<SugarParameter> parameters);

        IDataReader GetDataReader(string sql, object parameters);
        IDataReader GetDataReader(string sql, params SugarParameter[] parameters);
        IDataReader GetDataReader(string sql, List<SugarParameter> parameters);


        Task<IDataReader> GetDataReaderAsync(string sql, object parameters);
        Task<IDataReader> GetDataReaderAsync(string sql, params SugarParameter[] parameters);
        Task<IDataReader> GetDataReaderAsync(string sql, List<SugarParameter> parameters);


        object GetScalar(string sql, object parameters);
        object GetScalar(string sql, params SugarParameter[] parameters);
        object GetScalar(string sql, List<SugarParameter> parameters);

        Task<object> GetScalarAsync(string sql, object parameters);
        Task<object> GetScalarAsync(string sql, params SugarParameter[] parameters);
        Task<object> GetScalarAsync(string sql, List<SugarParameter> parameters);

        int ExecuteCommandWithGo(string sql, params SugarParameter[] parameters);
        int ExecuteCommand(string sql, object parameters);
        int ExecuteCommand(string sql, params SugarParameter[] parameters);
        int ExecuteCommand(string sql, List<SugarParameter> parameters);

        Task<int> ExecuteCommandAsync(string sql, params SugarParameter[] parameters);
        Task<int> ExecuteCommandAsync(string sql, object parameters);
        Task<int> ExecuteCommandAsync(string sql, List<SugarParameter> parameters);

        string GetString(string sql, object parameters);
        string GetString(string sql, params SugarParameter[] parameters);
        string GetString(string sql, List<SugarParameter> parameters);
        Task<string> GetStringAsync(string sql, object parameters);
        Task<string> GetStringAsync(string sql, params SugarParameter[] parameters);
        Task<string> GetStringAsync(string sql, List<SugarParameter> parameters);


        int GetInt(string sql, object pars);
        int GetInt(string sql, params SugarParameter[] parameters);
        int GetInt(string sql, List<SugarParameter> parameters);

        Task<int> GetIntAsync(string sql, object pars);
        Task<int> GetIntAsync(string sql, params SugarParameter[] parameters);
        Task<int> GetIntAsync(string sql, List<SugarParameter> parameters);


        long GetLong(string sql, object pars=null);

        Task<long> GetLongAsync(string sql, object pars=null);


        Double GetDouble(string sql, object parameters);
        Double GetDouble(string sql, params SugarParameter[] parameters);
        Double GetDouble(string sql, List<SugarParameter> parameters);


        Task<Double> GetDoubleAsync(string sql, object parameters);
        Task<Double> GetDoubleAsync(string sql, params SugarParameter[] parameters);
        Task<Double> GetDoubleAsync(string sql, List<SugarParameter> parameters);


        decimal GetDecimal(string sql, object parameters);
        decimal GetDecimal(string sql, params SugarParameter[] parameters);
        decimal GetDecimal(string sql, List<SugarParameter> parameters);

        Task<decimal> GetDecimalAsync(string sql, object parameters);
        Task<decimal> GetDecimalAsync(string sql, params SugarParameter[] parameters);
        Task<decimal> GetDecimalAsync(string sql, List<SugarParameter> parameters);


        DateTime GetDateTime(string sql, object parameters);
        DateTime GetDateTime(string sql, params SugarParameter[] parameters);
        DateTime GetDateTime(string sql, List<SugarParameter> parameters);

        Task<DateTime> GetDateTimeAsync(string sql, object parameters);
        Task<DateTime> GetDateTimeAsync(string sql, params SugarParameter[] parameters);
        Task<DateTime> GetDateTimeAsync(string sql, List<SugarParameter> parameters);


        Tuple<List<T>, List<T2>> SqlQuery<T,T2>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>> SqlQuery<T, T2,T3>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>,List<T4>> SqlQuery<T,T2,T3,T4>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>> SqlQuery<T, T2, T3, T4,T5>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>> SqlQuery<T, T2, T3, T4, T5,T6>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>> SqlQuery<T, T2, T3, T4, T5, T6,T7>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>, Tuple<List<T15>>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>, Tuple<List<T15>, List<T16>>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>, Tuple<List<T15>, List<T16>, List<T17>>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>, Tuple<List<T15>, List<T16>, List<T17>, List<T18>>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>, Tuple<List<T15>, List<T16>, List<T17>, List<T18>, List<T19>>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>, Tuple<List<T15>, List<T16>, List<T17>, List<T18>, List<T19>, List<T20>>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(string sql, object parameters = null);
        Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>, Tuple<List<T15>, List<T16>, List<T17>, List<T18>, List<T19>, List<T20>, List<T21>>>> SqlQuery<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(string sql, object parameters = null);

        Task<Tuple<List<T>, List<T2>>> SqlQueryAsync<T, T2>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>>> SqlQueryAsync<T, T2, T3>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>>> SqlQueryAsync<T, T2, T3, T4>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>>> SqlQueryAsync<T, T2, T3, T4, T5>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>>> SqlQueryAsync<T, T2, T3, T4, T5, T6>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7, T8>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7, T8, T9>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string sql, object parameters = null);
        Task<Tuple<List<T>, List<T2>, List<T3>, List<T4>, List<T5>, List<T6>, List<T7>, Tuple<List<T8>, List<T9>, List<T10>, List<T11>, List<T12>, List<T13>, List<T14>>>> SqlQueryAsync<T, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string sql, object parameters = null);

        List<T> SqlQuery<T>(string sql, object parameters = null);
        List<T> SqlQuery<T>(string sql, params SugarParameter[] parameters);
        List<T> SqlQuery<T>(string sql, List<SugarParameter> parameters);

        Task<List<T>> SqlQueryAsync<T>(string sql, object parameters = null);
        Task<List<T>> SqlQueryAsync<T>(string sql, List<SugarParameter> parameters);
        Task<List<T>> SqlQueryAsync<T>(string sql, params SugarParameter[] parameters);

        T SqlQuerySingle<T>(string sql, object whereObj = null);
        T SqlQuerySingle<T>(string sql, params SugarParameter[] parameters);
        T SqlQuerySingle<T>(string sql, List<SugarParameter> parameters);

        Task<T> SqlQuerySingleAsync<T>(string sql, object whereObj = null);
        Task<T> SqlQuerySingleAsync<T>(string sql, params SugarParameter[] parameters);
        Task<T> SqlQuerySingleAsync<T>(string sql, List<SugarParameter> parameters);

        void RemoveCancellationToken();

        void Dispose();
        void Close();
        void Open();
        SugarConnection OpenAlways();
        bool IsValidConnection();
        bool IsValidConnectionNoClose();
        void CheckConnection();

        void BeginTran();
        void BeginTran(IsolationLevel iso);
        void BeginTran(string transactionName);
        void BeginTran(IsolationLevel iso, string transactionName);
        void RollbackTran();
        void CommitTran();

        DbResult<bool> UseTran(Action action, Action<Exception> errorCallBack = null);
        DbResult<T> UseTran<T>(Func<T> action, Action<Exception> errorCallBack = null);
        Task<DbResult<bool>> UseTranAsync(Func<Task> action, Action<Exception> errorCallBack = null);
        Task<DbResult<T>> UseTranAsync<T>(Func<Task<T>> action, Action<Exception> errorCallBack = null);
        IAdo UseStoredProcedure();
         
    }
}
