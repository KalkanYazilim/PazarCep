# 04 - Çiftçi / Üreten Akışı

## Amaç

Çiftçi tarlalarını, ürünlerini, işçilerini, tarla işlerini, hasat planını, gelir/giderlerini ve günlük operasyonlarını yönetir.

## Ana Route

- Dashboard: `/Panel/Ciftci`
- Operasyon: `/Panel/CiftciOperasyon`

## Menü Öğeleri

- Genel Bakış
- Operasyon Takvimi
- Tarlalarım
- Tarla İşleri
- İşçi / Yevmiye Takibi
- Gelir / Gider

## Ana Kullanıcı Aksiyonları

- Tarla ekleme/düzenleme.
- Tarla işi kaydı oluşturma.
- Yevmiyeci daveti gönderme.
- Çalışma modelini seçme: yevmiye, saatlik, kabala.
- İşçi onay durumunu izleme.
- Hasat veya ürün satış geliri kaydetme.
- Gübre, tohum, yakıt, sulama, ilaç ve işçilik gideri kaydetme.

## Yönetilen Veri

Tarla adı, konum, alan, ürün, ekim tarihi, beklenen hasat, sulama, mülkiyet, işçi sayısı, ücret, ödeme durumu ve notlar.

## Ortak Sayfalar

- Operasyon Takvimi: tarla işleri, işçi rozetleri, ödeme hatırlatmaları.
- Gelir / Gider: tarla maliyeti ve ürün geliri.
- İşçi Atama: yevmiyeci daveti.

## Bildirimler

- İşçi kabul etti/reddetti.
- Davet 30 dakikada onaylanmadı.
- Tarla işi bugün planlandı.
- Hasat tarihi yaklaşıyor.
- Ödeme bekliyor.

## Mevcut Riskler

- Tarla ve iş kayıtları demo ViewModel verisi.
- İşçi daveti kalıcı model ve background expiration altyapısına bağlı değil.
- Auth role authorization henüz uygulanmıyor.

## Önerilen İyileştirmeler

- `Field`, `FieldWorkRecord`, `WorkerInvitation`, `FinanceTransaction` tabloları eklenmeli.
- Aktif rol bazlı yetki politikaları uygulanmalı.
- İşçi onay süresi background job ile expire edilmeli.

Diagram: `diagrams/farmer-flow.mmd`
