using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Web.Api.Controllers
{
    public class TombalaController : ControllerBase
    {
        IUreticilerService ureticilerService;
        ISoforlerService soforlerService;
        INakliyeTombalaService nakliyeTombalaService;

        public TombalaController(IUreticilerService ureticilerService, ISoforlerService soforlerService, INakliyeTombalaService nakliyeTombalaService)
        {
            this.ureticilerService = ureticilerService;
            this.soforlerService = soforlerService;
            this.nakliyeTombalaService = nakliyeTombalaService;
        }



        [HttpPost("tombalagetir")]
        public IActionResult Get(TombalaGetDTO tombalaGet)
        {
            var response = new ListDataResult<NakliyeTombala>();

            try
            {
                List<NakliyeTombala> list = nakliyeTombalaService.TombalaGetir(tombalaGet.Sofor_Kodu, tombalaGet.Bolge, tombalaGet.Plaka);
                response.Data = list;
            }
            catch
            {
                return Ok(new ErrorResult("Tombala bulunamadı."));

            }

            return Ok(response);

        }

        [HttpPost("tombalakaydet")]
        public IActionResult Insert(TombalaInsertDTO tombalaInsert)
        {
            if (!ModelState.IsValid)
            {
                return Ok(new ErrorResult("Parametre Hatası"));
            }

            if (!int.TryParse(tombalaInsert.Adet, out _))
            {
                return Ok(new ErrorResult("Adet Uygun formatta girilmedi."));
            }


            Soforler soforler = soforlerService.GetDriver(tombalaInsert.Sofor_Kodu);

            if (soforler == null)
            {
                return Ok(new ErrorResult("Şoför bulunamadı."));
            }


            URETICILER uretici = null;

            if (tombalaInsert.UreticiKodu.Trim() != "")
            {
                uretici = ureticilerService.GetById(tombalaInsert.UreticiKodu);
            }
            else if (tombalaInsert.Barkod.Trim() != "")
            {
                string Barkodd = "";

                if (!tombalaInsert.Barkod.ToUpper().StartsWith("FLORA"))
                {
                    return Ok(new ErrorResult("Uygun Barkod Okutulmadı."));
                }

                if (tombalaInsert.Barkod.Length < 10 || tombalaInsert.Barkod.Length > 12)
                {
                    return Ok(new ErrorResult("Uygun Barkod Okutulmadı."));
                }

                Barkodd = tombalaInsert.Barkod.Substring(8);

                if (Barkodd.StartsWith("0"))
                {
                    Barkodd = RemoveLeadingZeros(Barkodd);
                }

                uretici = ureticilerService.GetById(Barkodd);
            }

            if (uretici == null)
            {
                return Ok(new ErrorResult("Geçerli bir üretici bulunamadı."));
            }


            bool durum = nakliyeTombalaService.TombalaKaydet(new NakliyeTombala
            {
                Bolge = tombalaInsert.Bolge,
                Plaka = tombalaInsert.Plaka,
                SoforKodu = soforler.Kodu,
                SonGuncelleyen = soforler.Kodu,
                UreticiAdiSoyadi = uretici.ADI + " " + uretici.SOYADI,
                UreticiIli = uretici.IL,
                UreticiKodu = uretici.URETICI_NO,
                Adet = Convert.ToInt32(tombalaInsert.Adet),
                Nakliyeci = soforler.Nakliyeci,
                Tarih = DateTime.Now,
            });


            if (!durum)
            {
                return Ok(new ErrorResult("Hata Oluştu."));
            }

            return Ok(new SuccessResult("Başarıyla Kaydedildi"));
        }

        [HttpGet("tombalasil")]
        public IActionResult Delete(int id)
        {
            bool durum = nakliyeTombalaService.TombalaSil(id);

            if (durum)
            {
                return Ok("Kayıt Silindi");
            }
            else
            {
                return BadRequest("Hata Kayıt Silinemedi.");
            }
        }


        string RemoveLeadingZeros(string str)
        {
            string regex = "^0+(?!$)";

            str = System.Text.RegularExpressions.Regex.Replace(str, regex, "");

            return str;
        }
    }
}
