using BilgeAdam.ObjectOrientedExample.Helpers;

namespace BilgeAdam.ObjectOrientedExample.Models
{
    public class Domain
    {
        public Domain()
        {
            IpGenerator = new IPGenerator();
        }
        //private yaptık çünkü; ip adreslerini sadece domain nesnesi üretebilsin
        private IPGenerator IpGenerator { get; set; }
        public string Name { get; set; }
        public string PublicIP { get; set; }
        public string PrivateIP { get; set; }

        private string fqdn;
        public string FQDN
        {
            get { return fqdn; }
            set { fqdn = value; }
        }

        public Server CreateVirtualServer(string name)
        {
            var srv = CreateServer(name, true);
            srv.PublicIP = IpGenerator.GenerateIP(true);
            return srv;
        }

        public Server CreatePhysicalServer(string name)
        {
            var srv = CreateServer(name, false);
            srv.PublicIP = IpGenerator.GenerateIP(false);
            return srv;
        }

        private Server CreateServer(string name, bool isVrt)
        {
            var srv = new Server
            {
                Name = name,
                IsVirtual = isVrt
            };
            return srv;
        }
    }
}
