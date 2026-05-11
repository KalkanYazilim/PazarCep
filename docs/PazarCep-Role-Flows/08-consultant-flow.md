# 08 - Danışman / Ziraat Uzmanı Akışı

## Amaç

Danışman randevuları, saha ziyaretlerini, üretici notlarını, önerileri, raporları, danışmanlık gelirini ve giderlerini yönetir.

## Ana Route

- Dashboard: `/Panel/Danisman`
- Operasyon: `/Panel/DanismanOperasyon`

## Menü Öğeleri

- Genel Bakış
- Operasyon Takvimi
- Randevular
- Saha Ziyaretleri
- Gelir / Gider

## Ana Kullanıcı Aksiyonları

- Randevu oluşturma.
- Saha ziyareti planlama.
- Ziyaret raporu yazma.
- Gözlem, öneri, ilaç/gübre/aksiyon kaydı tutma.
- Danışmanlık geliri ve ulaşım/malzeme gideri kaydetme.

## Yönetilen Veri

Müşteri, tarla, randevu tipi, tarih/saat, konum, görüşme şekli, ücret, ödeme durumu, gözlem, öneri, sonraki ziyaret tarihi.

## Ortak Sayfalar

- Operasyon Takvimi: randevu ve saha ziyaretleri.
- Gelir / Gider: danışmanlık, saha ziyareti, eğitim geliri ve giderleri.

## Riskler

- Sertifika/diploma doğrulama ve danışman onay altyapısı yok.
- Rapor ekleri için dosya yükleme altyapısı yok.

## Öneriler

- `ConsultantAppointment`, `FieldVisitReport`, `Recommendation`, `Attachment` modelleri eklenmeli.
- Raporlar PDF/export yapısına hazırlanmalı.

Diagram: `diagrams/consultant-flow.mmd`
