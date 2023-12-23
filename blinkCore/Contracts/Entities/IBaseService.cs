namespace blinkCore.Contracts.Entities
{
    public interface IBaseService<T>
    {
        void Create(T entity);
        void Delete(Guid id);
        void Update(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
