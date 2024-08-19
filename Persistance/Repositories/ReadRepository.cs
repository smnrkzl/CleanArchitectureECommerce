using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CleanArchitecture.Persistance.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : Entity
{
    private readonly BaseDbContext _context;

    public ReadRepository(Context.BaseDbContext context)
    {
        _context = context;
    }



    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
       var query = Table.AsQueryable(); 
        if(!tracking)
            query= query.AsNoTracking();
        return query;
    }

    public async Task<T> GetByIdAsync(string id, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if(!tracking)
            query= query.AsNoTracking();
        return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if(!tracking)
            query= query.AsNoTracking();
        return await query.FirstOrDefaultAsync(method);
    }

    public  IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if(!tracking)
            query= query.AsNoTracking();
        return query;
    }

}
