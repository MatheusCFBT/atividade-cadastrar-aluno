using System.ComponentModel.DataAnnotations;

namespace atividade_cadastrar_aluno_uni9.Models;

public class Aluno
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
    [StringLength(100, ErrorMessage = "O e-mail deve ter no máximo 100 caracteres.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O RA é obrigatório.")]
    [StringLength(20, ErrorMessage = "O RA deve ter no máximo 20 caracteres.")]
    public string RA { get; set; } = string.Empty;

    [Required(ErrorMessage = "O curso é obrigatório.")]
    [StringLength(100, ErrorMessage = "O curso deve ter no máximo 100 caracteres.")]
    public string Curso { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    [DataType(DataType.Date)]
    public DateOnly? DataNascimento { get; set; }
}
