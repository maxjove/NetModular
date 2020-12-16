using System.Data;
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using NetModular.Lib.Auth.Abstractions;
using NetModular.Lib.Data.Abstractions.Options;
using NetModular.Lib.Data.Core;

namespace NetModular.Lib.Data.SQLite
{
    /// <summary>
    /// SQLite数据库上下文配置项
    /// </summary>
    public class SQLiteDbContextOptions : DbContextOptionsAbstract
    {
        public SQLiteDbContextOptions(DbOptions dbOptions, DbConfig dbConfig, ILoggerFactory loggerFactory, ILoginInfo loginInfo) : base(dbOptions, dbConfig, new SQLiteAdapter(dbOptions, dbConfig, loggerFactory), loggerFactory, loginInfo)
        {
            SqlMapper.AddTypeHandler(new GuidTypeHandler());
        }

        public override IDbConnection NewConnection()
        {
            return new SqliteConnection(DbConfig.ConnectionString);
        }
    }
}
