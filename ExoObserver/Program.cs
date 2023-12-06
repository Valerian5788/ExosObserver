using ExoObserver.Models;
using ExoObserver.Interfaces;


SiteWeb JournalSoir = new SiteWeb("Journal du Soir");
Magazine JournalMatin = new Magazine("Journal du Matin");

Clients client1 = new Clients("Client1");
Clients client2 = new Clients("Client2");
Clients client3 = new Clients("Client3");

JournalSoir.Attach(client2);
JournalMatin.AdsAttach(client1);
JournalMatin.NewsAttach(client3);


JournalSoir.Notify();
JournalMatin.NotifyAds();
JournalMatin.NotifyNews();

