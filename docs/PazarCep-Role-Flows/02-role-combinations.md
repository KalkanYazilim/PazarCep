# 02 - Rol Kombinasyonları

Bir kullanıcı birden fazla onaylı role sahip olabilir. Dashboard geçişi `_RoleSwitcher` partial üzerinden modellenmiştir. Üretim ortamında menü görünürlüğü onaylı rollere göre filtrelenmelidir.

| Kombinasyon | Gerçekçilik | Öncelik | İş Nedeni | UX Davranışı | Menü Davranışı |
|-------------|-------------|---------|-----------|--------------|----------------|
| Çiftçi + Alıcı | Yüksek | High | Üreten kullanıcı aynı zamanda farklı ürün alımı yapabilir. | Rol switcher ile iki dashboard arasında geçiş. | Çiftçi ve Alıcı grupları görünür. |
| Çiftçi + Lojistik | Yüksek | High | Üretici kendi nakliye aracını yönetebilir. | Tarla ve nakliye planları ortak takvimde ayrışır. | Çiftçi ve Lojistik grupları görünür. |
| Çiftçi + Yevmiyeci | Orta | Medium | Küçük üretici başka tarlalarda işçi olarak çalışabilir. | Aktif rol finans kategorilerini değiştirir. | İki rol grubu görünür, davet/atama izinleri ayrılır. |
| Alıcı + Lojistik | Yüksek | High | Alıcı kendi dağıtım operasyonunu yönetebilir. | Stok teslimatı ve nakliye planı ortak takvimde bağlanır. | Alıcı ve Lojistik grupları görünür. |
| Alıcı + Yevmiyeci | Orta | Medium | Pazar esnafı bazı günlerde işçi olarak çalışabilir. | Davet kabul ekranı alıcı operasyonundan ayrılmalı. | Alıcı yönetimi ve Yevmiyeci paneli görünür. |
| Danışman + Çiftçi | Yüksek | High | Ziraat uzmanı kendi üretimini de yönetebilir. | Saha ziyaretleri ve tarla işleri ayrı rozetlerle görünür. | Danışman ve Çiftçi grupları görünür. |
| Danışman + Lojistik | Düşük | Low | Danışman küçük saha lojistiğini yönetebilir. | Lojistik modüller sınırlı kullanılabilir. | İki grup görünür, yetkiler ayrıştırılmalı. |
| Çiftçi + Alıcı + Lojistik | Yüksek | High | Üreten, alan ve taşıyan işletme modeli. | Aktif rol seçimi kritik olmalı, ortak takvim rol filtresi sunmalı. | Üç grup görünür. |
| Çiftçi + Alıcı + Yevmiyeci | Orta | Medium | Küçük bölgesel işletmelerde görülebilir. | İşçi daveti ve işçi olarak davet alma ekranları karışmamalı. | Üç grup görünür. |
| Çiftçi + Danışman | Yüksek | High | Uzman üretici modeli. | Rapor ve üretim kayıtları ayrışmalı. | İki grup görünür. |
| Alıcı + Danışman | Düşük | Low | Kurumsal satın almacı danışmanlık hizmeti de verebilir. | Finans kategorileri rol bazında kalmalı. | İki grup görünür. |
| Lojistik + Yevmiyeci | Orta | Medium | Taşıyıcı yükleme/boşaltma işlerine de katılabilir. | İş kabul ve araç yönetimi ayrılmalı. | Lojistik ve Yevmiyeci grupları görünür. |

## Kural

Kombinasyon rol eklemez; mevcut beş public rolün birlikte kullanılmasını ifade eder.
