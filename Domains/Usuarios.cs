using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SystemGameAPI.Domains
{
    /// <summary>
    /// </summary>
    [Table("Usuarios")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuarios
    {
        /// <summary>
        /// </summary>
        [Key]
        public Guid UsuarioID { get; set; }

        /// <summary>
        /// </summary>
        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório!")]
        public string? Nome { get; set; }

        /// <summary>
        /// </summary>
        [Column(TypeName = "VARCHAR(75)")]
        [Required(ErrorMessage = "O nickname do usuário é obrigatório!")]
        public string? Nickname { get; set; }

        /// <summary>
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nickname do usuário é obrigatório!")]
        public string? JogoFav { get; set; }

        /// <summary>
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email do usuário é obrigatório!")]
        public string? Email { get; set; }

        /// <summary>
        /// </summary>
        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 a 60 caracteres")]
        public string? Senha { get; set; }

        /// <summary>
        /// </summary>
        //referência para a entidade Jogos
        [Required(ErrorMessage = "O Jogo é obrigatório!")]
        public Guid JogosID { get; set; }

        /// <summary>
        /// </summary>
        [ForeignKey("JogosID")]
        public Jogos? Jogos { get; set; }

    }
}
