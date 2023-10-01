using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace BusinessLogic.Library
{
    public class TaskWorkService : GenericRepository<TaskWork>
    {
        public List<TaskWork> GetAllIncluded()
        {
            return _context.Tasks.Include("Samaneh").Where(x => !x.IsDeleted).OrderByDescending(x => !x.IsPassed).ThenByDescending(x => !x.IsDeliver).Take(14).ToList();
        }
    }
}
