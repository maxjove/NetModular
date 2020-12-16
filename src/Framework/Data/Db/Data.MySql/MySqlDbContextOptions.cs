using System.Data;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using NetModular.Lib.Auth.Abstractions;
using NetModular.Lib.Data.Abstractions.Options;
using NetModular.Lib.Data.Core;

namespace NetModular.Lib.Data.MySql
{
    /// <summary>
    /// MySql数据库上下文配置项
    /// </summary>
    public class MySqlDbContextOptions : DbContextOptionsAbstract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbOptions"></param>
        /// <param name="dbConfig"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="loginInfo"></param>
        public MySqlDbContextOptions(DbOptions dbOptions, DbConfig dbConfig, ILoggerFactory loggerFactory, ILoginInfo loginInfo) : base(dbOptions, dbConfig, new MySqlAdapter(dbOptions, dbConfig, loggerFactory), loggerFactory, loginInfo)
        {
        }

        public override IDbConnection NewConnection()
        {
            return new MySqlConnection(DbConfig.ConnectionString);
        }
    }
}
