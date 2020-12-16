using System;
using System.Collections.Generic;

namespace NetModular.Lib.Data.Abstractions.Options
{
    /// <summary>
    /// 数据库配置
    /// </summary>
    public class DbConfig
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// 表前缀
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// 数据库版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// MySql字符编码
        /// </summary>
        public string MySqlCharacterSet { get; set; } = "utf8";

        /// <summary>
        /// MySqlSslMode
        /// </summary>
        public string MySqlSslMode { get; set; }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 是否从库
        /// </summary>
        public bool IsSlave { get; set; }

        /// <summary>
        /// 实体类型列表
        /// </summary>
        public List<Type> EntityTypes { get; set; }
    }
}
