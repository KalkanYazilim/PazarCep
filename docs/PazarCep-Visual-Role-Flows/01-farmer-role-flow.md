# 01 - Çiftçi / Üreten Rol Akışı

## Amaç

Çiftçinin tarla, tarla işi, yevmiyeci daveti, takvim, hasat ve finans akışını göstermek.

## İlgili Rotalar

- `/Panel/Ciftci`
- `/Panel/CiftciOperasyon`
- `/Panel/CiftciTarlalar`
- `/Panel/CiftciTarlaIsleri`
- `/Panel/CiftciYevmiye`
- `/Panel/CiftciFinans`

## Ana Kararlar

İşçi 30 dakika içinde kabul ederse takvime mini avatar/badge eklenir; onaylamazsa çiftçiye başka işçi çağırma bildirimi gider.

## Eksik / Planlanan Parçalar

Tarla, tarla işi ve işçi daveti kayıtları şu an demo ViewModel seviyesindedir.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Çiftçi Paneli] --> B[Tarlalarım]
    B --> C[Tarla ekle / düzenle]
    C --> D[Tarla detayı]
    D --> E[Tarla işi oluştur]
    E --> F{İş modeli seç}
    F --> F1[Günlük yevmiye]
    F --> F2[Saatlik çalışma]
    F --> F3[Kabala / parça başı]
    F1 --> G[Yevmiyeci çağır]
    F2 --> G
    F3 --> G
    G --> H[30 dakika onay süreci]
    H --> I{İşçi onayladı mı?}
    I -- Evet --> J[Takvimde mini avatar / badge görünür]
    I -- Hayır --> K[Çiftçiye bildirim gider]
    K --> L[Başka işçi çağırma önerisi]
    J --> M[İşçi maliyeti hesaplanır]
    M --> N[Hasat / ürün satışı]
    N --> O[Gelir / gider kaydı]
    O --> P[Net bakiye]
    P --> Q[Bildirimler]
```
