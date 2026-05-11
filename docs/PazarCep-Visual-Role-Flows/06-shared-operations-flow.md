# 06 - Ortak Operasyon Sayfası Akışı

## Amaç

`/Panel/Operasyon?role=...` ve role özel wrapper route’ların aynı sayfayı aktif role göre nasıl değiştirdiğini göstermek.

## İlgili Sayfalar

- `Views/Panel/Operations.cshtml`
- `Models/BusinessPanelViewModels.cs` içindeki `OperationsCalendarViewModel`
- `wwwroot/css/business-panels.css` içindeki role theme sınıfları

## Davranış

Aynı ortak sayfa rol config yükler, tema uygular, role özel aksiyonları ve role özel veri setini render eder.

## Eksik / Planlanan Parçalar

Veri şu an demo factory’den gelir. Üretimde role-aware repository/service katmanı gerekir.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Kullanıcı ortak operasyon sayfasını açar] --> B[Aktif rol algılanır]
    B --> C[Rol config yüklenir]
    C --> D[Rol teması uygulanır]
    D --> E[Role özel veri yüklenir]
    E --> F[Role özel aksiyonlar gösterilir]
    F --> G[Takvim gösterilir]
    F --> H[İşçi / randevu / iş listesi gösterilir]
    F --> I[Gelir / gider özeti gösterilir]
    F --> J[Bildirimler gösterilir]
    B --> K{Rol davranışı}
    K --> L[Çiftçi: tarla işleri, hasat, işçi atamaları]
    K --> M[Alıcı: indirme işleri, stok teslimatları, işçi atamaları]
    K --> N[Yevmiyeci: kabul edilen işler, uygunluk, kazanç]
    K --> O[Lojistik: nakliye işleri, araç takvimi, teslimat hatırlatmaları]
    K --> P[Danışman: randevular, saha ziyaretleri, rapor hatırlatmaları]
```
