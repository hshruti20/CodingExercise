using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Count() == 2)
            {
                var fileInfoExtractor = new FileInfoExtractor();
                if (StringManipulator.SettingsInstance.VersionParams.Contains(args[0]))
                {
                    Console.WriteLine(fileInfoExtractor.GetVersionInfo(args[1]));
                }
                else if (StringManipulator.SettingsInstance.SizeParams.Contains(args[0]))
                {
                    Console.WriteLine(fileInfoExtractor.GetSizeInfo(args[1]));
                }
                else
                {
                    Console.WriteLine("Invalid Identifier");
                }
            }
            else
            {
                Console.WriteLine("No of arguments Exceeded.Expected Arguments : 2");
            }
            Console.ReadLine();
        }
    }
}
