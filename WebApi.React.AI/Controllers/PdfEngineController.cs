using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.React.AI.Controllers
{
    public class PdfEngineController : ApiController
    {
        //upload to blob
        public static void UploadFiles()
        {
            string storageConnectionString = "*****Value copied from the Console****";

            DirectoryInfo directoryInfo = new DirectoryInfo("D:\\InputPath");

            var files = directoryInfo.EnumerateFiles();

            // Retrieve storage account from connection string.
            //CloudStorageAccount storageAccount = CloudStorageAccount.Parse(storageConnectionString);

            //// Create the blob client.
            //CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            //// Retrieve reference to a previously created container.
            //CloudBlobContainer container = blobClient.GetContainerReference("<<Blob Container Name>>");

            //foreach (FileInfo inputFile in files)
            //{

            //    CloudBlockBlob blockBlob = container.GetBlockBlobReference("<<Folder(If required)>>\\" + inputFile.Name);

            //    blockBlob.UploadFromFile(inputFile.FullName);
            //}
        }

        //download from blob
    }
}
