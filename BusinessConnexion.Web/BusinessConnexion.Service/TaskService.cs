
using System;
using BusinessConnexion.DTO;
using BusinessConnexion.EntityFrameWork;

namespace BusinessConnexion.Service
{
    public class TaskService
    {
        private readonly static BcxConnexionEntities context = new BcxConnexionEntities();
        public static void AddEmployee(TaskDTO task)
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
