using BaltaProject.NotificationContext;
using BaltaProject.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaProject.SubsctiptionContext
{
    public class Student : BaseContent
    {
        public string name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(x=> !x.IsInactive);

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura premium"));
                return;
            }
            
            Subscriptions.Add(subscription);
        }
    }
}
