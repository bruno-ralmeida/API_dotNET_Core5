using System;
using System.ComponentModel.DataAnnotations;

namespace csharp_apiRest.Data.DTOS
{
  public class ReadMovieDTO
  {
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Título é obrigatório.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "O campo Diretor é obrigatório.")]
    public string Director { get; set; }

    [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo Genêro deve possuir no mínimo 3 caracteres.")]
    public string Genre { get; set; }

    [Range(0, 600, ErrorMessage = "O campo Duração é obrigatório.")]
    public int Duration { get; set; }
    public DateTime Consultation { get; set; }
  }
}