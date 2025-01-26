using System.ComponentModel.DataAnnotations;

namespace ApiWeb_Authors.Models
{
    public class LivroModel
    {
        [Key]
        public Guid Id { get; init; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }

    }
}
