# 13 - Menü ve Routing Haritası

Mevcut menü `Views/Shared/Sections/Menu/_VerticalMenu.cshtml` içinde tanımlıdır. Rol grupları şu anda görünür durumdadır; production aşamasında onaylı rollere göre filtrelenmelidir.

## Mevcut Rol Routes

| Menü | Mevcut Route |
|------|--------------|
| Çiftçi Genel Bakış | `/Panel/Ciftci` |
| Çiftçi Operasyon Takvimi | `/Panel/CiftciOperasyon` |
| Çiftçi Tarlalarım | `/Panel/CiftciTarlalar` |
| Çiftçi Tarla İşleri | `/Panel/CiftciTarlaIsleri` |
| Çiftçi İşçi / Yevmiye | `/Panel/CiftciYevmiye` |
| Çiftçi Gelir / Gider | `/Panel/CiftciFinans` |
| Alıcı Genel Bakış | `/Panel/Alici` |
| Alıcı Operasyon Takvimi | `/Panel/AliciOperasyon` |
| Alıcı Alımlar | `/Panel/AliciAlimlar` |
| Alıcı Stok | `/Panel/AliciStok` |
| Alıcı Ürün İndirme | `/Panel/AliciIndirme` |
| Alıcı Gelir / Gider | `/Panel/AliciFinans` |
| Yevmiyeci Genel Bakış | `/Panel/Yevmiyeci` |
| Yevmiyeci Operasyon Takvimi | `/Panel/YevmiyeciOperasyon` |
| Yevmiyeci İş Davetleri | `/Panel/YevmiyeciDavetler` |
| Yevmiyeci Takvimim | `/Panel/YevmiyeciTakvim` |
| Yevmiyeci Kazançlarım | `/Panel/YevmiyeciKazanc` |
| Lojistik Genel Bakış | `/Panel/Lojistik` |
| Lojistik Operasyon Takvimi | `/Panel/LojistikOperasyon` |
| Lojistik Araçlarım | `/Panel/LojistikAraclar` |
| Lojistik Nakliye İşleri | `/Panel/LojistikNakliye` |
| Lojistik Gelir / Gider | `/Panel/LojistikFinans` |
| Danışman Genel Bakış | `/Panel/Danisman` |
| Danışman Operasyon Takvimi | `/Panel/DanismanOperasyon` |
| Danışman Randevular | `/Panel/DanismanRandevular` |
| Danışman Saha Ziyaretleri | `/Panel/DanismanSaha` |
| Danışman Gelir / Gider | `/Panel/DanismanFinans` |

## Ortak Route

- `/Panel/Operasyon?role=Ciftci`
- `/Panel/Operasyon?role=Alici`
- `/Panel/Operasyon?role=Yevmiyeci`
- `/Panel/Operasyon?role=Lojistik`
- `/Panel/Operasyon?role=Danisman`

## Diğer İlgili Routes

- `/ETicaret/Randevu/Takvim`
- `/ETicaret/Urunler/Liste`
- `/ETicaret/Emir/SiparisListesi`
- `/Lojistik/Filo/Index`
- `/MusteriYonetimi/AnaSayfa/Index`
- `/Auth/LoginBasic`
- `/Auth/RegisterBasic`

## Önerilen Temiz Route Yapısı

İleride attribute routing veya endpoint mapping ile şu yapı tercih edilebilir:

- `/Panel/Ciftci/Operasyon`
- `/Panel/Alici/Operasyon`
- `/Panel/Yevmiyeci/Takvim`
- `/Panel/Lojistik/Nakliye`
- `/Panel/Danisman/Randevular`

Diagram: `diagrams/menu-routing-map.mmd`
