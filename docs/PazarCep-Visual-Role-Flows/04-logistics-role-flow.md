# 04 - Lojistikçi / Nakliyeci Rol Akışı

## Amaç

Araç yönetimi, nakliye işi, yükleme/teslimat takibi ve finans etkisini göstermek.

## İlgili Rotalar

- `/Panel/Lojistik`
- `/Panel/LojistikOperasyon`
- `/Panel/LojistikAraclar`
- `/Panel/LojistikNakliye`
- `/Panel/LojistikFinans`
- `/Lojistik/Filo/Index`

## Eksik / Planlanan Parçalar

Araç ve nakliye kayıtları demo ViewModel seviyesindedir. Harita/rota optimizasyonu yoktur.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Lojistik Paneli] --> B[Araçlarım]
    B --> C[Araç ekle / düzenle]
    C --> D[Nakliye işi oluştur]
    D --> E[Alış noktası]
    D --> F[Teslim noktası]
    E --> G[Araç / sürücü ata]
    F --> G
    G --> H[Yükleme takvimi]
    H --> I[Teslimat takibi]
    I --> J[Nakliye geliri]
    I --> K[Yakıt gideri]
    I --> L[Bakım gideri]
    J --> M[Gelir / gider]
    K --> M
    L --> M
    M --> N[Net bakiye]
    N --> O[Bildirimler]
```
