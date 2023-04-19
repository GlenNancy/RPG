using RpgApi.Models.Enuns;
using System.Text.Json.Serialization;
using RpgApi.Models;

namespace RpgApi.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Dano { get; set; }

        public List<PersonagemHabilidade> PersonagemHabilidades { get; set; }
    }
}