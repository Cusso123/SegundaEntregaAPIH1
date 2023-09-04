using Aluno.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace Aluno.Models.Request
{
    public class AlunoViewModel
    {
        public string Nome { get; set; }

        [RAValidation]
        public string RA { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public bool Ativo { get; set; }

    }
}
