using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiWeb_Authors.Models
{
    public class AutorModel
    {
        [Key]
        public Guid Id { get; init; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore]
        public ICollection<LivroModel> Livros { get; set; }
    }
}
