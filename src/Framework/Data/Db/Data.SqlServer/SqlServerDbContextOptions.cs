using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using NetModular.Lib.Auth.Abstractions;
using NetModular.Lib.Data.Abstractions.Options;
using NetModular.Lib.Data.Core;

namespace NetModular.Lib.Data.SqlServer
{
    /// <summary>
    /// 数据库上下文配置项SqlServer实现
    /// </summary>
    public class SqlServerDbContextOptions : DbContextOptionsAbstract
    {
        public SqlServerDbContextOptions(DbOptions dbOptions, DbConfig dbConfig, ILoggerFactory loggerFactory, ILoginInfo loginInfo) : base(dbOptions, dbConfig, new SqlServerAdapter(dbOptions, dbConfig, loggerFactory), loggerFactory, loginInfo)
        {
        }

        public override IDbConnection NewConnection()
        {
            return new SqlConnection(DbConfig.ConnectionString);
        }
    }
}