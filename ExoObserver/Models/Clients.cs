using ExoObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObserver.Models
{
    internal class Clients : IObserver
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
            else
            {
                Console.WriteLine("Notifié par originie inconnue");
            }
        }
        public void UpdateAds(ISubject sender, EventArgs e)
        {
            if (sender is Magazine magazine)
            {
                Console.WriteLine($"Client {Name}, à reçu un email envoyé par {magazine.Name} pour une pub");
            }
            else
            {
                Console.WriteLine("Notifié par originie inconnue");
            }
        }
        public void UpdateNews(ISubject sender, EventArgs e)
        {
            if (sender is Magazine magazine)
            {
                Console.WriteLine($"Client {Name}, à reçu un email envoyé par {magazine.Name} pour une news");
            }
            else
            {
                Console.WriteLine("Notifié par originie inconnue");
            }
        }
    }
}
