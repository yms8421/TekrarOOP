using BilgeAdam.ObjectOrientedExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.DomainSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Domain
            {
                Name = "BILGEADAM",
                PublicIP = "195.142.153.209",
                PrivateIP = "10.10.22.2",
                FQDN = "www.bilgeadam.com"//Fully Qualifed Domain name
            };

            var srv1 = d1.CreateVirtualServer("MSSQL YMS");
            var srv2 = d1.CreateVirtualServer("ASD");
            var srv3 = d1.CreatePhysicalServer("Web App 1");
            var srv4 = d1.CreatePhysicalServer("Mongo DB");
            var srv5 = d1.CreateVirtualServer("Audit Log");

            Console.ReadKey();

            //hepsi WindowsServer2008 olarak açılıyor. Oysa ki client'ın bunu seçmesi gerek
            //User class ı için de işlemleri yapın. Kullanının sunuculara erişimi olup olamayacağınız da siz belirleyiniz?
        }
    }
}
