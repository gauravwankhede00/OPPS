using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.Collections.Generic;
using TechYatraAPI.Context;
using TechYatraAPI.Interface;
using TechYatraAPI.Model;

namespace TechYatraAPI.Service
{
    public class ToDoService : GenericRepository<ToDo>, IToDoService
    {
        private readonly IMemoryCache _cache;
        private readonly ToDoContext _toDoContext;
        public ToDoService(ToDoContext toDoContext, IMemoryCache cache) : base(toDoContext)
        {
            _cache = cache;
            _toDoContext = toDoContext;
        }

        public async Task<List<ToDo>> GetAllTasksBYGAURAV()
        {

            if (!_cache.TryGetValue("key", out List<ToDo> cachedValue))
            {
                cachedValue = await _toDoContext.ToDos.ToListAsync();
                _cache.Set("key", cachedValue, TimeSpan.FromMinutes(1));
            }
            return cachedValue;

            //var jsonData = await _cache.GetStringAsync("key");

            //if (jsonData == null)
            //{
            //    var list = _toDoContext.ToDos.ToList();
            //    await _cache.SetStringAsync("key", JsonConvert.SerializeObject(list), new DistributedCacheEntryOptions
            //    {
            //        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1)
            //    });
            //    return list;
            //}
            //else
            //{
            //    return JsonConvert.DeserializeObject<List<ToDo>>(jsonData);
            //}

        }

        //public bool DeleteTaskById(int id)
        //{
        //    var result = _toDoContext.ToDos.SingleOrDefault(t => t.Id == id);
        //    if (result == null)
        //    {
        //        throw new Exception("Update the valid data");
        //    }
        //    try
        //    {
        //        _toDoContext.Remove(result);
        //        _toDoContext.SaveChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }


        //}



        //public ToDo ToDoGetTaskById(int id)
        //{
        //    var todo = _toDoContext.ToDos.SingleOrDefault(t => t.Id == id);
        //    return todo;
        //}

        //public ToDo UpdateTask(ToDo todo)
        //{
        //    var result = _toDoContext.ToDos.AsNoTracking().SingleOrDefault(t => t.Id == todo.Id);
        //    if (result == null)
        //    {
        //        throw new Exception("Update the valid data");
        //    }
        //   var updatedData =  _toDoContext.Update(todo);
        //    _toDoContext.SaveChanges();
        //    return updatedData.Entity;
        //}
    }
}
