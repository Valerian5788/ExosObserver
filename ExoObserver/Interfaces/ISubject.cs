using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObserver.Interfaces
{
    public interface ISubject
    {
        // Déclaration d'une propriété de type Action
        // Cette propriété stocke une délégation (delegate) prenant deux paramètres : ISubject et EventArgs
        protected Action<ISubject, EventArgs> ObserversDelegate { get; set; }

        // Méthode pour attacher un observateur (observer)
        public void Attach(IObserver observer);

        // Méthode pour détacher un observateur
        public void Detach(IObserver observer);

        // Méthode pour notifier tous les observateurs
        public void Notify();
    }

}
