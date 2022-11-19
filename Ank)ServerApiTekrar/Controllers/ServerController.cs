using Ank9ServerApiTekrar.Model;
using Ank9ServerApiTekrar.Model.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ank_ServerApiTekrar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private readonly ServerApiContext _context;

        public ServerController(ServerApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Kisi> Get()
        {
            List<Kisi> kisiler = _context.Kisiler.OrderByDescending(x=>x.cinsiyet).ToList();
            return kisiler;
        }
        [HttpGet("{Tc}")]
        public Kisi Getir(int Tc)
        {
            Kisi kisi = _context.Kisiler.Where(x => x.Tc == Tc).FirstOrDefault();
            return kisi;
        }
        [HttpPost]
        public void Ekle(Kisi kisi)
        {
            _context.Kisiler.Add(kisi);
            _context.SaveChanges();
        }
        [HttpPut]
        public void Degistir(int id,Kisi kisi)
        {
            Kisi eski = _context.Kisiler.Where(x => x.Id == id).FirstOrDefault();
            eski.Ad = kisi.Ad;
            eski.Soyad=kisi.Soyad;
            eski.cinsiyet= kisi.cinsiyet;
            eski.Tc=kisi.Tc;
            eski.datetime=kisi.datetime;
            _context.Kisiler.Update(eski);
            _context.SaveChanges();
        }
        [HttpDelete]
        public void Sil(string ad,string soyad)
        {
            Kisi sil = _context.Kisiler.Where(x =>  x.Ad == ad && x.Soyad == soyad).FirstOrDefault();
            _context.Kisiler.Remove(sil);
            _context.SaveChanges();
        }
        [HttpPost("{mount}")]
        public List<Kisi> AyaGöre(int mount)
        {
            List<Kisi> list = _context.Kisiler.Where(x=>x.datetime.Month==mount).OrderByDescending(x=>x.datetime).ToList();
            return list;
        }
    }
}
