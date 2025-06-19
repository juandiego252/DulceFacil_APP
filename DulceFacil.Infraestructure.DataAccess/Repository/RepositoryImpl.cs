using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Domain.Models.Abstractions;
using DulceFacil.Infraestructure.DataAccess.DataEFCore;
using Microsoft.EntityFrameworkCore;

namespace DulceFacil.Infraestructure.DataAccess.Repository
{
    public class RepositoryImpl<T> : IRepository<T> where T : class
    {
        private readonly DulceFacilContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryImpl(DulceFacilContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error adding data: " + e.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = _dbSet.Find(id) ?? throw new Exception("Entity not found");
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {
                throw new Exception("Error deleting data: " + e.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error retrieving data: " + e.Message);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                var result = await _dbSet.FindAsync(id) ?? throw new Exception("Entity not found");
                return result;

            }
            catch (Exception e)
            {
                throw new Exception("Error retrieving data: " + e.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error updating data: " + e.Message);
            }
        }
    }
}
