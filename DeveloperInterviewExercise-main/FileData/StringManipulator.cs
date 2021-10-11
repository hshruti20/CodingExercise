using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
   public  class StringManipulator
    {

        private  List<string> _versionParams = new List<string>() { "-v", "--v", "/v", "--version" };
        private List<string> _sizeParams = new List<string>() { "-s", "--s", "/s","--size" };
        private static readonly StringManipulator _settings = new StringManipulator();
        private StringManipulator()
        {

        }

        public static StringManipulator SettingsInstance => _settings;
        public IList<string> VersionParams => _versionParams;
        public IList<string> SizeParams => _sizeParams;

        public void AddVersionParamIdentifier(string identifier )
        {
            _versionParams.Add(identifier);
        }

         public void AddSizeParamIdentifier(string identifier )
        {
            _sizeParams.Add(identifier);
        }

    }
}
