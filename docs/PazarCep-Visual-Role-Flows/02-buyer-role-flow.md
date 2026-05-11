# 02 - Alıcı / Manav / Market / Pazarcı Rol Akışı

## Amaç

Alıcının ürün alımı, teslimat, ürün indirme, işçi daveti, stok ve finans akışını göstermek.

## İlgili Rotalar

- `/Panel/Alici`
- `/Panel/AliciOperasyon`
- `/Panel/AliciAlimlar`
- `/Panel/AliciStok`
- `/Panel/AliciIndirme`
- `/Panel/AliciFinans`

## Ana Kararlar

Ürün indirme işi için yevmiyeci çağrılır. İşçi onayı stok ve operasyon takvimini etkiler.

## Eksik / Planlanan Parçalar

Satın alma, teslimat ve stok hareketleri şu an demo ViewModel seviyesindedir.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Alıcı Paneli] --> B[Ürün alımı]
    B --> C[Satıcı / çiftçi seçimi]
    C --> D[Miktar / fiyat / ödeme durumu]
    D --> E[Teslimat takibi]
    E --> F[Ürün indirme işi oluştur]
    F --> G[Yevmiyeci çağır]
    G --> H[30 dakika onay süreci]
    H --> I{İşçi onayladı mı?}
    I -- Evet --> J[Takvimde mini avatar / badge görünür]
    I -- Hayır --> K[Bildirim ve alternatif işçi]
    J --> L[Stok güncelleme]
    L --> M[Satış kaydı]
    M --> N[Gelir / gider]
    N --> O[Net kâr / zarar]
```
