using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace atividade_api_web.Models
{
    [Table("administradores")]
    public partial class Administrador
    {
        #region "Propriedades"
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Column("email", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Column("senha", TypeName = "varchar")]
        [Required]
        [MaxLength(10)]
        public string Senha { get; set; }

        [NotMapped]
        public string Permissao => "administrador";

        #endregion

        #region Metodos 

        #endregion
    }
}
