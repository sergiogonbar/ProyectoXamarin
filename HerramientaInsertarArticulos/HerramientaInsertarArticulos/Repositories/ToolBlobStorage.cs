using Microsoft.AspNetCore.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HerramientaInsertarArticulos.Repositories
{
    public class ToolBlobStorage
    {
        CloudBlobClient client;
        public ToolBlobStorage()
        {
            String keys = "DefaultEndpointsProtocol=https;AccountName=storagexamarin;AccountKey=2hWHJqX9cDLAZdsWQwOcf7SJ0Bz3wxAuj6w/tfqynYFvS5bZBXv6LjdOS+NoyT12jz1GNeOxEMBgcGmPkt66mg==;EndpointSuffix=core.windows.net";
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            this.client = account.CreateCloudBlobClient();
        }


        public void CrearContenedor()
        {
            CloudBlobContainer container = this.client.GetContainerReference("tienda");
            container.CreateIfNotExistsAsync();
            container.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
        }

        public async Task<bool> SubirBlob(IFormFile image)
        {
            CloudBlobContainer container = this.client.GetContainerReference("tienda");
            CloudBlockBlob blobBlock = container.GetBlockBlobReference(image.FileName);
            var tempPath = Path.GetTempFileName();
            using (var stream = new FileStream(tempPath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            using (var stream = new FileStream(tempPath, FileMode.Open))
            {
                await blobBlock.UploadFromStreamAsync(stream);
            }

            return true;
        }

        public async Task<String> GetUriBlob(String nombreblob)
        {
            CloudBlobContainer container = this.client.GetContainerReference("tienda");
            CloudBlockBlob blob = container.GetBlockBlobReference(nombreblob);
            return blob.StorageUri.PrimaryUri.ToString();
        }


    }
}
