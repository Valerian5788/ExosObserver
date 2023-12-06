using ExoObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObserver.Models
{
    public class Magazine : ISubject
    {
        public string Name { get; set; }
        public int Choix { get; set; }
        public Magazine(string name)
        {
            Name = name;
        }
        public Action<ISubject, EventArgs> ObserversDelegate { get; set; } = null;
        public Action<ISubject, EventArgs> AdsObserversDelegate { get; set; } = null;
        public Action<ISubject, EventArgs> NewsObserversDelegate { get; set; } = null;
        public void Attach(IObserver observer)
        {
            ObserversDelegate += observer.Update;
        }

        public void AdsAttach(IObserver observer)
        {
            AdsObserversDelegate += observer.UpdateAds;
        }
        public void NewsAttach(IObserver observer)
        {
            NewsObserversDelegate += observer.UpdateNews;
        }

        public void Detach(IObserver observer)
        {
            if (ObserversDelegate is not null)
            {
                ObserversDelegate -= observer.Update;
            }
        }

        public void Notify()
        {
            if (ObserversDelegate is not null)
            {
                ObserversDelegate.Invoke(this, new EventArgs());
            }
        }
        public void NotifyAds()
        {
            if (AdsObserversDelegate is not null)
            {
                AdsObserversDelegate.Invoke(this, new EventArgs());
            }
        }
        public void NotifyNews()
        {
            if (NewsObserversDelegate is not null)
            {
                NewsObserversDelegate.Invoke(this, new EventArgs());
            }
        }
    }
}
