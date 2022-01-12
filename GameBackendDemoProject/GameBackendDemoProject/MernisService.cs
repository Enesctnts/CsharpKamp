using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackendDemoProject.MernisServiceReference;

namespace GameBackendDemoProject
{
    public class MernisService : IGamerCheckService
    {
        public bool CheckGamer(Gamer gamer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId), gamer.FirsName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
        }
    }
}
