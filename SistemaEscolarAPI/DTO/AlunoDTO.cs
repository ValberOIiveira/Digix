using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEscolarAPI.DTO
{
    public class AlunoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CursoId { get; set; }
    }

}