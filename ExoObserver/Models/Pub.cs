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
    }
}
