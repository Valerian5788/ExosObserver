using ExoObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObserver.Models
{
    internal class Pub : IObserver
    {
        public void Update(ISubject sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public string Name { get; set; }
        public Pub(string name)
        {
            Name = name;
        }
        public Action<ISubject, EventArgs> ObserversDelegate { get; set; } = null;

        public void Attach(IObserver observer)
        {
            ObserversDelegate += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            if (ObserversDelegate is not null)
            {
                ObserversDelegate -= observer.Update;
            }
        }
    }
}
