# 07 - Finans ve Bildirim Akışı

## Amaç

Finans ve bildirim modüllerinin tüm rollerde ortak kullanılacağını göstermek.

## İlgili Modeller

- `FinanceTransactionViewModel`
- `WorkerInvitationViewModel`
- `NotificationItemViewModel`

## Eksik / Planlanan Parçalar

Finans ve bildirimler şu an demo ViewModel seviyesindedir. Üretim için kalıcı tablo, servis, background job ve gerçek zamanlı UI güncellemesi önerilir.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Rol aksiyonu] --> B{Finans etkisi var mı?}
    B -- Gelir --> C[Gelir kaydı]
    B -- Gider --> D[Gider kaydı]
    C --> E[FinanceTransaction]
    D --> E
    E --> F[Ödeme durumu]
    E --> G[İlgili kayıt bağlantısı]
    F --> H[Günlük özet]
    G --> H
    H --> I[Aylık özet]
    I --> J[Yıllık özet]
    J --> K[Net bakiye]
    L[Olay oluşur] --> M{Bildirim tipi}
    M --> N[İşçi daveti gönderildi]
    M --> O[İşçi kabul etti]
    M --> P[İşçi reddetti]
    M --> Q[30 dakika doldu]
    M --> R[Randevu yaklaşıyor]
    M --> S[Ödeme bekliyor]
    M --> T[Nakliye / teslimat / hasat yaklaşıyor]
    N --> U[Ortak bildirim modülü]
    O --> U
    P --> U
    Q --> U
    R --> U
    S --> U
    T --> U
```
