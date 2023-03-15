using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {            
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=99, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=98, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        [HttpGet("ConsultarNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            return Ok(personagens.FindAll(pe => pe.Nome == nome));
        }

        [HttpPost("Validar")]
        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if(novoPersonagem.Defesa < 10)
            {
                return BadRequest("Defesa não pode ser menor que 10");
            }
            else if(novoPersonagem.Inteligencia > 30)
            {
                return BadRequest("Inteligencia não pode ser maior que 30");
            }
            else
            {
                personagens.Add(novoPersonagem);
                return Ok(personagens);
            }
        }

        [HttpPost("ValidarMago")]
        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if(novoPersonagem.Classe == ClasseEnum.Mago)
            {
                if(novoPersonagem.Inteligencia < 35)
                    return BadRequest("Inteligencia de um mago não pode ser menor que 35");
                else
                {
                    personagens.Add(novoPersonagem);
                    return Ok(personagens);
                }
            }
            else
            {
                personagens.Add(novoPersonagem);
                return Ok(personagens);
            }
           
        }

        [HttpGet("ClerigoMago")]
        public IActionResult GetClerigoMago()
        {
            List<Personagem> personagensFi = personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro);
            personagensFi.OrderByDescending(p => p.PontosVida).ToList();

            return Ok(personagensFi);
        }

        [HttpGet("Estatisticas")]
        public IActionResult GetEstatisticas()
        {
           return Ok("A quantidade de personagens é " + personagens.Count + ". A Soma da força dos personagem são " + personagens.Sum(dad => dad.Forca)); 
        }

        [HttpGet("requisicao/{id}")]
        public IActionResult GetByClasse(int id)
        {
            return Ok(personagens.FindAll(pe => pe.Id == id));
        }

    }
}