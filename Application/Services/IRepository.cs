using CleanArchitecture.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Services;

public interface IRepository<T> where T : Entity
{
    DbSet<T> Table {  get; }

}
