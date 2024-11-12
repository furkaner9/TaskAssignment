using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using TaskAssignment.Models.Personel;

namespace TaskAssignment.Models.ProjeTakip
{
    public class PersonelProjeleri
    {
        public PersonelProjeleri() 
        {
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }
        [Key]
        public int PrsonelProjeId { get; set; }
        [DisplayName("Başlık")]
        [StringLength(150, ErrorMessage = "Maksimum uzunluk 150 karekter")]
        public string Baslık { get; set; }
        [DisplayName("Açıklama")]
        public string Acıklama { get; set; }
        [DisplayName("Oluşturulma Tarihi")]
        public DateTime OlusturmaTarihi { get; set; }
        public string OncelıkDurumu { get; set; }
        public int TamamamlanmaOranı { get; set; }
        public DateTime? TamamlanmTarihi { get; set; }
        public bool TamamlanmaDurumu { get; set; }
        public virtual ICollection<PersonelBilgileri>PersonelBilgileris { get; set; }
    }
}