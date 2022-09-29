namespace PersonelSystem.Models
{
    public interface ISystem<T>
    {
        Task<T> GetSingle(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T newEntity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);
    }
}
