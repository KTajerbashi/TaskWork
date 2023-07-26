using Domain.Model;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace BusinessLogic.Library
{
    public class TaskWorkService : GenericRepository<TaskWork>
    {
        //public void test()
        //{
        //    var result=   _context.Set<Samana>().Include("TaskWorks").Where(itemw=>itemw.ID==1).Single();

        //    TaskWork entity = new TaskWork();
        //    entity.Title = "Hello";
        //    entity.Description = "hi";
        //    entity.Created = DateTime.Now;
        //    entity.CreateDate = DateTime.Now;
        //    entity.CreatedByUserRoleID = 1;
        //    entity.IsActive = true;
        //    entity.IsDeleted = false;
        //    entity.IsPassed = false;
        //    entity.IsDeliver = false;


        //    result.TaskWorks.Add(entity);


        //    _context.Entry(result).State = System.Data.Entity.EntityState.Deleted;
        //    _context.SaveChanges();
        //    var x=10;

        //}
    }
}
