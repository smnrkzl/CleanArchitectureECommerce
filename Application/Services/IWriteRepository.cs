﻿using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Application.Services;

public interface IWriteRepository<T>: IRepository<T> where T : Entity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T model);
    bool RemoveRange(List<T> datas);
    Task<bool> RemoveAsync(string id);
    bool Update(T model);
    Task<int> SaveAsync();


}
