// See https://aka.ms/new-console-template for more information



using Bussinies.Concreate;
using DataAcces.Concreate.EntityFramework;

KullaniciGirisManager kgm = new KullaniciGirisManager(new EFKullaniciGirisDAL());
foreach (var item in kgm.GetAllOf())
{
    Console.WriteLine(item.KullaniciSifre + item.KullaniciAdi);
}//Başarılıyız