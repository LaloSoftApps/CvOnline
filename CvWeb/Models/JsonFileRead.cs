using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CvWeb.Models
{
    public class JsonFileRead
    {
        public string FilePath { get; set; }

        public Cv Call()
        {
            FileInfo FileToProcess = new FileInfo(FilePath);

            if (!(FileToProcess.Exists))
            {
                ApplicationException ex = new ApplicationException("File Not Found");
                throw ex;
            }

            Cv oCV = new Cv();
            using (StreamReader jsonStream = File.OpenText(FileToProcess.FullName))
            {
                oCV = JsonConvert.DeserializeObject<Cv>(jsonStream.ReadToEnd());
            }

            return oCV;
        }
    }
}
