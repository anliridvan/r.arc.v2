using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAM.Core.DataAccess.Entities
{
    public class IslemEntity
    {

        public int  Id{ get; set; }

        public int NesneTurId { get; set; } // Diff

        public int  NesneId{ get; set; }

        public string  YapilanIslem{ get; set; }

        public string  Param1{ get; set; }

        public string  Param2{ get; set; }

        public string  Param3{ get; set; }

        public string  UzunParam4{ get; set; }

        [ForeignKey("IslemiYapanKisiEntity")]
        public string  IslemiYapanKisi{ get; set; }

        [ForeignKey("AsilKisiEntity")]
        public string  AsilKisi{ get; set; }

        public DateTime  IslemTarihi{ get; set; }


        public virtual SistemKullaniciEntity IslemiYapanKisiEntity { get; set; }

        public virtual SistemKullaniciEntity AsilKisiEntity { get; set; }

        public virtual NesneTuruEntity NesneTuru { get; set; }

    }
}
