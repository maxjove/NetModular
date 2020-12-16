namespace NetModular.Lib.Data.Abstractions.Options
{
    public class DbModuleOptions : DbConfig
    {
        /// <summary>
        /// 从库配置
        /// </summary>
        public DbConfig Slave { get; set; }
    }
}
