using Entities.Concrete;
using Entities.Log.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public partial class MainDBContext : DbContext
    {
        //public MainDBContext()
        //{

        //}

        //public MainDBContext(DbContextOptions<MainDBContext> options) : base(options)
        //{
        //}



        public DbSet<AracPlakalar> AracPlakalar { get; set; } = null!;
        public DbSet<Bolgeler> Bolgeler { get; set; } = null!;
        public DbSet<cicek_bilgi> cicek_bilgi { get; set; } = null!;
        public DbSet<NakliyeTombala> NakliyeTombala { get; set; } = null!;
        public DbSet<rekolte> rekolte { get; set; } = null!;
        public DbSet<Soforler> Soforler { get; set; } = null!;
        public DbSet<Duyurular> Duyurular { get; set; } = null!;
        public DbSet<SubeSatis> SubeSatis { get; set; } = null!;
        public DbSet<ur_toplam> ur_toplam { get; set; } = null!;
        public DbSet<URETICILER> Ureticiler { get; set; } = null!;
        public DbSet<URETICI_ODEMELER2> UreticiOdemeler { get; set; } = null!;
        public DbSet<satis> satis { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=89.252.137.24;Database=UreticiTakipDB_test;User ID=sa;Password=Yuskan2085@;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AracPlakalar>(entity =>
            {
                entity.HasKey(e => e.PlakaId)
                    .HasName("PK_dbo.AracPlakalar");

                entity.ToTable("AracPlakalar");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.GuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.OlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pasif).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plaka).HasMaxLength(10);

                entity.Property(e => e.SonGuncelleyen).HasMaxLength(20);
            });

            modelBuilder.Entity<Bolgeler>(entity =>
            {
                entity.HasKey(e => e.BolgeId)
                    .HasName("PK_dbo.Bolgeler");

                entity.ToTable("Bolgeler");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.BolgeAdi).HasMaxLength(10);

                entity.Property(e => e.GuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.OlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pasif).HasDefaultValueSql("((0))");

                entity.Property(e => e.SonGuncelleyen).HasMaxLength(20);
            });

            modelBuilder.Entity<cicek_bilgi>(entity =>
            {
                entity.ToTable("cicek_bilgi");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.cinsi)
                    .HasMaxLength(20)
                    .HasColumnName("cinsi")
                    .IsFixedLength();

                entity.Property(e => e.dal_icin_taban_fiyat)
                    .HasColumnType("money")
                    .HasColumnName("dal_icin_taban_fiyat");

                entity.Property(e => e.demet_adedi).HasColumnName("demet_adedi");

                entity.Property(e => e.demetteki_dal_adedi).HasColumnName("demetteki_dal_adedi");

                entity.Property(e => e.kod).HasColumnName("kod");

                entity.Property(e => e.kodu).HasColumnName("kodu");

                entity.Property(e => e.s_no)
                    .HasMaxLength(10)
                    .HasColumnName("s_no")
                    .IsFixedLength();

                entity.Property(e => e.tur)
                    .HasMaxLength(20)
                    .HasColumnName("tur")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NakliyeTombala>(entity =>
            {
                entity.ToTable("NakliyeTombala");

                entity.Property(e => e.Adet).HasDefaultValueSql("((1))");

                entity.Property(e => e.BirimFiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bolge).HasMaxLength(50);

                entity.Property(e => e.GuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Nakliyeci).HasMaxLength(50);

                entity.Property(e => e.OlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pasif).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plaka).HasMaxLength(10);

                entity.Property(e => e.SoforKodu).HasMaxLength(20);

                entity.Property(e => e.SonGuncelleyen).HasMaxLength(20);

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ToplamFiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UreticiAdiSoyadi).HasMaxLength(50);

                entity.Property(e => e.UreticiIli).HasMaxLength(20);

                entity.Property(e => e.UreticiKodu).HasMaxLength(10);
            });

            modelBuilder.Entity<rekolte>(entity =>
            {
                entity.ToTable("rekolte");

                entity.Property(e => e.rekolte_id).HasColumnName("rekolte_id");

                entity.Property(e => e.alan)
                    .HasMaxLength(50)
                    .HasColumnName("alan");

                entity.Property(e => e.ay).HasColumnName("ay");

                entity.Property(e => e.ay_adi)
                    .HasMaxLength(10)
                    .HasColumnName("ay_adi");

                entity.Property(e => e.cesit)
                    .HasMaxLength(50)
                    .HasColumnName("cesit");

                entity.Property(e => e.cic_ana_kod).HasColumnName("cic_ana_kod");

                entity.Property(e => e.cic_kodu_cicek).HasColumnName("cic_kodu_cicek");

                entity.Property(e => e.cic_kodu_sogan).HasColumnName("cic_kodu_sogan");

                entity.Property(e => e.cic_tur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cic_tur");

                entity.Property(e => e.miktar_cicek)
                    .HasColumnType("money")
                    .HasColumnName("miktar_cicek");

                entity.Property(e => e.miktar_sogan)
                    .HasColumnType("money")
                    .HasColumnName("miktar_sogan");

                entity.Property(e => e.rekolte1)
                    .HasColumnType("money")
                    .HasColumnName("rekolte");

                entity.Property(e => e.sezon)
                    .HasMaxLength(15)
                    .HasColumnName("sezon");

                entity.Property(e => e.unvani)
                    .HasMaxLength(50)
                    .HasColumnName("unvani");

                entity.Property(e => e.ur_no).HasColumnName("ur_no");

                entity.Property(e => e.urun_cinsi_cicek)
                    .HasMaxLength(50)
                    .HasColumnName("urun_cinsi_cicek");

                entity.Property(e => e.urun_cinsi_sogan)
                    .HasMaxLength(50)
                    .HasColumnName("urun_cinsi_sogan");
            });

            modelBuilder.Entity<satis>(entity =>
            {
                entity.ToTable("satis");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.alici_kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("alici_kodu");

                entity.Property(e => e.alici_sand).HasColumnName("alici_sand");

                entity.Property(e => e.cic_adet).HasColumnName("cic_adet");

                entity.Property(e => e.cic_adi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cic_adi");

                entity.Property(e => e.cic_ana_kod).HasColumnName("cic_ana_kod");

                entity.Property(e => e.cic_demet).HasColumnName("cic_demet");

                entity.Property(e => e.cic_kod).HasColumnName("cic_kod");

                entity.Property(e => e.cic_tur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cic_tur");

                entity.Property(e => e.d_s_no).HasColumnName("d_s_no");

                entity.Property(e => e.s_no).HasColumnName("s_no");

                entity.Property(e => e.satis_fiyat)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("satis_fiyat");

                entity.Property(e => e.sira_no).HasColumnName("sira_no");

                entity.Property(e => e.sube)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sube");

                entity.Property(e => e.tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");

                entity.Property(e => e.toplam_tutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("toplam_tutar");

                entity.Property(e => e.uretici_adi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("uretici_adi");

                entity.Property(e => e.uretici_kodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("uretici_kodu");

                entity.Property(e => e.yedek1_decimal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("yedek1_decimal");

                entity.Property(e => e.yedek1_int).HasColumnName("yedek1_int");

                entity.Property(e => e.yedek1_string)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("yedek1_string");

                entity.Property(e => e.yedek_decimel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("yedek_decimel");

                entity.Property(e => e.yedek_int).HasColumnName("yedek_int");

                entity.Property(e => e.yedek_string)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("yedek_string");
            });

            modelBuilder.Entity<Soforler>(entity =>
            {
                entity.HasKey(e => e.SoforID)
                    .HasName("PK_dbo.Soforler");

                entity.ToTable("Soforler");

                entity.Property(e => e.SoforID).HasColumnName("SoforID");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Bolge).HasMaxLength(30);

                entity.Property(e => e.GuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Kodu).HasMaxLength(20);

                entity.Property(e => e.Nakliyeci).HasMaxLength(50);

                entity.Property(e => e.OlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Parola).HasMaxLength(20);

                entity.Property(e => e.Pasif).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plaka).HasMaxLength(10);

                entity.Property(e => e.Sehir).HasMaxLength(30);

                entity.Property(e => e.SonGuncelleyen).HasMaxLength(20);

                entity.Property(e => e.Soyadi).HasMaxLength(50);
            });

            modelBuilder.Entity<SubeSatis>(entity =>
            {
                entity.HasKey(e => e.SubeID)
                    .HasName("PK_dbo.SubeSatis");

                entity.Property(e => e.SubeID).HasColumnName("SubeID");

                entity.Property(e => e.Aciklama).HasMaxLength(250);

                entity.Property(e => e.Ortalama).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubeAdi).HasMaxLength(20);

                entity.Property(e => e.SubeKisaAdi).HasMaxLength(10);

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.Property(e => e.ToplamTutar).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ur_toplam>(entity =>
            {
                entity.ToTable("ur_toplam");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.bagkur)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bagkur");

                entity.Property(e => e.bagkur_or)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bagkur_or");

                entity.Property(e => e.bors_pay_or)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bors_pay_or");

                entity.Property(e => e.borsapay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("borsapay");

                entity.Property(e => e.depo_sira_no).HasColumnName("depo_sira_no");

                entity.Property(e => e.fon)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fon");

                entity.Property(e => e.fon_pay_or)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fon_pay_or");

                entity.Property(e => e.hamaliye)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hamaliye");

                entity.Property(e => e.il)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("il");

                entity.Property(e => e.koop_gid_or)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("koop_gid_or");

                entity.Property(e => e.koopgid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("koopgid");

                entity.Property(e => e.nak_zarar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("nak_zarar");

                entity.Property(e => e.nakliye)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("nakliye");

                entity.Property(e => e.net)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("net");

                entity.Property(e => e.odenecek)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("odenecek");

                entity.Property(e => e.stopaj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stopaj");

                entity.Property(e => e.stopaj_or)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stopaj_or");

                entity.Property(e => e.sube)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sube");

                entity.Property(e => e.tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");

                entity.Property(e => e.tediye_yazildimi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tediye_yazildimi");

                entity.Property(e => e.tedno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tedno");

                entity.Property(e => e.tip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tip");

                entity.Property(e => e.toplam)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("toplam");

                entity.Property(e => e.ur_no)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ur_no");

                entity.Property(e => e.uretici)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("uretici");

                entity.Property(e => e.yedek1_decimal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("yedek1_decimal");

                entity.Property(e => e.yedek1_int).HasColumnName("yedek1_int");

                entity.Property(e => e.yedek1_string)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("yedek1_string");

                entity.Property(e => e.yedek_decimal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("yedek_decimal");

                entity.Property(e => e.yedek_int).HasColumnName("yedek_int");
            });

            modelBuilder.Entity<URETICI_ODEMELER2>(entity =>
            {
                entity.HasKey(e => e.URETICI_ODEME_ID)
                    .HasName("PK_URETICI_ODEME");

                entity.ToTable("URETICI_ODEMELER2");

                entity.Property(e => e.URETICI_ODEME_ID).HasColumnName("URETICI_ODEME_ID");

                entity.Property(e => e.ACIKLAMA)
                    .HasMaxLength(50)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.GuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.ODEME)
                    .HasMaxLength(50)
                    .HasColumnName("ODEME");

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncelleyen).HasMaxLength(20);

                entity.Property(e => e.TARIH)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");

                entity.Property(e => e.URETICI_ID).HasColumnName("URETICI_ID");
            });

            modelBuilder.Entity<URETICILER>(entity =>
            {
                entity.HasKey(e => e.URETICI_ID)
                    .HasName("PK_dbo.URETICILER");

                entity.ToTable("URETICILER");

                entity.Property(e => e.URETICI_ID).HasColumnName("URETICI_ID");

                entity.Property(e => e.ADI)
                    .HasMaxLength(50)
                    .HasColumnName("ADI");

                entity.Property(e => e.ADRES)
                    .HasMaxLength(200)
                    .HasColumnName("ADRES");

                entity.Property(e => e.BAGKUR_NO)
                    .HasMaxLength(50)
                    .HasColumnName("BAGKUR_NO");

                entity.Property(e => e.CEP_TELEFONU)
                    .HasMaxLength(20)
                    .HasColumnName("CEP_TELEFONU");

                entity.Property(e => e.DOGUM_TARIHI)
                    .HasColumnType("datetime")
                    .HasColumnName("DOGUM_TARIHI");

                entity.Property(e => e.DOGUM_YERI)
                    .HasMaxLength(50)
                    .HasColumnName("DOGUM_YERI");

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.GuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.IL)
                    .HasMaxLength(30)
                    .HasColumnName("IL");

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Parola).HasMaxLength(10);

                entity.Property(e => e.SonGuncelleyen).HasMaxLength(20);

                entity.Property(e => e.SOYADI)
                    .HasMaxLength(50)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.TCKIMLIK_NO)
                    .HasMaxLength(11)
                    .HasColumnName("TCKIMLIK_NO");

                entity.Property(e => e.URETICI_NO)
                    .HasMaxLength(50)
                    .HasColumnName("URETICI_NO");

                entity.Property(e => e.Yetki).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
