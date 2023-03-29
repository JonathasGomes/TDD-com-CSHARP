using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Asserts
{
    public class DatasEspeciaisStore
    {
        public DateTime Data(DatasEspeciais datasEspeciais)
        {
            switch (datasEspeciais)
            {
                case DatasEspeciais.AnoNovo:
                    return new DateTime(2018, 1, 1, 0, 0, 0, 0);
                    
                default:
                    throw new ArgumentOutOfRangeException("datasEspeciais");
            }
        }
    }
}
