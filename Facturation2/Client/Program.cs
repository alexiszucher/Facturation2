using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Facturation2.Shared;

namespace Facturation2.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Création des Clients
            BusinessClient client1 = new BusinessClient("Baudar", "Martin", 35);
            BusinessClient client2 = new BusinessClient("Jushet", "Lara", 23);
            BusinessClient client3 = new BusinessClient("Mopre", "José", 32);
            BusinessClient client4 = new BusinessClient("Laudet", "Marie", 44);
            BusinessClient client5 = new BusinessClient("Tedal", "Théo", 56);
            //Fin de Création des Clients

            //Création des factures
            BusinessFacture facture1 = new BusinessFacture(client5, 7281, new DateTime(2020, 12, 01), new DateTime(2020, 12, 30), 325, 120);
            BusinessFacture facture2 = new BusinessFacture(client4, 9712, new DateTime(2020, 12, 03), new DateTime(2020, 01, 03), 130, 130);
            BusinessFacture facture3 = new BusinessFacture(client3, 8891, new DateTime(2020, 12, 04), new DateTime(2020, 01, 14), 585, 250);
            BusinessFacture facture4 = new BusinessFacture(client2, 9202, new DateTime(2020, 12, 06), new DateTime(2020, 01, 28), 1020, 350);
            BusinessFacture facture5 = new BusinessFacture(client1, 9120, new DateTime(2020, 12, 07), new DateTime(2020, 12, 22), 80, 80);
            //Fin de création des factures

            //Création de l'objet BusinessData
            BusinessData businessData = new BusinessData();
            businessData.addFactures(facture1);
            businessData.addFactures(facture2);
            businessData.addFactures(facture3);
            businessData.addFactures(facture4);
            businessData.addFactures(facture5);



            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton<BusinessData>(sp => businessData);
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
