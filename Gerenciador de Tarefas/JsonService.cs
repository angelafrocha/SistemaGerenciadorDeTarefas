using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Tarefas
{
    internal class JsonService
    {
        public static T LerObjeto<T>(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
            {
                throw new FileNotFoundException($"Arquivo não encontrado: {caminhoArquivo}");
            }

            string json = File.ReadAllText(caminhoArquivo);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static void SalvarObjeto<T>(string caminhoArquivo, T objeto)
        {
            string json = JsonConvert.SerializeObject(objeto);
            File.WriteAllText(caminhoArquivo, json);
        }
    }
}
