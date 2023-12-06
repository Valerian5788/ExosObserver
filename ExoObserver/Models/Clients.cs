using ExoObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObserver.Models
{
    internal class Clients
    {
        public string Name { get; set; }

        public Clients(string name)
        {
            Name = name;
        }

        public void Update(ISubject sender, EventArgs e)
        {

            if (sender is SiteWeb siteWeb)
            {
                Console.WriteLine($"Client {Name}, à reçu un email envoyé par {siteWeb.Name}");
            }
            else if (sender is Magazine magazine)
            {
                Console.WriteLine($"Client {Name}, à reçu un email envoyé par {magazine.Name}");
            }
        }
    }
}
