using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelpDeskPro
{
    public class LembrarDeMim
    {
        public string Usuario { get; set; }
        public string senha { get; set; }
        public bool Lembrar { get; set; }

        public void Salvar(string usuario, string senha, bool lembrar)
        {
            string caminho = "lembrar.json";
            string json = JsonSerializer.Serialize(new LembrarDeMim { Usuario = usuario, senha = senha, Lembrar = lembrar});
            File.WriteAllText(caminho, json);
        }

        public LembrarDeMim Carregar()
        {
            string caminho = "lembrar.json";
            if (!File.Exists(caminho)) return null;

            string json = File.ReadAllText(caminho);
            var dados = JsonSerializer.Deserialize<LembrarDeMim>(json);

            return dados;
        }

        public void Apagar()
        {
            string caminho = "lembrar.json";
            if (File.Exists(caminho))
                File.Delete(caminho);
        }
    }
}
