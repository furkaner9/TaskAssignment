using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Web;
using TaskAssignment.Models.ProjeTakip;

namespace TaskAssignment.Models.Personel
{
    public class PersonelBilgileri
    {
        public PersonelBilgileri() 
        {
        this.PersonelProjeleris =new HashSet<PersonelProjeleri>();
        }
        [Key]
        public int PersonelBilgileriId { get; set; }
        [DisplayName("E-posta")]
        public string Eposta { get; set; }
        [DisplayName("Şifre")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karekter")]
        public string Sifre { get; set; }
        [DisplayName("Yekti")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karekter")]
        public string Yetki { get; set; }
        [DisplayName("Ad Soyad")]
        [StringLength(25, ErrorMessage = "Masimum uzunluk 25 karekter")]
        public string AdSoyad { get; set; }
        [DisplayName("Tc No")]
        public int TCNO { get; set; }
        [DisplayName("Departman")]
        [StringLength(25, ErrorMessage = "Masimum uzunluk 25 karekter")]
        public string Departman { get; set; }
        [DisplayName("Görev")]
        public string Gorev { get; set; }
        [DisplayName(" Açıklama")]
        public string pozisyonAcıklama { get; set; }
        [DisplayName("Telafon Numarası")]
        [StringLength(25, ErrorMessage = "Masimum uzunluk 25 karekter")]
        public string TelNO { get; set; }
        [DisplayName("Adres Bilgileri")]
        public string Adres { get; set; }
        [DisplayName("Medeni Hal")]
        [StringLength(25, ErrorMessage = "Masimum uzunluk 25 karekter")]
        public string MedeniHal { get; set; }
        [DisplayName("Yakın Bilgisi")]
        [StringLength(25, ErrorMessage = "Masimum uzunluk 25 karekter")]
        public string YakınBilgisi { get; set; }
        [DisplayName("Yakın Tc No")]
        [StringLength(25, ErrorMessage = "Masimum uzunluk 25 karekter")]
        public string YakınTcNo { get; set; }
        [DisplayName("Yakın Ad Soyad")]
        public string YakınAdsoyad { get; set; }
        [DisplayName("Yakın Telefon")]
        [StringLength(25, ErrorMessage = "Masimum uzunluk 25 karekter")]
        public string YakınTel { get; set; }
        [DisplayName("Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("İşe Giriş Tarihi")]
        public DateTime? IseGirisTarihi { get; set; }
        public virtual ICollection<PersonelProjeleri>PersonelProjeleris { get; set; }

    }
}