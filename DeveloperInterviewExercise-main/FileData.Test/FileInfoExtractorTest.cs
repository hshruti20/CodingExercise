using System;
using Xunit;
using ThirdPartyTools;
using FileData;



namespace FileData.Test
{
    public class FileInfoExtractorTest
    {
        [Fact]
        public void GetVersionInfo_WithValidInput()
        {
            FileInfoExtractor fileInfo = new  FileInfoExtractor();
            fileInfo.FileDetails = new FileDetails();
            string versionResult = fileInfo.GetVersionInfo("test/filepath");
			Assert.NotEmpty(versionResult);          
        }

          [Fact]
        public void GetSizeInfo_WithValidInput()
        {
            FileInfoExtractor fileInfo = new  FileInfoExtractor();
            fileInfo.FileDetails = new FileDetails();
            int sizeResult = fileInfo.GetSizeInfo("test/filepath");
			Assert.NotEmpty(sizeResult.ToString());          
        }
    }
}
