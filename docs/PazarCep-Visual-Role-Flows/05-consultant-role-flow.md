# 05 - Danışman / Ziraat Uzmanı Rol Akışı

## Amaç

Danışmanın randevu, saha ziyareti, gözlem, öneri, rapor ve finans akışını göstermek.

## İlgili Rotalar

- `/Panel/Danisman`
- `/Panel/DanismanOperasyon`
- `/Panel/DanismanRandevular`
- `/Panel/DanismanSaha`
- `/Panel/DanismanFinans`

## Eksik / Planlanan Parçalar

Danışman doğrulaması, rapor ekleri ve kalıcı saha raporu verisi henüz production seviyesinde değildir.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Danışman Paneli] --> B[Randevular]
    B --> C[Randevu oluştur / düzenle]
    C --> D[Çiftçi / müşteri seçimi]
    D --> E[Saha ziyareti]
    E --> F[Tarla / ürün bilgisi]
    F --> G[Gözlem kaydı]
    G --> H[Tavsiye / reçete / öneri]
    H --> I[Sonraki ziyaret tarihi]
    I --> J[Danışmanlık geliri]
    I --> K[Ulaşım / malzeme gideri]
    J --> L[Gelir / gider]
    K --> L
    L --> M[Net bakiye]
    M --> N[Bildirimler]
```
