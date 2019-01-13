using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek1EntityLayer.Enumlar;

namespace Ornek1EntityLayer.Classlar
{
    public abstract class Sekil
    {
        public string SekilAdi { get; set; }

        public SekilRenkleri SekilRengi { get; set; }

        public SekilTurleri SekilTuru { get; set; }

        // Kalıtım ile miras gittiği yerde bu abstract metodun gövdesi oluşacak
        public abstract void SekilCiz();
    }
}
