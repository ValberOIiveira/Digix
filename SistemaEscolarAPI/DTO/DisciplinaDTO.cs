using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEscolarAPI.DTO
{
    public class DisciplinaDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CursoId { get; set; }
    }

}