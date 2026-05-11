# 01 - Rol Genel Bakış

PazarCep rol modeli tarımsal üretim, alım, iş gücü, nakliye ve uzman danışmanlığı süreçlerini tek hesap altında yönetmeyi hedefler. Mevcut kodda rol paneli yapısı `PanelController`, `BusinessPanelViewModels`, `Views/Panel/*` ve sol menü üzerinden kuruludur.

| Role | Turkish Name | Main Purpose | Main Dashboard | Key Modules |
|------|--------------|--------------|----------------|-------------|
| Farmer / Producer | Çiftçi / Üreten | Tarla, ürün, işçi, hasat, gelir ve gider yönetimi | `/Panel/Ciftci` | Tarlalarım, Tarla İşleri, İşçi / Yevmiye, Operasyon Takvimi, Gelir / Gider |
| Buyer / Market / Greengrocer / Bazaar Seller | Alıcı / Manav / Market / Pazarcı | Ürün alımı, stok, ürün indirme, satış ve gider yönetimi | `/Panel/Alici` | Alımlar, Stok, Ürün İndirme İşleri, Operasyon Takvimi, Gelir / Gider |
| Daily Worker / Field Worker | Yevmiyeci / İşçi | İş daveti, uygunluk, kabul edilen işler, kazanç ve ödeme takibi | `/Panel/Yevmiyeci` | İş Davetleri, Takvimim, Operasyon Takvimi, Kazançlarım |
| Logistics Provider / Transporter | Lojistikçi / Nakliyeci | Araç, rota, nakliye işi, yakıt, gelir ve gider yönetimi | `/Panel/Lojistik` | Araçlarım, Nakliye İşleri, Operasyon Takvimi, Gelir / Gider |
| Agricultural Consultant / Agricultural Expert | Danışman / Ziraat Uzmanı | Randevu, saha ziyareti, rapor, öneri, gelir ve gider yönetimi | `/Panel/Danisman` | Randevular, Saha Ziyaretleri, Operasyon Takvimi, Gelir / Gider |

## Mevcut Ortak Sayfalar

- `/Panel/Operasyon?role=...` ve rol wrapper actionları: role-aware ortak operasyon ekranı.
- `/Panel/*Finans`: ortak gelir/gider ekranı.
- `/Panel/CiftciYevmiye` ve `/Panel/AliciIndirme`: işçi atama ekranı.
- `/ETicaret/Randevu/Takvim`: genel randevu takvimi.

## Mevcut Durum

Rol panelleri ve ortak operasyon sayfası görsel olarak hazırdır, ancak veri kalıcılığı demo ViewModel seviyesindedir. Auth tarafında register sırasında public rol tercihleri alınır; gerçek rol onayı ve aktif rol persist işlemi henüz tamamlanmamıştır.
