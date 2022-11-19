using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9ServerApiTekrar.Model
{
    public class Kisi
    {
        public int Id { get; set; }
        public int Tc { get; set; }
        public string Ad { get; set; }

        private string _Soyad;
        public string Soyad 
        {
            get { return _Soyad; }
            set
            {
                _Soyad = value.ToUpper();
            }
        }

        private DateTime _datetime;
        public DateTime datetime 
        {
            get { return _datetime; }
            set
            {
                _datetime = (DateTime.Now.Year-value.Year)>=20?value:throw new Exception(" Yaşınız 20 den küçükse giriş yapılamaz.");
            }
        }
        public Cinsiyet cinsiyet { get; set; }
    }
    public enum Cinsiyet {K, E}
}
