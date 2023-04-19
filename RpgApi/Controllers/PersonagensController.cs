using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using RpgApi.Models; 
using Microsoft.EntityFrameworkCore;


namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PersonagensController : ControllerBase
    {
        //Programação de toda a classe ficará aqui abaixo
        private readonly DataContext _context; //Declaração do atributo

        public PersonagensController(DataContext context)
        {
            //Inicialização do atributo a partir de um parâmetro          
            _context = context;
        }

         [HttpGet("{id}")] //Buscar pelo id
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Personagem p = await _context.Personagens.FirstOrDefaultAsync(pBusca => pBusca.Id == id);

                return Ok(p);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Personagem> lista = await _context.Personagens.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Personagem novoPersonagem)
        {
            try
            {
                if (novoPersonagem.PontosVida > 100)
                {
                    throw new System.Exception("Pontos de vida não pode ser maior que 100");
                }
                await _context.Personagens.AddAsync(novoPersonagem);
                await _context.SaveChangesAsync();

                return Ok(novoPersonagem.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Personagem novoPersonagem)
        {
            try
            {
                if (novoPersonagem.PontosVida > 100)
                {
                    throw new System.Exception("Pontos de vida não pode ser maior que 100");
                }                
                _context.Personagens.Update(novoPersonagem);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                 Personagem pRemover = await _context.Personagens.FirstOrDefaultAsync(p => p.Id == id);

                _context.Personagens.Remove(pRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);                
            }
        }

    }//Fim da classe do tipo Controller
}

