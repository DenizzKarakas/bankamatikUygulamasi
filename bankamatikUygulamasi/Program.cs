using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace bankamatikUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 25000;
            string kartNo = "123456789123";
            int krediBakiye = 0;
        ÇIKIŞ:
            Console.WriteLine("Hoş Geldiniz");
            Console.WriteLine("Kartlı İşlem Menüsü İçin: 1");
            Console.WriteLine("Kartsız İşlem Menüsü İçin: 2");

            int islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Console.WriteLine("Kartlı İşlem Menüsü");
                Console.WriteLine("Şifrenizi Giriniz");

                string sifre = "ab18";
                string Sifre = Console.ReadLine();

                if (Sifre == sifre)
                {
                    Console.WriteLine("Şifre Doğru");
                KARTLIİŞLEMMENÜSÜ:
                    Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
                    Console.WriteLine("Para Çekmek İçin: 1");
                    Console.WriteLine("Para Yatırmak İçin: 2");
                    Console.WriteLine("Para Transferi İçin: 3");
                    Console.WriteLine("Eğitim Ödemeleri İçin: 4");
                    Console.WriteLine("Ödemeler İçin: 5");
                    Console.WriteLine("Bilgi Güncelleme İçin: 6");

                    int kartliİslem = Convert.ToInt32(Console.ReadLine());

                    if (kartliİslem == 1)
                    {
                        Console.WriteLine("Mevcut Bakiyeniz: " + bakiye);
                        Console.WriteLine("Çekmek İstediğniz Tutarı Giriniz");
                        int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                        if (cekilecekTutar > bakiye)
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                        }
                        else
                        {
                            bakiye = bakiye - cekilecekTutar;
                            Console.WriteLine("Mevcut Bakiye " + bakiye);

                        }
                    }
                    else if (kartliİslem == 2)
                    {
                        Console.WriteLine("Mevcut Bakiyeniz: " + bakiye);
                        Console.WriteLine("Mevcut Kredi Bakiyeniz: " + krediBakiye);

                        Console.WriteLine("Kredi Hesabı İçin:1");
                        Console.WriteLine("Kendi Hesabınız İçin:2");
                        int hesapİslemi = Convert.ToInt32(Console.ReadLine());

                        if (hesapİslemi == 1)
                        {
                            Console.WriteLine("Kredi Numaranızı Giriniz");
                            string KartNo = Console.ReadLine();

                            if (kartNo == KartNo)
                            {
                                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                                int KrediBakiye = Convert.ToInt32(Console.ReadLine());
                                if (KrediBakiye > bakiye)
                                {
                                    Console.WriteLine("Bakiye Yetersiz");

                                }
                                else
                                {
                                    krediBakiye = krediBakiye + KrediBakiye;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kart Numarası Yanlış");
                            }


                        }
                        else if (hesapİslemi == 2)
                        {
                            Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                            int yatırılanTutar = Convert.ToInt32(Console.ReadLine());
                            bakiye = yatırılanTutar + bakiye;
                            Console.WriteLine("İşlem Başarılı");
                            Console.WriteLine("Mevcut Bakiye: " + bakiye);
                        }
                        else { Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz"); }

                    }
                    else if (kartliİslem == 3)
                    {
                        Console.WriteLine("Başka Hesaba EFT: 1");
                        Console.WriteLine("Başka Hesaba Havale İçin: 2");

                        int eftİslemNo = Convert.ToInt32(Console.ReadLine());

                        if (eftİslemNo == 1)
                        {
                            Console.WriteLine("EFT numarası giriniz (başında TR olmalı)");
                            string eftYapilacakHesap = Console.ReadLine();

                            if ((eftYapilacakHesap.StartsWith("TR")) && (eftYapilacakHesap.Length == 14))
                            {
                                Console.WriteLine("Göndermek İstediğiniz Tutarı Giriniz");
                                int eftYapilacakMiktar = Convert.ToInt32(Console.ReadLine());

                                if (eftYapilacakMiktar > bakiye)
                                {
                                    Console.WriteLine("Bakiye Yetersiz");
                                }
                                else
                                {
                                    bakiye = bakiye - eftYapilacakMiktar;
                                    Console.WriteLine("Gönderme İşlemi Başarılı");
                                    Console.WriteLine("Mevcut Bakiye: " + bakiye);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçerli Bir Hesap Giriniz");
                            }
                        }
                        else if (eftİslemNo == 2)
                        {
                            Console.WriteLine("Hesap numarası giriniz (11 haneli olmalı)");
                            string eftHesapNo = Console.ReadLine();

                            if (eftHesapNo.Length == 11)
                            {
                                Console.WriteLine("Göndermek İstediğiniz Tutarı Giriniz");
                                int eftHesapYapilacakMiktar = Convert.ToInt32(Console.ReadLine());

                                if (eftHesapYapilacakMiktar > bakiye)
                                {
                                    Console.WriteLine("Bakiye Yetersiz");
                                }
                                else
                                {
                                    bakiye = bakiye - eftHesapYapilacakMiktar;
                                    Console.WriteLine("Gönderme İşlemi Başarılı");
                                    Console.WriteLine("Mevcut Bakiye: " + bakiye);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hesap numarası yanlış");
                            }

                        }
                        else { Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz"); }

                    }
                    else if (kartliİslem == 4)
                    {
                        Console.WriteLine("Eğitim Ödemeleri sayfası arızalı");
                    }
                    else if (kartliİslem == 5)
                    {
                    GEÇERLİİŞLEM:
                        Console.WriteLine("Ödemeler");
                        Console.WriteLine("Lütfen Yapmak İstediğiniz Ödemeyi Tuşlayınız");
                        Console.WriteLine("Elektrik Faturası İçin: 1");
                        Console.WriteLine("Telefon Faturası İçin: 2");
                        Console.WriteLine("İnternet Faturası İçin: 3");
                        Console.WriteLine("Su Faturası İçin: 4");
                        Console.WriteLine("OGS Ödemesi İçin: 5");
                        int ödeme = Convert.ToInt32(Console.ReadLine());
                        int elektrikFaturası = 500;
                        int telefonFaturası = 650;
                        int internetFaturası = 400;
                        int suFaturası = 300;
                        int ogsFaturası = 50;
                        if (ödeme == 1)
                        {
                            if (bakiye > elektrikFaturası)
                            {

                                Console.WriteLine("Elektrik Faturası Tutarınız: " + elektrikFaturası);
                                Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                                Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                                int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                                if (ödemeİslem == 0)
                                {
                                    Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                    goto KARTLIİŞLEMMENÜSÜ;
                                }
                                else
                                {
                                    bakiye = bakiye - elektrikFaturası;
                                    Console.WriteLine("Ödeme Başarılı");
                                    Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                                }

                            }
                            else { Console.WriteLine("Yetersiz Bakiye"); }


                        }
                        else if (ödeme == 2)
                        {
                            if (bakiye > telefonFaturası)
                            {
                                Console.WriteLine("Telefon Faturası Tutarınız: " + telefonFaturası);
                                Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                                Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                                int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                                if (ödemeİslem == 0)
                                {
                                    Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                    goto KARTLIİŞLEMMENÜSÜ;
                                }
                                else
                                {
                                    bakiye = bakiye - telefonFaturası;
                                    Console.WriteLine("Ödeme Başarılı");
                                    Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                            }
                        }
                        else if (ödeme == 3)
                        {
                            if (bakiye > internetFaturası)
                            {
                                Console.WriteLine("İnternet Faturası Tutarınız: " + internetFaturası);
                                Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                                Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                                int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                                if (ödemeİslem == 0)
                                {
                                    Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                    goto KARTLIİŞLEMMENÜSÜ;
                                }
                                else
                                {
                                    bakiye = bakiye - internetFaturası;
                                    Console.WriteLine("Ödeme Başarılı");
                                    Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                                }

                            }
                            else { Console.WriteLine("Yetersiz Bakiye"); }
                        }
                        else if (ödeme == 4)
                        {
                            if (bakiye > suFaturası)
                            {

                                Console.WriteLine("Su Faturası Tutarınız: " + suFaturası);
                                Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                                Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                                int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                                if (ödemeİslem == 0)
                                {
                                    Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                    goto KARTLIİŞLEMMENÜSÜ;
                                }
                                else
                                {
                                    bakiye = bakiye - suFaturası;
                                    Console.WriteLine("Ödeme Başarılı");
                                    Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                                }

                            }
                            else { Console.WriteLine("Yetersiz Bakiye"); }
                        }
                        else if (ödeme == 5)
                        {
                            if (bakiye > ogsFaturası)
                            {
                                Console.WriteLine("OGS Faturası Tutarınız: " + ogsFaturası);
                                Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                                Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                                int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                                if (ödemeİslem == 0)
                                {
                                    Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                    goto KARTLIİŞLEMMENÜSÜ;
                                }
                                else
                                {
                                    bakiye = bakiye - ogsFaturası;
                                    Console.WriteLine("Ödeme Başarılı");
                                    Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                                }

                            }
                            else { Console.WriteLine("Yetersiz Bakiye"); }
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                            goto GEÇERLİİŞLEM;
                        }
                    }
                    else if (kartliİslem == 6)
                    {
                        Console.WriteLine("Şifre Değiştirmek İçin: 1");
                        int sifreDegistir = Convert.ToInt32(Console.ReadLine());
                        if (sifreDegistir == 1)
                        {
                            Console.WriteLine("Yeni Şifrenizi Giriniz");
                            string yeniSifre = Console.ReadLine();
                            Console.WriteLine("Şifrenizi Tekrar Giriniz");
                            string yeniSifre2 = Console.ReadLine();
                            if (yeniSifre == yeniSifre2)
                            {
                                Console.WriteLine("İşlem Başarılı");
                            }
                            else
                            {
                                Console.WriteLine("Şifreler Eşleşmiyor");
                            }


                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                            goto KARTLIİŞLEMMENÜSÜ;
                        }


                    }
                    else { Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz"); }
                    Console.WriteLine("Çıkmak İçin: 0");
                    Console.WriteLine("Ana Menü İçin: 9");
                    int istenilenIslem = Convert.ToInt32(Console.ReadLine());

                    if (istenilenIslem == 9)
                    {
                        goto KARTLIİŞLEMMENÜSÜ;
                    }
                    else if (istenilenIslem == 0)
                    {
                        goto ÇIKIŞ;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                        goto KARTLIİŞLEMMENÜSÜ;
                    }
                }    

                }
            else if (islem == 2)
            {
                KARTSIZİŞLEMMENÜSÜ:
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
                Console.WriteLine("CepBank Para Çekmek İçin: 1");
                Console.WriteLine("Para Yatırmak İçin: 2");
                Console.WriteLine("Kredi Kartı Ödeme İçin: 3");
                Console.WriteLine("Eğitim Ödemeleri İçin: 4");
                Console.WriteLine("Ödemeler İçin: 5");
               
                int kartsızIslem = Convert.ToInt32(Console.ReadLine());
                if (kartsızIslem == 1)
                {
                    Console.WriteLine("Cep Telefonu Numaranızı Giriniz");
                    string cepNo = Console.ReadLine();
                    Console.WriteLine("TC Kimlik Numaranızı Giriniz");
                    string tcNo = Console.ReadLine();
                    if ((tcNo.Length == 11) && (cepNo.Length == 11))
                    {
                        Console.WriteLine("İşlem Başarılı");
                        Console.WriteLine("1000 TL Çekilmiştir");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli TC Kimlik Numarası Ve Cep Numarası Giriniz");
                        goto KARTSIZİŞLEMMENÜSÜ;
                    }

                }
                else if (kartsızIslem == 2)
                {
                    Console.WriteLine("Nakit Ödeme İçin: 1");
                    Console.WriteLine("Hesaptan Ödeme İçin: 2");
                    int odemeIslem = Convert.ToInt32(Console.ReadLine());
                    if (odemeIslem == 1)
                    {
                        Console.WriteLine("Lütfen Para Girişi Yapınız: ");
                        Console.WriteLine("Kredi Kartı Numaranızı Giriniz (En az 12 haneli olmalı)");
                        string krediKartNo = Console.ReadLine();
                        Console.WriteLine("TC Kimlik Numaranızı Giriniz (11 haneli olmalı)");
                        string TCKimlikNo = Console.ReadLine();

                        if (krediKartNo.Length >= 12 && TCKimlikNo.Length == 11)
                        {
                            Console.WriteLine("Nakit Ödeme İşleminiz Gerçekleşmiştir");
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli TC Kimlik Numarası Ve Kredi Kartı Numarası Giriniz");
                            goto KARTSIZİŞLEMMENÜSÜ;
                        }
                    }
                    else if (odemeIslem == 2)
                    {
                        Console.WriteLine("Kredi Kartı Numaranızı Giriniz (En az 12 haneli olmalı)");
                        string krediKartNo = Console.ReadLine();
                        Console.WriteLine("Hesap numarası giriniz (11 haneli olmalı)");
                        string hesapNo = Console.ReadLine();

                        if (krediKartNo.Length >= 12 && hesapNo.Length == 11)
                        {
                            Console.WriteLine("Hesaptan Ödeme İşleminiz Gerçekleşmiştir");
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Hesap Numarası Ve Kredi Kartı Numarası Giriniz");
                            goto KARTSIZİŞLEMMENÜSÜ;
                        }
                    }

                }
                else if (kartsızIslem == 3) {
                    Console.WriteLine("Başka Hesaba EFT: 1");
                    Console.WriteLine("Başka Hesaba Havale İçin: 2");

                    int eftİslemNo = Convert.ToInt32(Console.ReadLine());

                    if (eftİslemNo == 1)
                    {
                        Console.WriteLine("EFT numarası giriniz (başında TR olmalı)");
                        string eftYapilacakHesap = Console.ReadLine();

                        if ((eftYapilacakHesap.StartsWith("TR")) && (eftYapilacakHesap.Length == 14))
                        {
                            Console.WriteLine("Göndermek İstediğiniz Tutarı Giriniz");
                            int eftYapilacakMiktar = Convert.ToInt32(Console.ReadLine());

                            if (eftYapilacakMiktar > bakiye)
                            {
                                Console.WriteLine("Bakiye Yetersiz");
                            }
                            else
                            {
                                bakiye = bakiye - eftYapilacakMiktar;
                                Console.WriteLine("Gönderme İşlemi Başarılı");
                                Console.WriteLine("Mevcut Bakiye: " + bakiye);

                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçerli Bir Hesap Giriniz");
                        }
                    }
                    else if (eftİslemNo == 2)
                    {
                        Console.WriteLine("Hesap numarası giriniz (11 haneli olmalı)");
                        string eftHesapNo = Console.ReadLine();

                        if (eftHesapNo.Length == 11)
                        {
                            Console.WriteLine("Göndermek İstediğiniz Tutarı Giriniz");
                            int eftHesapYapilacakMiktar = Convert.ToInt32(Console.ReadLine());

                            if (eftHesapYapilacakMiktar > bakiye)
                            {
                                Console.WriteLine("Bakiye Yetersiz");
                            }
                            else
                            {
                                bakiye = bakiye - eftHesapYapilacakMiktar;
                                Console.WriteLine("Gönderme İşlemi Başarılı");
                                Console.WriteLine("Mevcut Bakiye: " + bakiye);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hesap numarası yanlış");
                        }

                    }
                    else { Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz"); }
                }
                else if (kartsızIslem == 4)
                {
                    Console.WriteLine("Eğitim Ödemeleri sayfası arızalı");
                    goto KARTSIZİŞLEMMENÜSÜ;
                }
                else if (kartsızIslem == 5)
                {
                GEÇERLİİŞLEM:
                    Console.WriteLine("Ödemeler");
                    Console.WriteLine("Lütfen Yapmak İstediğiniz Ödemeyi Tuşlayınız");
                    Console.WriteLine("Elektrik Faturası İçin: 1");
                    Console.WriteLine("Telefon Faturası İçin: 2");
                    Console.WriteLine("İnternet Faturası İçin: 3");
                    Console.WriteLine("Su Faturası İçin: 4");
                    Console.WriteLine("OGS Ödemesi İçin: 5");
                    int ödeme = Convert.ToInt32(Console.ReadLine());
                    int elektrikFaturası = 500;
                    int telefonFaturası = 650;
                    int internetFaturası = 400;
                    int suFaturası = 300;
                    int ogsFaturası = 50;
                    if (ödeme == 1)
                    {
                        if (bakiye > elektrikFaturası)
                        {

                            Console.WriteLine("Elektrik Faturası Tutarınız: " + elektrikFaturası);
                            Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                            Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                            int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                            if (ödemeİslem == 0)
                            {
                                Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                goto KARTSIZİŞLEMMENÜSÜ;
                            }
                            else
                            {
                                bakiye = bakiye - elektrikFaturası;
                                Console.WriteLine("Ödeme Başarılı");
                                Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                            }

                        }
                        else { Console.WriteLine("Yetersiz Bakiye"); }


                    }
                    else if (ödeme == 2)
                    {
                        if (bakiye > telefonFaturası)
                        {
                            Console.WriteLine("Telefon Faturası Tutarınız: " + telefonFaturası);
                            Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                            Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                            int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                            if (ödemeİslem == 0)
                            {
                                Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                goto KARTSIZİŞLEMMENÜSÜ;
                            }
                            else
                            {
                                bakiye = bakiye - telefonFaturası;
                                Console.WriteLine("Ödeme Başarılı");
                                Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                        }
                    }
                    else if (ödeme == 3)
                    {
                        if (bakiye > internetFaturası)
                        {
                            Console.WriteLine("İnternet Faturası Tutarınız: " + internetFaturası);
                            Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                            Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                            int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                            if (ödemeİslem == 0)
                            {
                                Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                goto KARTSIZİŞLEMMENÜSÜ;
                            }
                            else
                            {
                                bakiye = bakiye - internetFaturası;
                                Console.WriteLine("Ödeme Başarılı");
                                Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                            }

                        }
                        else { Console.WriteLine("Yetersiz Bakiye"); }
                    }
                    else if (ödeme == 4)
                    {
                        if (bakiye > suFaturası)
                        {

                            Console.WriteLine("Su Faturası Tutarınız: " + suFaturası);
                            Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                            Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                            int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                            if (ödemeİslem == 0)
                            {
                                Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                goto KARTSIZİŞLEMMENÜSÜ;
                            }
                            else
                            {
                                bakiye = bakiye - suFaturası;
                                Console.WriteLine("Ödeme Başarılı");
                                Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                            }

                        }
                        else { Console.WriteLine("Yetersiz Bakiye"); }
                    }
                    else if (ödeme == 5)
                    {
                        if (bakiye > ogsFaturası)
                        {
                            Console.WriteLine("OGS Faturası Tutarınız: " + ogsFaturası);
                            Console.WriteLine("Ödeme Yapmak İçin Herhangi Bir Tuşa Basınız");
                            Console.WriteLine("Ödeme Yapmamak İçin 0 (sıfır) Tuşuna Basınız");
                            int ödemeİslem = Convert.ToInt32(Console.ReadLine());
                            if (ödemeİslem == 0)
                            {
                                Console.WriteLine("Ödeme Yapılmaktan Vazgeçildi");
                                goto KARTSIZİŞLEMMENÜSÜ;
                            }
                            else
                            {
                                bakiye = bakiye - ogsFaturası;
                                Console.WriteLine("Ödeme Başarılı");
                                Console.WriteLine("Mevcut Bakiyeniz:" + bakiye);
                            }

                        }
                        else { Console.WriteLine("Yetersiz Bakiye"); }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                        goto GEÇERLİİŞLEM;
                    }
                }
                else { Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz"); }
                Console.WriteLine("Çıkmak İçin: 0");
                Console.WriteLine("Ana Menü İçin: 9");
                int istenilenIslem = Convert.ToInt32(Console.ReadLine());

                if (istenilenIslem == 9)
                {
                    goto KARTSIZİŞLEMMENÜSÜ;
                }
                else if (istenilenIslem == 0)
                {
                    goto ÇIKIŞ;
                }
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                    goto KARTSIZİŞLEMMENÜSÜ;
                }
            }




        }
        
        






        }
    }
