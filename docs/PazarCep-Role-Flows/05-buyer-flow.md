# 05 - Alıcı / Manav / Market / Pazarcı Akışı

## Amaç

Alıcı ürün alımlarını, teslimatları, ürün indirme işlerini, stok hareketlerini, satışları, işçilik maliyetini ve gelir/gider dengesini yönetir.

## Ana Route

- Dashboard: `/Panel/Alici`
- Operasyon: `/Panel/AliciOperasyon`

## Menü Öğeleri

- Genel Bakış
- Operasyon Takvimi
- Alımlar
- Stok
- Ürün İndirme İşleri
- Gelir / Gider

## Ana Kullanıcı Aksiyonları

- Ürün alımı oluşturma.
- Teslimat durumunu izleme.
- Ürün indirme işi açma.
- İşçi daveti gönderme.
- İşçi onayı veya süre dolmasını takip etme.
- Stok güncelleme.
- Ürün satışı ve gider kaydı oluşturma.

## Yönetilen Veri

Ürün, üretici, miktar, birim, fiyat, toplam tutar, alım tarihi, teslimat, ödeme durumu, stok miktarı, fire ve satış fiyatı.

## Ortak Sayfalar

- Operasyon Takvimi: teslimat, ürün indirme, ödeme hatırlatmaları.
- Gelir / Gider: ürün alımı, satış, nakliye, paketleme, fire.
- İşçi Atama: ürün indirme ekibi.

## Riskler

- Stok hareketleri ve ürün indirme işleri demo veridir.
- Satış/alış finans kayıtları gerçek muhasebe altyapısına bağlı değildir.

## Önerilen İyileştirmeler

- `PurchaseOrder`, `StockMovement`, `UnloadingJob` modelleri eklenmeli.
- İşçi daveti ve stok hareketi aynı transaction içinde güncellenmeli.

Diagram: `diagrams/buyer-flow.mmd`
