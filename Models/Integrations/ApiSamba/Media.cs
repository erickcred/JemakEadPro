using System.Collections.Generic;

namespace JemakEadPro.Models.Integrations.Samba.ApiSamba
{
    public class Media
    {
        public string Id {get; set; }  // "527f348888099c4e1345bb337602f166",
        public string Title {get; set; }  // "Atualizaao_-_Bloco_K.mp4",

        public List<File> Files { get; set; }
    }
}