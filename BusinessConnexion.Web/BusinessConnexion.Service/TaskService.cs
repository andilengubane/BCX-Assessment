
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BusinessConnexion.DTO;
using BusinessConnexion.EntityFrameWork;

namespace BusinessConnexion.Service
{
    public class TaskService
    {
        private readonly static BcxConnexionEntities context = new BcxConnexionEntities();
        public static IEnumerable<SelectListItem> GetTask()
        {
            var query = context.Task.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            return new SelectList(query, "Value", "Text");
        }

        public static void AddTask(TaskDTO task)
        {
            if (task.Id == 0)
            {
                context.Task.Add(new Task
                {
                    Name = task.Name,
                    Description = task.Description,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        public static void EditEmployee(int taskId, TaskDTO task)
        {
            if (task.Id > 0)
            {
                var data = context.Task.Find(taskId);
                data.Id = task.Id;
                data.Name = task.Name;
                data.Description = task.Description;
                context.SaveChanges();
            }
        }
    }
}
