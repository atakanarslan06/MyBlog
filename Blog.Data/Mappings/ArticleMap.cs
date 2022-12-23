using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Asp.Net Mvc ile yeni bir projeye başlarken genelde aşağı yukarı aynı mimari yapıyı oluşturuyoruz. Domain nesnelerini ve iş mantığını barındıran bir sınıf kütüphanesi, domain nesneleri ile veritabanı arasındaki köprü olan veri katmanı sınıf kütüphanesi (Repository sınıfları vb.), web içeriklerini bulunduran Asp.Net Mvc uygulaması, Controller sınıfları için ayrı bir sınıf kütüphanesi projesi gibi. Tüm bu projeler arasında bağımlılığı ortadan kaldırmak için Dependency Injection, kodların tutarlılığını kontrol altında tutabilmek için de birim testi projeleri de çözüme eklediğimiz projeler arasında. Gereksinimlere göre proje sayısı daha da artabilir :) Konumuz proje sayısı değil tabi ki, bahsettiğim mimari yapıyı hazır olarak sunan ve birkaç projede bize hız kazandıran başarılı bir framework konumuz.",
                ViewCount = 15,
                CategoryId = Guid.Parse("0DD270C3-836B-45B9-AA86-897AE30630DD"),
                ImageId = Guid.Parse("A8812BFC-F85C-44B4-8D36-9B474F23B02C"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("48E58468-8A50-46AD-AC18-04EC33FA1818")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi 1",
                Content = "Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.Visual Studio Code Nedir?Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır.01 Ağustos 2019Günümüzde programlama dilleri bağımsız bir alana taşınmaya başlanmıştır. Bir programlama dili ile geliştirme yapmak için her türlü işletim sistemi kullanılabilir olmalıdır. Son bir kaç yılda Microsoft bu değişime ayak uydurarak açık kaynak ürünler ve platform bağımsız teknolojiler üretmeye başlamıştır. Microsoft .net ile artık Mac OS ve Linux platformlarında geliştirme yapmak mümkün hale gelmiştir. Visual Studio Code hızlı, hafif olmanın yanında Microsoft, Linux ve Mac işletim sistemlerinde çalışabilen bir araçtır. Kurulum yapıldığında  basit bir metin editörü görüntüsü ile karşımıza çıkan ürün, eklentiler sayesinde Node JS, Ruby, Python, C/C++, C#, Javascript gibi bir çok programlama dilini desteklemektedir. Yani klasik Visual Studio ürünleri gibi her şeyi bünyesinde barındırmak yerine çekirdek bir yapı ile başlatılıp lazım olan parçaların eklentiler halinde ürüne eklenmesi sağlanarak mantıklı bir hareket yapılmıştır. Eklentilerin indirilebildiği bir market ortamı oluşturulmuştur.",
                ViewCount = 33,
                CategoryId =Guid.Parse("50C2EED1-C93D-4A9D-8D52-B197EB48D509"),
                ImageId = Guid.Parse("038F524A-4480-4B81-A013-B68C1A5FED8E"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("5C4C8997-E65F-46C2-B823-6B882CF151A3")

            }
            );
        }
    }
}
