using RpgMvc.Models.Enuns;

namespace RpgMvc.Models
{
    public class PersonagemViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClassEnum Classe { get; set; }
        public byte[] FotoPersonagem { get; set; }

        /*[JsonIgnore]
        public Usuario Usuario { get; set; }

        [JsonIgnore]
        public Armas Armas { get; set; }*/

        public List<PersonagemHabilidadeViewModel> PersonagemHabilidades { get; set; }

        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }

    }
}