using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.coninterf
{
    public class Messenger
    {
        private INotifier _notify;

        public Messenger(INotifier notifier)
        {
            _notify = notifier;
        }
        public  void SendMessage(string message)
        {
            _notify.Notify(message);
        }
    }
}
