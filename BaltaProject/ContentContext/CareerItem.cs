using BaltaProject.NotificationContext;
using BaltaProject.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaProject.ContentContext
{
    public class CareerItem : BaseContent
    {
        public CareerItem(int order, string title, string description, Course courses)
        {
            if (courses == null)
                AddNotification(new Notification("Course", "Curso inválido"));

            Order = order;
            Title = title;
            Description = description;
            Courses = courses;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Courses { get; set; }

        public int Level { get; set; }
    }
}
