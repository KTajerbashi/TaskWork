﻿using BusinessLogic.Library;
using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastrucure.Library.Repository.TaskService
{
    public class TaskService : BaseService<TaskWork, DatabaseContext>
    {
        private readonly TaskHistoryService _taskHistoryService = new TaskHistoryService();


        public Result<List<TaskWork>> GetAllIncluded()
        {
            var data = _context.Tasks.Include("Samaneh")
                .Where(x => x.IsActive && !x.IsDeleted && !x.IsPassed)
                .OrderBy(x => x.CreateDate).Take(14)
                .ToList();
            return new Result<List<TaskWork>>
            {
                Data = data,
                Message = "",
                Success = true,
            };
        }

        public Result<TaskWork> GetById(long Id)
        {
            var res = _context.Tasks.Include("Samaneh").FirstOrDefault(x => x.ID == Id);
            return new Result<TaskWork>
            {
                Data = res,
                Message= "",
                Success = true,
            };
        }
        public override async Task<int> AddOrUpdate(TaskWork entity)
        {
            //var his = new TaskWorkHistory
            //{
                
            //};
            //await _taskHistoryService.Insert(his);
            return await base.AddOrUpdate(entity);
        }
    }
}
