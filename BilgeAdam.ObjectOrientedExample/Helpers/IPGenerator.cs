using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.ObjectOrientedExample.Helpers
{
    class IPGenerator
    {
        public IPGenerator()
        {
            ipAdresses = new HashSet<string>();
            rnd = new Random();
        }
        private HashSet<string> ipAdresses;
        private Random rnd;

        public string GenerateIP(bool isVirtual)
        {
            if (isVirtual)
            {
                return FindAvaliableIpBlock("10");
            }
            else
            {
                return FindAvaliableIpBlock("172");
            }
            // 10.23.45.244
            //172.23.45.244
        }
        //&daha önce kullanılmayan bir ip adresi üretir
        private string FindAvaliableIpBlock(string prefix)
        {
            while (true)
            {
                var numbers = new int[3];
                for (var i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 254);
                }
                //Concat n tane string parameteresini yanyana ekler. bildiğiniz + işlemi
                //Join IEnumerable bir nesnenin öğelerini belirlenen bir ayraca göre birleştirir. Örnek dizi : ["Can","Cem", "Cenk"] => string.Join("-", dizi) => Can-Cem-Cenk
                var ip = string.Concat(prefix, ".", string.Join(".", numbers));
                if (ipAdresses.Add(ip))
                {
                    return ip;
                }

                //HashSet Add methodunda ekleyip eklemediğini geri döndüğü için bu yöntem uzun yöntem oluyor
                //if (ipAdresses.Contains(ip))
                //{
                //    ipAdresses.Add(ip);
                //    return ip;
                //}
            }
        }
    }
}
