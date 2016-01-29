using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class WsdlReader
    {
        public string FileName { get; private set; }
        public SoalImporter Importer { get; private set; }

        public WsdlReader(SoalImporter importer, string fileName)
        {
            this.Importer = importer;
            this.FileName = fileName;
        }

        public void Import()
        {

        }
    }
}
