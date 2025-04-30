using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEscolarAPI.Database;
using SistemaEscolarAPI.Models;

namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlunoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Aluno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAlunos()
        {
            var alunos = await _context.Alunos
                .Include(a => a.curso)
                .Include(a => a.DisciplinaAlunoCursos)
                .ToListAsync();

            return Ok(alunos);
        }

        // GET: api/Aluno/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAluno(int id)
        {
            var aluno = await _context.Alunos
                .Include(a => a.curso)
                .Include(a => a.DisciplinaAlunoCursos)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (aluno == null)
                return NotFound();

            return Ok(aluno);
        }

        // POST: api/Aluno
        [HttpPost]
        public async Task<ActionResult<Aluno>> PostAluno(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAluno), new { id = aluno.Id }, aluno);
        }

        // PUT: api/Aluno/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAluno(int id, Aluno aluno)
        {
            if (id != aluno.Id)
                return BadRequest();

            _context.Entry(aluno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Alunos.Any(a => a.Id == id))
                    return NotFound();

                throw;
            }

            return NoContent();
        }

        // DELETE: api/Aluno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAluno(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
                return NotFound();

            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
