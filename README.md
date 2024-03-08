# Asp.Net Mvc ile Teknoji Sözlük Uygulaması Geliştirme     
        
Bu proje, Mvc dünyasına kurumsal mimari ile code first yaklaşımını kullanarak oluşturulan bir projedir.Asp.Net Mvc kullanarak bir  Sözlük benzeri uygulama geliştirmeyi ele alır. Projede kullanılan teknolojiler arasında Asp.Net Mvc, SQL Server, Entity Framework, Bootstrap, Fluent Validation ve N-Tier Architecture(Katmanlı Mimarisi) bulunmaktadır.
## Proje Detayları : 
 
### 1. Model-View-Controller (MVC) Mimarisi:
  
Projede MVC mimarisini kullanarak kodu modüler hale getiriyoruz. Model, View ve Controller bileşenlerini ayrı tutarak geliştirme sürecini daha organize hale getiriyoruz.

### 2. Bootstrap ile Kullanıcı Arayüzü Tasarımı:

Kullanıcı arayüzü tasarımında Bootstrap CSS framework'ünü kullanarak modern ve responsive bir tasarım oluşturuyoruz. Bu sayede uygulamamız farklı cihazlarda ve ekran boyutlarında uyumlu olacak.

### 3. Fluent Validation ile Veri Doğrulama:

Kullanıcı girişlerinin doğrulanması için Fluent Validation kütüphanesini kullanıyoruz. Bu sayede gelen verilerin doğruluğunu sağlayarak güvenliği artırıyoruz.

### 4. Entity Framework (CodeFirst):

Veritabanı entegrasyonunu kolaylaştırmak için Entity Framework'ü CodeFirst yaklaşımıyla kullanıyoruz. Bu sayede C# sınıflarından veritabanı tablolarını otomatik olarak oluşturarak veritabanı işlemlerini yönetiyoruz.

### 5. N-Tier Architecture(Katmanlı Mimari):

Projeyi katmanlara ayırarak N-Tier Architecture prensiplerine uygun olarak geliştiriyoruz. Bu sayede projeyi modüler hale getiriyor, bakımını kolaylaştırıyor ve genişletilebilir bir yapı oluşturuyoruz.

## Kullanılan Teknolojiler:

- **C# (C Sharp):** Veri işleme, iş mantığı ve diğer uygulama katmanlarının geliştirilmesinde kullanılan programlama dili.
  
- **Asp.Net Mvc5:** Web uygulamaları geliştirmek için kullanılan bir framework.
  
- **SQL Server:** Veritabanı yönetim sistemi.
  
- **Entity Framework:** Veritabanı entegrasyonunu kolaylaştırmak için kullanılan bir ORM aracı.
  
- **Bootstrap:** Responsive ve modern web arayüzleri oluşturmak için kullanılan bir CSS framework'ü.
  
- **Fluent Validation:** Veri doğrulamasını gerçekleştirmek için kullanılan bir kütüphane.
  
- **N-Tier Architecture:** Projeyi modüler hale getiren ve bakımını kolaylaştıran bir mimari yaklaşım.

Bu proje, geliştirme sürecinde karşılaşılan temel mimari kavramları ve teknolojilerini öğrenmek için ideal bir örnek olacaktır. Uygulama geliştirme sürecinde adım adım ilerleyerek, bir web uygulamasını baştan sona nasıl geliştireceğinizi detaylı olarak öğreneceksiniz.


## Proje İçeriği

Bu proje, MVC (Model-View-Controller) mimarisi kullanılarak geliştirilmiş bir web uygulamasıdır. Projede, aşağıdaki 4 ana bölüm bulunmaktadır:

### 1. Admin Paneli 🛠

Admin paneli, projenin yönetimini sağlayan bir arayüzdür. Admin kullanıcılarına özel olarak tasarlanmıştır ve genellikle aşağıdaki özellikleri içerir:

- **CRUD İşlemleri:** Kullanıcı ekleme, düzenleme ve silme işlemleri gibi temel veritabanı işlemlerini gerçekleştirme yeteneği.
  
- **Mesaj Yönetimi:** Kullanıcılar arasındaki mesajlaşma sisteminin yönetimi, mesajları görüntüleme ve yanıtlama yeteneği.
  
- **Site İstatistikleri:** Site ile ilgili istatistiklerin görüntülenmesi, ziyaretçi sayıları, en popüler içerikler gibi bilgilerin takibi.
- **Yetkilendirmeler:** Farklı kullanıcı rollerine göre erişim yetkilerini yönetme imkanı sağlar.
- **Galeri Yönetimi:** Projenin içeriğini zenginleştirmek için kullanılan görsellerin yönetimini sağlar.
- **Hakkımızda Sayfası Yönetimi:** Site hakkında bilgilerin bulunduğu "Hakkımızda" sayfasının içeriğini yönetir.
- **İletişim Mesajları Yönetimi:** Site ziyaretçileri tarafından gönderilen iletişim mesajlarının yönetimini sağlar.
- **Kategori Yönetimi:** İçeriklerin kategorize edilmesini sağlayan kategorilerin yönetimini sağlar.
- **Yazar Yönetimi:** Proje yazarlarının yönetimini sağlar.

### 2. Yazar Paneli 📝

Yazar paneli, kullanıcıların içerik eklemelerini ve düzenlemelerini sağlayan bir arayüzdür. Genellikle şu özellikleri içerir:

- **Yazı Oluşturma:** Yeni içeriklerin (makaleler, blog yazıları, vb.) oluşturulması.
- **Yazı Düzenleme:** Var olan içeriklerin düzenlenmesi ve güncellenmesi.
- **Yorum Yönetimi:** Kullanıcıların içeriklere yaptığı yorumların yönetimi, onaylama veya reddetme gibi işlemler.
- **Profilim:** Yazarın kişisel bilgilerini ve şifresini değiştirebilmektedir.
- **Başlıklarım:** Yazar kendi başlıklarını, başlıklarına yapılmış yorumları görebilir ve başlık işlemleri gerçekleştirebilir.
- **Tüm Başlıklar:** Sözlükteki aktif başlıkları görebilir, başlıklara yapılmış yorumları görebilir ve yorumlarını ekleyebilir.
- **Yazılarım:** Yazarın kendi yazılarını görebilir.
- **Mesajlar:** Kullanıcılar arasında mesajlaşmayı sağlar.

### 3. Sözlük 📖

Sözlük bölümü, projenin ana içeriğini oluşturan kısım olabilir. Genellikle şu özellikleri içerir:

- **Başlık Oluşturma:** Kullanıcıların yeni başlıklar oluşturmasına izin veren bir sistem.
  
- **Yorum Yapma:** Kullanıcıların başlıklara yorum eklemelerine izin verilir.
  
- **Başlık Arama:** Kullanıcıların başlıkları anahtar kelimelere veya kategorilere göre aramasını sağlayan bir arama özelliği.

### 4. Vitrin 🌟

Vitrin bölümü, projenin önemli içeriklerini veya duyurularını sergileyen bir alandır. Genellikle şu özellikleri içerebilir:

- **Öne Çıkan İçerikler:** Admin tarafından belirlenen ve önemli bulunan içeriklerin gösterilmesi.
  
- **Etkinlikler ve Duyurular:** Yaklaşan etkinliklerin veya projeye ait duyuruların yayınlanması.
  
- **Kullanıcı Geri Bildirimleri:** Kullanıcıların projeye ve içeriklere ilişkin geri bildirimlerini gösteren bir alan.

Bu bölümler, projenin farklı kullanıcı gruplarına yönelik özel arayüzler sunmasını sağlar ve uygulamanın işlevselliğini artırır.
Her bölüm, belirli bir kullanıcı veya rol tarafından erişilebilir ve ilgili işlevselliği sunar. Admin ve Yazar panelleri, ilgili kullanıcıların gereksinimlerine uygun olarak tasarlanmıştır. Bu bölümler, projenin yönetimi, içerik oluşturma/düzenleme ve kullanıcı etkileşimi gibi temel özelliklerini sağlar.

### Veritabanı ![image](https://github.com/omerfarukkpala/MvcProjectCamp/assets/101570820/654c10fa-e403-4c34-b208-3e99dec79287)


   
 
 
 
