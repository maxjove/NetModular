namespace NetModular.Lib.Data.Abstractions
{
    /// <summary>
    /// 从库仓储接口
    /// </summary>
    /// <typeparam name="TRepository"></typeparam>
    public interface ISlaveRepository<out TRepository> where TRepository : IRepository
    {
        /// <summary>
        /// 仓储实例
        /// </summary>
        TRepository Value { get; }
    }
}
