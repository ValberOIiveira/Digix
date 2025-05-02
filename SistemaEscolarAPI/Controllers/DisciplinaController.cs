using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEscolarAPI.Database;
using SistemaEscolarAPI.DTO;
using SistemaEscolarAPI.Models;

namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisciplinaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DisciplinaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisciplinaDto>>> GetDisciplinas()
        {
            var disciplinas = await _context.Disciplinas
                .Select(d => new DisciplinaDto
                {
                    Id = d.Id,
                    Descricao = d.Descricao,
                    CursoId = d.CursoId
                })
                .ToListAsync();

            return Ok(disciplinas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DisciplinaDto>> GetDisciplina(int id)
        {
            var disciplina = await _context.Disciplinas
                .Where(d => d.Id == id)
                .Select(d => new DisciplinaDto
                {
                    Id = d.Id,
                    Descricao = d.Descricao,
                    CursoId = d.CursoId
                })
                .FirstOrDefaultAsync();

            if (disciplina == null)
                return NotFound();

            return Ok(disciplina);
        }

        [HttpPost]
        public async Task<ActionResult<DisciplinaDto>> PostDisciplina(DisciplinaDto dto)
        {
            var disciplina = new Disciplina
            {
                Descricao = dto.Descricao,
                CursoId = dto.CursoId
            };

            _context.Disciplinas.Add(disciplina);
            await _context.SaveChangesAsync();

            dto.Id = disciplina.Id;

            return CreatedAtAction(nameof(GetDisciplina), new { id = disciplina.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDisciplina(int id, DisciplinaDto dto)
        {
            if (id != dto.Id)
                return BadRequest();

            var disciplina = await _context.Disciplinas.FindAsync(id);
            if (disciplina == null)
                return NotFound();

            disciplina.Descricao = dto.Descricao;
            disciplina.CursoId = dto.CursoId;

            _context.Entry(disciplina).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDisciplina(int id)
        {
            var disciplina = await _context.Disciplinas.FindAsync(id);
            if (disciplina == null)
                return NotFound();

            _context.Disciplinas.Remove(disciplina);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
