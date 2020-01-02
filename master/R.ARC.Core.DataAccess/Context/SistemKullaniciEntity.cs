using System.ComponentModel.DataAnnotations;

namespace SAM.Core.DataAccess.Entities
{
    public class SistemKullaniciEntity
    {
        [Key]
        public string KullaniciAdi { get; set; }
    }
}
