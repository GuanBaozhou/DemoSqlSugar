using SqlSugar;

namespace Demo.ORM
{
    public class SqlSugarBase
    {
        public static string DB_ConnectionString { get; set; }

        public static SqlSugarClient DB
        {
            get => new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = DB_ConnectionString,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.SystemTable,
                IsShardSameThread = true
            }
            );
        }
    }
}
