using HotelListing.API.Core.Models;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HotelListing.API.Core.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        
        //Refactored
        Task<TResult> GetAsync<TResult>(int? id);

        Task<List<T>> GetAllAsync();

        //Refactored
        Task<List<TResult>> GetAllAsync<TResult>();

        //Previously Refactored
        Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);
        
        Task<T> AddAsync(T entity);

        //Refactored
        Task<TResult> AddAsync<TSource, TResult>(TSource source);

        Task DeleteAsync(int id);

        Task UpdateAsync(T entity);

        //Refactored
        Task UpdateAsync<TSource>(int id, TSource source);

        Task<bool> Exists(int id);
    }
}
