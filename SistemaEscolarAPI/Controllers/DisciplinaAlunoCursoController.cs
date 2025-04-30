using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEscolarAPI.Models;
using SistemaEscolarAPI.Database;

namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisciplinaAlunoCursoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DisciplinaAlunoCursoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DisciplinaAlunoCurso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisciplinaAlunoCurso>>> GetAll()
        {
            return await _context.DisciplinaAlunoCursos
                .Include(d => d.Aluno)
                .Include(d => d.Disciplina)
                .Include(d => d.Curso)
                .ToListAsync();
        }

        // GET: api/DisciplinaAlunoCurso/{idAluno}/{idDisciplina}/{idCurso}
        [HttpGet("{idAluno}/{idDisciplina}/{idCurso}")]
        public async Task<ActionResult<DisciplinaAlunoCurso>> Get(int idAluno, int idDisciplina, int idCurso)
        {
            var item = await _context.DisciplinaAlunoCursos
                .Include(d => d.Aluno)
                .Include(d => d.Disciplina)
                .Include(d => d.Curso)
                .FirstOrDefaultAsync(d => d.AlunoId == idAluno && d.DisciplinaId == idDisciplina && d.CursoId == idCurso);

            if (item == null)
                return NotFound();

            return item;
        }

        // POST: api/DisciplinaAlunoCurso
        [HttpPost]
        public async Task<ActionResult<DisciplinaAlunoCurso>> Post(DisciplinaAlunoCurso model)
        {
            _context.DisciplinaAlunoCursos.Add(model);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { idAluno = model.AlunoId, idDisciplina = model.DisciplinaId, idCurso = model.CursoId }, model);
        }

        // DELETE: api/DisciplinaAlunoCurso/{idAluno}/{idDisciplina}/{idCurso}
        [HttpDelete("{idAluno}/{idDisciplina}/{idCurso}")]
        public async Task<IActionResult> Delete(int idAluno, int idDisciplina, int idCurso)
        {
            var item = await _context.DisciplinaAlunoCursos
                .FirstOrDefaultAsync(d => d.AlunoId == idAluno && d.DisciplinaId == idDisciplina && d.CursoId == idCurso);

            if (item == null)
                return NotFound();

            _context.DisciplinaAlunoCursos.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
