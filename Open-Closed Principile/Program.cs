using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bu örnek SOLID prensipleri içerisinde Open-Closed prensibini içerir.
            // Bu prensipte amaç class veya metodların gelişime açık değişime kapalı olmalarıdır.
            // Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir.
            // Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.
            // Bu örnek tek bir tane Report sınfından kalıtım alan bir sınıf oluşturarak ve içerisine bir adet
            // raporoluştur metodu yazılarak bu metodun içerisinde if blokları ile birden fazla rapor dosyası oluşturulabilir.
            // Ancak birden fazla türde rapor oluşturulursa bu performans kaybına , görüntü kirliliğine , uyumlu kodu ve temiz kodu
            // etkiler.

            CreateCSVReport csv = new CreateCSVReport()
            {
                ReportId = 10,
                ReportName = "Musa"
            };

            CreatePDFReport pdf = new CreatePDFReport()
            {
                ReportId = 1,
                ReportName = "Mustafa"
            };

            csv.CreateReport();
            pdf.CreateReport();

            Console.ReadKey(); // Finish
        }
    }
}
