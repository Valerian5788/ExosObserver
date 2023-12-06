using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObserver.Interfaces
{
    public interface IObserver
    {
        // Méthode Update qui prend deux paramètres :
        // - sender : un objet de type ISubject (sujet)
        // - e : un objet de type EventArgs (arguments d'événement)
        void Update(ISubject sender, EventArgs e);
    }
}
