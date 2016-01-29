using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class SoalImporter
    {
        public static void Import(string fileName)
        {
            ModelContext.RequireContext();
            SoalImporter importer = new SoalImporter();
            importer.ImportFile(fileName);
        }

        internal void ImportFile(string fileName)
        {
            string fullFileName = Path.GetFullPath(fileName);
            string ext = Path.GetExtension(fileName).ToLower();
            if (ext == ".wsdl")
            {
                new WsdlReader(this, fullFileName).Import();
            }
            else if (ext == ".xsd")
            {
                new XsdReader(this, fullFileName).Import();
            }
            else
            {
                throw new ModelException(string.Format("Unknown filetype '{0}' for '{1}'.", ext, fileName));
            }
        }
    }
}
