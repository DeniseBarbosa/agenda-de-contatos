using System.ComponentModel.DataAnnotations;

namespace AgendaDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Digite o nome do contato")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite o E-mail")]
        [EmailAddress(ErrorMessage =("Formato de e-mail invalido"))]
        public string Email { get; set; }
        [Required(ErrorMessage =("Digite o celular do contato"))]
        [Phone(ErrorMessage =("formayo de celular invvalido"))]
        public string Celular { get; set; }
    }
}
