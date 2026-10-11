# 🍽️ SignalR Restoran Yönetim Sistemi

**ASP.NET Core 8 | Katmanlı Mimari | SOLID | SignalR | REST API | Entity Framework Core | MSSQL**

SignalR Restoran Yönetim Sistemi; restoran operasyonlarını dijitalleştirmek amacıyla geliştirilen, masa bazlı sipariş yönetimi, sepet işlemleri, gerçek zamanlı iletişim, QR kod sistemleri ve yönetim panelini bir araya getiren kapsamlı bir web uygulamasıdır.

Bu proje, yalnızca SignalR teknolojisini tanıtmayı amaçlayan basit bir uygulama değildir. Katmanlı mimari, SOLID prensipleri, API entegrasyonları, veri doğrulama, kimlik yönetimi ve gerçek zamanlı haberleşme gibi farklı yazılım geliştirme konularının birlikte uygulandığı kapsamlı bir projedir.

**.NET 8** kullanılarak geliştirilen uygulamada, kullanıcı arayüzü ve yönetim paneli birbirinden ayrılarak farklı ihtiyaçlara yönelik işlevler sunulmuştur.

---

## 📸 Proje Ekran Görüntüleri

Uygulamanın kullanıcı arayüzünü, yönetim panelini ve temel özelliklerini aşağıdaki ekran görüntülerinden inceleyebilirsiniz.

> Ekran görüntülerini projenin ana dizininde oluşturacağınız `images` klasörüne ekleyebilirsiniz.

### Kullanıcı Arayüzü
<img width="1365" height="945" alt="Login-Index" src="https://github.com/user-attachments/assets/893fa730-c243-4916-a961-5ae82525cf12" />
<img width="1904" height="880" alt="Default-Index-2" src="https://github.com/user-attachments/assets/c37de643-b843-4b59-9765-4df3c5ba8e92" />
<img width="1350" height="5499" alt="Default-Index" src="https://github.com/user-attachments/assets/370c5050-9d7f-4f91-929c-07819af60962" />
<img width="1350" height="2714" alt="Menu-Index" src="https://github.com/user-attachments/assets/585749e4-5972-42e4-a033-47b4dd7bf29c" />
<img width="1350" height="1064" alt="CustomerTable-List" src="https://github.com/user-attachments/assets/6c96c159-5a0b-4594-a582-aabbd46d932d" />
<img width="1350" height="1058" alt="Basket-Index" src="https://github.com/user-attachments/assets/acd2c344-5669-4a20-bd23-cf26091dc32b" />
<img width="1350" height="1207" alt="BookATable-Index" src="https://github.com/user-attachments/assets/442e0bec-8a6f-4dd1-b756-86e9a25a06e4" />
<img width="1350" height="2208" alt="Recipe-Index" src="https://github.com/user-attachments/assets/2eb64f6b-3fc9-4bf3-8a59-6b897abb4f74" />

### Gerçek Zamanlı İletişim ve QR Kod Sistemi

<img width="1905" height="943" alt="Message-Index" src="https://github.com/user-attachments/assets/f45c9288-ea8f-4baa-8b81-5f824d8953d2" />
<img width="1350" height="955" alt="QRCodeReader" src="https://github.com/user-attachments/assets/b789fb1f-d4bd-4f8d-b816-16304b4a0567" />
<img width="1365" height="945" alt="QRRodeGenerator" src="https://github.com/user-attachments/assets/f1fcda56-f371-41ba-b6d4-85c96b66056d" />



### Yönetim Paneli
<img width="1365" height="945" alt="Statistic-Index" src="https://github.com/user-attachments/assets/3e109035-acf4-46ed-a045-59986874eb2c" />
<img width="1365" height="945" alt="ProgressBars-Index" src="https://github.com/user-attachments/assets/c805d6a9-d9be-4d62-b21e-5e9ad8eea4e4" />
<img width="1365" height="945" alt="Notification-Index" src="https://github.com/user-attachments/assets/f0f46b57-8521-4c79-9b21-3d8a7abe8b2a" />
<img width="1350" height="1162" alt="Product-Index" src="https://github.com/user-attachments/assets/816d68fb-f315-460c-b585-e5870d723fad" />
<img width="1365" height="945" alt="About-Index" src="https://github.com/user-attachments/assets/53022e16-0072-484e-9226-e85d2de75b9b" />
<img width="1350" height="1098" alt="Booking-Index" src="https://github.com/user-attachments/assets/e5141f27-e53f-4372-9589-d1af86f0abf4" />
<img width="1365" height="945" alt="Category-Index" src="https://github.com/user-attachments/assets/400551ee-303b-4c4d-8ae9-a37687c5eb85" />
<img width="1365" height="945" alt="Contact-Index" src="https://github.com/user-attachments/assets/799bc542-89ec-4eba-99d1-784191b65d6f" />
<img width="1365" height="945" alt="Discount-Index" src="https://github.com/user-attachments/assets/41c44abe-3bad-4fae-93fb-63cac364d513" />
<img width="1365" height="945" alt="Mail-Index" src="https://github.com/user-attachments/assets/331cd755-08b8-4cb8-9eaa-02247b497315" />
<img width="1350" height="1674" alt="MenuTable-Index" src="https://github.com/user-attachments/assets/d08c474a-6378-40d9-be14-b594c7b75662" />
<img width="1350" height="1032" alt="Setting-Index" src="https://github.com/user-attachments/assets/a856e1e2-31fb-4aa0-a027-d0dcb43ea52a" />
<img width="1365" height="945" alt="Slider-Index" src="https://github.com/user-attachments/assets/f1f73610-96ac-4f51-822f-44a9a99a9381" />
<img width="1365" height="945" alt="SocialMedia-Index" src="https://github.com/user-attachments/assets/ba42cea3-ebd6-45c9-a4a8-6591a0801b77" />

---

## 🚀 Proje Özellikleri

### 🏗️ Yazılım Mimarisi

- **Katmanlı Mimari:** Uygulama sorumlulukları farklı katmanlara ayrılarak kodun sürdürülebilirliği ve sorumlulukların ayrıştırılması hedeflenmiştir.
- **SOLID Prensipleri:** Bakımı kolay ve genişletilebilir bir yapı oluşturmak amacıyla SOLID prensipleri dikkate alınmıştır.
- **Sorumlulukların Ayrıştırılması:** Kullanıcı tarafındaki işlevler ile yönetim işlemleri birbirinden ayrılmıştır.
- **DTO Kullanımı:** Uygulama bileşenleri ve API uç noktaları arasında veri aktarımı için DTO sınıfları kullanılmıştır.
- **AutoMapper:** Nesneler arasındaki veri dönüşümlerini kolaylaştırmak amacıyla kullanılmıştır.
- **Dependency Injection:** Bağımlılıklar, ASP.NET Core'un yerleşik bağımlılık enjeksiyonu altyapısıyla yönetilmiştir.

### ⚡ SignalR ile Gerçek Zamanlı İletişim

- Gerçek zamanlı mesajlaşma işlevi.
- Bağlı istemciler arasında anlık iletişim.
- Desteklenen uygulama işlemleri için gerçek zamanlı güncellemeler.
- SignalR teknolojisinin restoran yönetimi süreçlerine entegrasyonu.

### 🍽️ Restoran ve Sipariş Yönetimi

- Masa bazlı sipariş oluşturma.
- Sepet içeriğini görüntüleme ve yönetme.
- Sepete ürün ekleme ve sepetten ürün silme.
- Menü ve ürün listeleme.
- Rezervasyon işlemleri.
- Restoran bilgileri ve iletişim detayları.

### 📱 QR Kod Sistemi

- Kullanıcı tarafından girilen içerik üzerinden QR kod oluşturma.
- Yüklenen görsellerdeki QR kodları okuma ve çözümleme.
- QR kod işlemlerinin uygulamaya entegre edilmesi.

### 🔌 REST API Entegrasyonu

- MVC uygulaması ile API uç noktaları arasında iletişim.
- Veri listeleme, oluşturma, güncelleme ve silme işlemleri için HTTP istekleri.
- JSON serileştirme ve serileştirmeyi geri çözme işlemleri.
- Kullanıcı arayüzünün API tabanlı veri işlemlerinden ayrılması.

### ✅ Veri Doğrulama

- FluentValidation entegrasyonu.
- Doğrulama kurallarının ayrı validator sınıflarında tanımlanması.
- Alan bazlı doğrulama mesajları.
- İlgili işlemler gerçekleştirilmeden önce kullanıcı verilerinin doğrulanması.

### 🔐 Kimlik Yönetimi ve Güvenlik

- ASP.NET Core Identity entegrasyonu.
- Kimlik doğrulama ve yetkilendirme altyapısı.
- Kullanıcı ve yönetici erişimlerinin ayrıştırılması.

### 📧 E-posta Entegrasyonu

- E-posta gönderme işlevi.
- E-posta işlemlerinin uygulamanın ilgili süreçlerine entegre edilmesi.

### 🗄️ Veritabanı Yönetimi

- Microsoft SQL Server (MSSQL).
- Entity Framework Core.
- İlişkisel veritabanı tasarımı ve tablolar arası ilişkiler.
- Belirli veri işlemleri için veritabanı tetikleyicileri (Triggers).
- Veritabanı odaklı uygulama işlevleri.

### 🖥️ Yönetim Paneli

- Yöneticilere özel arayüz.
- Desteklenen uygulama varlıkları için yönetim ekranları.
- Yönetim işlemlerine merkezi erişim.
- Kullanıcı arayüzü ile yönetim panelinin ayrılması.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| C# | Ana programlama dili |
| .NET 8 | Uygulama geliştirme platformu |
| ASP.NET Core MVC | Web uygulaması ve kullanıcı arayüzü |
| ASP.NET Core Web API | API uç noktaları ve veri işlemleri |
| SignalR | Gerçek zamanlı iletişim |
| Entity Framework Core | ORM ve veritabanı işlemleri |
| Microsoft SQL Server | İlişkisel veritabanı |
| AutoMapper | Nesne eşleme ve veri dönüşümü |
| FluentValidation | Veri doğrulama |
| ASP.NET Core Identity | Kullanıcı kimlik yönetimi |
| REST API | Uygulama bileşenleri arasında iletişim |
| JSON | Veri alışverişi |
| HTML, CSS, JavaScript | Kullanıcı arayüzü geliştirme |

---

## 🏛️ Mimari Yaklaşım ve Tasarım Prensipleri

Bu projenin temel hedeflerinden biri, yalnızca özellik geliştirmek yerine yazılım geliştirme prensiplerini uygulama içerisinde birlikte kullanmaktır.

Geliştirme sürecinde aşağıdaki konulara odaklanılmıştır:

- Uygulama sorumluluklarının katmanlar arasında ayrıştırılması.
- SOLID prensiplerinin uygun noktalarda uygulanması.
- Doğrulama kurallarının uygulama mantığından ayrılması.
- Veri aktarımında DTO sınıflarının kullanılması.
- Tekrarlayan nesne eşleme işlemlerinin AutoMapper ile azaltılması.
- Bağımlılıkların Dependency Injection ile yönetilmesi.
- MVC sunum katmanının API tabanlı veri işlemlerinden ayrılması.
- İlişkisel veritabanı yapılarının ve ihtiyaç duyulan tetikleyicilerin kullanılması.

Bu yaklaşım ile kod okunabilirliğinin, bakım kolaylığının ve yeni özelliklerin eklenebilirliğinin artırılması hedeflenmiştir.

---

## ⚙️ Kurulum ve Çalıştırma

### Gereksinimler

Projeyi çalıştırmadan önce aşağıdaki araçların kurulu olduğundan emin olun:

- .NET 8 SDK
- Microsoft SQL Server
- Visual Studio 2022 veya uyumlu başka bir .NET geliştirme ortamı

### Kurulum Adımları

**1. Repoyu klonlayın**

```bash
git clone YOUR_GITHUB_REPOSITORY_URL
```

**2. Solution dosyasını açın**

Visual Studio üzerinden `.sln` uzantılı solution dosyasını açın.

**3. Veritabanı bağlantısını yapılandırın**

Veritabanı bağlantı ayarlarını kendi yerel ortamınıza göre düzenleyin. Parolaları, API anahtarlarını veya diğer hassas bilgileri GitHub'a yüklemeyin.

**4. Veritabanı migration işlemlerini uygulayın**

Projede Entity Framework Core migration'ları kullanılıyorsa gerekli migration'ları veritabanınıza uygulayın.

```powershell
Update-Database
```

Bu komutu, doğru proje ve yapılandırma seçiliyken Visual Studio Package Manager Console üzerinden çalıştırın.

**5. Uygulama ayarlarını yapılandırın**

API adreslerini, veritabanı bağlantı bilgilerini ve ortama bağlı diğer yapılandırmaları kontrol edin.

**6. Uygulamayı çalıştırın**

Visual Studio üzerinden gerekli başlangıç projelerini seçerek uygulamayı çalıştırın.

> Solution yapısına bağlı olarak başlangıç projeleri ve veritabanı kurulum adımları değişiklik gösterebilir.

---

## 🔒 Yapılandırma ve Güvenlik

Gizli yapılandırma bilgileri repodan çıkarılmıştır.

Uygulamayı çalıştırmadan önce aşağıdaki ayarları kendi ortamınıza göre yapılandırın:

- Veritabanı bağlantı cümleleri.
- API adresleri.
- Gerekliyse e-posta sunucusu ayarları ve kimlik bilgileri.
- Ortama özel diğer yapılandırma değerleri.

Üretim ortamına ait parolaları, API anahtarlarını veya özel erişim bilgilerini herkese açık bir repoda paylaşmayın.

---

## 🎯 Projenin Kazandırdıkları ve Amaçları

Bu proje, modern .NET geliştirme süreçlerinin farklı bileşenlerini bir arada uygulama fırsatı sunmuştur.

Proje kapsamında odaklanılan başlıca konular:

- .NET 8 ile ASP.NET Core MVC uygulaması geliştirme.
- Katmanlı mimari ve SOLID prensiplerini uygulama.
- REST API geliştirme ve tüketme.
- SignalR ile gerçek zamanlı iletişim kurma.
- ASP.NET Core Identity ile kullanıcı ve kimlik yönetimi.
- FluentValidation ile veri doğrulama.
- AutoMapper ve DTO kullanımı.
- Entity Framework Core, SQL Server ve veritabanı tetikleyicileriyle çalışma.
- Masa bazlı sipariş, sepet yönetimi ve QR kod işlemleri geliştirme.
- E-posta işlevlerini uygulama süreçlerine entegre etme.

Temel amaç, her teknolojiyi birbirinden bağımsız örnekler olarak ele almak yerine daha kapsamlı bir uygulama içerisinde nasıl birlikte çalıştıklarını anlamaktır.

---

## 👨‍💻 Geliştirici Hakkında

Bu proje; modern .NET web uygulamaları geliştirme, yazılım mimarisi, API entegrasyonları, veritabanı yönetimi ve gerçek zamanlı iletişim konularında pratik deneyim kazanmak amacıyla geliştirilmiştir.

YAVUZ BAHADIR SEVİM - .NET DEVELOPER
---
