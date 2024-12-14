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
        [DisplayName("Öncelik Durumu")]
        public string OncelıkDurumu { get; set; }
        [DisplayName("Tamamlanma Oranı")]
        public int TamamamlanmaOranı { get; set; }
        [DisplayName("Tarihi Tarihi")]
        public DateTime? TamamlanmTarihi { get; set; }
        [DisplayName("Tamamlanma Durumu")]
        public bool TamamlanmaDurumu { get; set; }
        public virtual ICollection<PersonelBilgileri>PersonelBilgileris { get; set; }
    }
}