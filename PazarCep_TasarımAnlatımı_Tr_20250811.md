Genel Proje Temelleri (Tüm Sayfalara Uygula)
Proje Adı: PazarCep

Platform: Web uygulaması (öncelikli mobil uyumlu), masaüstü/tablet/mobil kırılımlarını destekler.

Breakpoints: Mobil 360–480px, Tablet 768–1024px, Masaüstü 1280–1440px

Tasarım Tokenları: Renk, boşluk, tipografi, köşe yuvarlama, gölge ölçeği – JSON formatında token dosyası hazırlanmalı



Erişilebilirlik: WCAG AA minimum. Klavye navigasyonu, focus outline, ARIA label, renk kontrast kontrolü (oran raporları ile).

Bileşen Kütüphanesi:
Butonlar (ana/ikincil/üçüncül/ikon), input’lar, select, çok adımlı formlar, modal şablonları, toast’lar, kartlar, liste öğeleri, avatar, chip, filtre, tablo, sayfalama, harita bileşeni, zaman çizelgesi, dosya yükleyici (önizleme ile), puanlama yıldızları, teklif/bid bileşeni, takvim seçici, tarih/saat aralığı, rota çizgili harita.

Mikro metin tonu: Açık, destekleyici, profesyonel.

İsimlendirme: module__sayfaadı__breakpoint (ör: marketplace__product-detail__desktop)

Teslim Formatları: Figma, PNG/JPG önizlemeler, token JSON, tıklanabilir prototip linki, her modül için tek sayfa PDF özet.

Sayfa Hazırlama Şablonu
Her sayfa için aşağıdaki tam format kullanılacak:

Sayfa Başlığı (TR / EN)

Benzersiz slug (önerilen URL)

Sayfa amacı (1 cümle)

Erişebilecek roller (liste)

Wireframe üretilecek cihazlar (masaüstü/tablet/mobil)

Sayfadaki bileşenler (props detaylı)

Veri alanları / API kontratı:

GET/POST endpoint örneği

İstek gövdesi örneği

Yanıt şeması örneği

Gerekli durumlar:

Varsayılan yüklenmiş

Boş durum (tasarım + mikro metin)

Yükleme iskeleti

Hata durumu (mesajlar dahil)

Başarılı durum

Etkileşimler & mikro etkileşimler:

Hover/tap/focus davranışları

Animasyonlar (süreleriyle)

Modal/onay pencereleri (içerik + butonlar)

Doğrulama metinleri (TR + EN)

Erişilebilirlik notları

Duyarlı tasarım detayları (kırılımlarda değişimler, gizlenen/kapanan öğeler)

Örnek test verisi (3 gerçekçi örnek)

Analitik event’ler (eventName + payload)

Güvenlik/izin kuralları

Köşe durumlar (2–3 edge case + davranış)

Dışa aktarılacak dosyalar (ikon, svg, görsel boyutları)

QA kontrol listesi (10 madde)

Prototip bağlantıları (hangi sayfadan hangisine hangi CTA ile geçiş)

Tam Liste – 128 Sayfa (Ne eksik ne fazla)
A. Pazarlama / Genel / Hukuki (13)
Anasayfa — /

Hakkında — /about

Fiyatlandırma & PazarPara Paketleri — /pricing

Nasıl Çalışır — /how-it-works

Yorumlar & Başarı Hikayeleri — /testimonials

Blog Liste — /blog

Blog Yazısı — /blog/:slug

İletişim — /contact

Yardım Merkezi — /help

SSS — /faq

Kullanım Şartları — /legal/terms

Gizlilik Politikası — /legal/privacy

Çerez Politikası & Onay — /legal/cookies

B. Kimlik Doğrulama & Rol Tanımlama (12)
(...tam liste tek tek devam eder — tüm roller ve kimlik doğrulama sayfaları dahil)

C. Paneller (6)
(...her rol için ayrı dashboard)

D. Pazaryeri — Ürünler (15)
(...kategori listesi, arama, ürün detayı, sepet, ödeme, iade, anlaşmazlık)

E. Taşıma & İşler (12)
(...iş ilanları, teklif verme, teslimat takibi, teslim kanıtı, geçmiş işler)

F. Topluluk & Sosyal (10)
(...topluluk akışı, forum, DM, bildirim merkezi)

G. PazarPara & Haklar (13)
(...cüzdan, paket alım, ödeme, komisyon görünümü, hak yönetimi, fatura)

H. Profiller & Ayarlar (11)
(...profil düzenleme, işletme profili, KYC, güvenlik, dil ayarı, API anahtarları)

I. Yönetici & Moderasyon (19)
(...admin paneli, kullanıcı yönetimi, paket yönetimi, moderasyon kuyrukları, raporlar, destek)

J. Destek & Ekstra (7)
(...destek talebi, canlı sohbet, erişilebilirlik bildirimi, entegrasyon kılavuzu, API dokümanı, sandbox, sürüm notları)

K. Hata, Şablon & Bileşen Sayfaları (10)
(...404, 500, bakım modu, boş durum şablonları, bileşen kütüphanesi, modal, toast, onboarding tur, erişilebilirlik modu)

Kesin Kurallar
Sadece yukarıdaki 128 sayfa hazırlanacak. Ne eksik ne fazla.

Her sayfa tam şablon ile hazırlanacak.

Birincil dil Türkçe, yanında İngilizce çeviri sütunu.

Masaüstü, tablet ve mobil varyantlar her sayfa için zorunlu.

API örnekleri her form ve veri etkileşiminde verilecek.

Her liste/detay sayfası için 3 gerçekçi örnek veri olacak.

Tüm kullanıcı aksiyonları için analitik event tanımı yapılacak.

Son teslimatta tek sayfalık PDF indeks (tüm sayfa listesi + slug + rol erişimi) olacak.

Belirsiz karar noktalarında iki seçenek (A/B) sunulacak, UXpilot kendi seçmeyecek.