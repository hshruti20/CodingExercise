using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class FileInfoExtractor
    {
        private FileDetails _fileDetails;
        public FileDetails FileDetails 
        {
            get { return _fileDetails; }
            set { _fileDetails = value; }
        }
        public FileInfoExtractor()
        {
            _fileDetails = new FileDetails();
        }

        public string GetVersionInfo(string args)
        {
            return _fileDetails.Version(args);   
        }

        public int GetSizeInfo(string args)
        {
            return _fileDetails.Size(args);
        }

    }
}
