using CallApp.Aplication.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallApp.Aplication.Implemetation
{
    public class WyFisherService : IWyFisherService
    {
        private readonly WyFisherModel _wyFisher;

        public WyFisherService(WyFisherModel wyFisher)
        {
            _wyFisher = wyFisher;
        }
        public void SendMessage()
        {
            Debug.WriteLine(_wyFisher.Key);
        }
    }
}
