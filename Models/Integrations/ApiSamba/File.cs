using System.Collections.Generic;

namespace JemakEadPro.Models.Integrations.Samba.ApiSamba
{
    public class File
    {
        public string id { get; set; }  // "57105923627a836ceb4db0e7c8b4d7ab",
        
        public string outputName { get; set; }  // "240p",
        public string url { get; set; }  // "http://pvbps-sambavideos.akamaized.net/account/3620/168/2022-12-07/video/57105923627a836ceb4db0e7c8b4d7ab/57105923627a836ceb4db0e7c8b4d7ab_240p.mp4",
        public FileInfo FileInfo { get; set; }
    }
}