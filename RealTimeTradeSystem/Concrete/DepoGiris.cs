using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeEntities
{
    [Table("DepoGiris")]
    public class DepoGiris
    {
        [Key]
        public int Id { get; set; }

        public int UrNo { get; set; }

        public string BagNo { get; set; }

        public int Nakliye { get; set; }

        public int B_KovaAdet { get; set; }

        public int K_KovaAdet { get; set; }

        public string Saat { get; set; }

        public int CicekKodu { get; set; }

        [StringLength(20)]
        public string Cinsi { get; set; }

        public int Demet { get; set; }

        public int D_SiraNo { get; set; }

        
        [StringLength(20)]
        public string Nakliyeci { get; set; }

        [StringLength(5)]
        public string Bilgi1 { get; set; }

        [StringLength(20)]
        public string Ozellik1 { get; set; }

        [StringLength(20)]
        public string Ozellik2 { get; set; }

        [StringLength(20)]
        public string Ozellik3 { get; set; }

        [StringLength(20)]
        public string Ozellik4 { get; set; }

        [StringLength(20)]
        public string Ozellik5 { get; set; }

        [StringLength(20)]
        public string Ozellik6 { get; set; }

        [StringLength(20)]
        public string Ozellik7 { get; set; }

    }
}

/*
 
ur_no	tamsayı	
il	metin	30
bag_no	metin	15
nakliye	tamsayı	
b_kova_adet	tamsayı	
k_kova_adet	tamsayı	
saat	metin	
cic_kod	tamsayı	
cinsi	metin	20
demet	tamsayı	
d_sira_nıo	tamsayı	
nakliyeci	metin	20
bilgi_1	metin	5
ozellik_1	metin	30
ozellik_2	metin	30
ozellik_3	metin	30
ozellik_4	metin	30
ozellik_5	metin	30
ozellik_6	metin	30
ozellik_7	metin	30 


 */