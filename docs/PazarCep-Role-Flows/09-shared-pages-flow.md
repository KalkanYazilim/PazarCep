# 09 - Ortak Sayfalar Akışı

Ortak sayfalar kopyalanmadan aktif role göre davranmalıdır. Mevcut kodda bu yaklaşım `OperationsCalendarViewModel`, `FinancePageViewModel`, `WorkerAssignmentViewModel`, `BusinessPanelFactory` ve `Views/Panel/*` ile temsil edilir.

## Ortak Sayfalar

- Operasyon Takvimi
- Gelir / Gider
- İşçi Yönetimi / Davet
- Randevu / Planlama
- Bildirimler
- Ödeme Takibi

## Role Göre Davranış

### Operasyon Takvimi

- Çiftçi: tarla işleri, hasat, işçi daveti, ödeme hatırlatması.
- Alıcı: ürün indirme, teslimat, stok, işçi daveti.
- Yevmiyeci: kabul edilen işler, uygunluk, kazanç.
- Lojistik: nakliye işleri, rota, araç, teslimat.
- Danışman: randevular, saha ziyaretleri, rapor takibi.

### Gelir / Gider

- Çiftçi: ürün satışı, işçilik, tohum, gübre, yakıt, sulama.
- Alıcı: ürün alımı, satış, nakliye, paketleme, fire.
- Yevmiyeci: iş kazancı, avans, yol, yemek.
- Lojistik: nakliye geliri, yakıt, bakım, sürücü ödemesi.
- Danışman: danışmanlık, saha ziyareti, eğitim, ulaşım, malzeme.

## Teknik Kural

Ortak sayfa açıldığında:

1. Aktif rol belirlenir.
2. Role özel config ve veri yüklenir.
3. Role özel tema sınıfı uygulanır.
4. Role özel aksiyonlar render edilir.
5. Yetki kontrolü uygulanır.

Diagram: `diagrams/shared-operations-flow.mmd`
