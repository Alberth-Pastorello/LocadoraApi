using AutoMapper;
using LocadoraApi.Data;
using LocadoraApi.Models;
using LocadoraApi.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using LocadoraApi.Data.Dtos.Jogo;

namespace LocadoraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {
        private AppDbContext _context;  
        private IMapper _mapper;

        public JogoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaJogo([FromBody] CriaJogoDto dto)
        {
            Jogo jogo = _mapper.Map<Jogo>(dto);
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RetornaJogoPorId), new { Id = jogo.Id }, jogo);
            //um tipo Jogo vai receber o mapeamento de CriajogoDto e vai armazenar no campo context
            //ai precisa salvar essas mudanças e ent dar um retorno de CreatedAtAction
        }
        [HttpGet]
        public IEnumerable<Jogo> RetornaJogo()
        {
            return _context.Jogos;
        }

        [HttpGet("{id}")]
        public IActionResult RetornaJogoPorId(int id)
        {
            Jogo jogo = _context.Jogos.FirstOrDefault(jogo => jogo.Id == id);
            if (jogo != null)
            {
                LeJogoDto jogoDto = _mapper.Map<LeJogoDto>(jogo);

                return Ok(jogoDto);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaJogo(int id)
        {
            Jogo jogo = _context.Jogos.FirstOrDefault(jogo => jogo.Id == id);
            if (jogo == null)
            {
                return NotFound(); //boa pratica
            }
            _context.Remove(jogo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
