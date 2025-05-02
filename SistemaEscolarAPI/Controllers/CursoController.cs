using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEscolarAPI.Database;
using SistemaEscolarAPI.DTO;
using SistemaEscolarAPI.Models;

namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoDTO>>> GetCursos()
        {
            var cursos = await _context.Cursos
                .Select(c => new CursoDTO
                {
                    Id = c.Id,
                    Descricao = c.Descricao
                })
                .ToListAsync();

            return Ok(cursos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CursoDTO>> GetCurso(int id)
        {
            var curso = await _context.Cursos
                .Where(c => c.Id == id)
                .Select(c => new CursoDTO
                {
                    Id = c.Id,
                    Descricao = c.Descricao
                })
                .FirstOrDefaultAsync();

            if (curso == null)
                return NotFound();

            return Ok(curso);
        }

        [HttpPost]
        public async Task<ActionResult<CursoDTO>> PostCurso(CursoDTO dto)
        {
            var curso = new Curso
            {
                Descricao = dto.Descricao
            };

            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            dto.Id = curso.Id;

            return CreatedAtAction(nameof(GetCurso), new { id = curso.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurso(int id, CursoDTO dto)
        {
            if (id != dto.Id)
                return BadRequest();

            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound();

            curso.Descricao = dto.Descricao;
            _context.Entry(curso).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurso(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
                return NotFound();

            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
