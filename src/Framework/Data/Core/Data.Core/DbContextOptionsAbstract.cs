using System;
using System.Data;
using Microsoft.Extensions.Logging;
using NetModular.Lib.Auth.Abstractions;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Abstractions.Options;

namespace NetModular.Lib.Data.Core
{
    public abstract class DbContextOptionsAbstract : IDbContextOptions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbOptions"></param>
        /// <param name="dbConfig"></param>
        /// <param name="sqlAdapter">数据库适配器</param>
        /// <param name="loggerFactory">日志工厂</param>
        /// <param name="loginInfo">登录信息</param>
        protected DbContextOptionsAbstract(DbOptions dbOptions, DbConfig dbConfig, ISqlAdapter sqlAdapter, ILoggerFactory loggerFactory, ILoginInfo loginInfo)
        {
            if (dbConfig.Name.IsNull())
                throw new ArgumentNullException(nameof(dbConfig.Name), "数据库连接名称未配置");

            DbOptions = dbOptions;
            DbConfig = dbConfig;
            SqlAdapter = sqlAdapter;
            LoggerFactory = loggerFactory;
            LoginInfo = loginInfo;

            //创建链接字符串
            sqlAdapter.ConnectionStringBuild();
        }

        public DbConfig DbConfig { get; }

        public IDatabaseCreateEvents DatabaseCreateEvents { get; set; }

        public ISqlAdapter SqlAdapter { get; }

        public abstract IDbConnection NewConnection();

        public ILoggerFactory LoggerFactory { get; }

        public ILoginInfo LoginInfo { get; set; }

        public DbOptions DbOptions { get; }
    }
}
