using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimSatis
{
    class Program
    {
        static void Main(string[] args)
        {
            IEgitimService egitimService = new EgitimManager(new EfEgitimDal(), new YuzdelikIndirimKampanyaManager());
            foreach (var egitim in egitimService.ListeleEgitimler())
            {
                Console.WriteLine(egitim.Ad + " = " + egitim.Fiyat);
            }

            Console.ReadLine();
        }
    }

    class Egitim : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
    }

    class EgitimManager : IEgitimService
    {
        IEgitimDal _egitimDal;
        IKampanyaService _kampanyaService;
        public EgitimManager(IEgitimDal egitimDal, IKampanyaService kampanyaService)
        {
            _egitimDal = egitimDal;
            _kampanyaService = kampanyaService;
        }
        public List<Egitim> ListeleEgitimler()
        {
            var egitimler = _egitimDal.ListeleEgitimler();
            _kampanyaService.FiyatGuncelle(egitimler);
            return egitimler;
        }
    }

    interface IEgitimDal
    {
        List<Egitim> ListeleEgitimler();
    }

    class EfEgitimDal : IEgitimDal
    {
        public List<Egitim> ListeleEgitimler()
        {
            return new List<Egitim>
            {
                new Egitim{Id=1,Ad="C# Kursu",Fiyat=400},
                new Egitim{Id=2,Ad="Java Kursu",Fiyat=300},
                new Egitim{Id=3,Ad="Python Kursu",Fiyat=200}
            };
        }
    }

    interface IEntity
    {
    }

    interface IEgitimService
    {
        List<Egitim> ListeleEgitimler();
    }

    interface IKampanyaService
    {
        void FiyatGuncelle(List<Egitim> egitimler);
    }

    class StandartFiyatKapmanyaManager : IKampanyaService
    {
        public void FiyatGuncelle(List<Egitim> egitimler)
        {
            foreach (var egitim in egitimler)
            {
                egitim.Fiyat = GuncelStandartFiyatıGetir();
            }
        }

        private decimal GuncelStandartFiyatıGetir()
        {
            //Veri tabanına bağlan.
            return 25;
        }
    }

    class YuzdelikIndirimKampanyaManager : IKampanyaService
    {
        public void FiyatGuncelle(List<Egitim> egitimler)
        {
            foreach (var egitim in egitimler)
            {
                egitim.Fiyat = egitim.Fiyat - (egitim.Fiyat * YuzdelikIndirimiGetir());
            }
        }

        private decimal YuzdelikIndirimiGetir()
        {
            //Veri tabanına bağlan.
            return Convert.ToDecimal(0.90);
        }
    }
}
