using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace JemakEadPro.Utils
{
    public static class SalvarArquivo
    {
        public async static Task<String> Salvar(IFormFile file, String caminho)
        {
            var originName = file.FileName.Split(".")[0];
            var originType = file.FileName.Split(".")[1];

            string fileName = $"{originName}_{Guid.NewGuid().ToString()}.{originType}";
            var newPath = Path.Combine("wwwroot/", caminho, fileName);

            using (var stream = new FileStream(newPath, FileMode.Create))
                await file.CopyToAsync(stream);

            
            return newPath.Substring(8);
        }

        public static void Deletar(String caminho, String padrao)
        {
            // Console.WriteLine("\n\n\n\nCaminho: " + caminho + "\n\n\n\nPadrão: " + padrao);
            if (caminho != padrao && System.IO.File.Exists($"wwwroot/{caminho}"))
            {
                System.IO.File.Delete($"wwwroot/{caminho}");
            }
        }
    }
}