# 03 - Yevmiyeci / İşçi Rol Akışı

## Amaç

İşçinin davetleri görmesi, kabul/red/süre dolumu kararları, takvim ve kazanç akışını göstermek.

## İlgili Rotalar

- `/Panel/Yevmiyeci`
- `/Panel/YevmiyeciOperasyon`
- `/Panel/YevmiyeciDavetler`
- `/Panel/YevmiyeciTakvim`
- `/Panel/YevmiyeciKazanc`

## Ana Kararlar

Davet 30 dakika içinde kabul edilirse takvime işlenir. Red veya süre dolumu davet edene bildirim üretmelidir.

## Eksik / Planlanan Parçalar

Gerçek countdown, kabul/red endpointleri ve ödeme güncelleme altyapısı henüz yoktur.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Yevmiyeci Paneli] --> B[İş davetleri]
    B --> C[Davet detayı]
    C --> D[İş türü / lokasyon / ücret]
    D --> E[Yemek / ulaşım bilgisi]
    E --> F[30 dakika onay süresi]
    F --> G{Kabul / red / süre doldu}
    G -- Kabul --> H[İş takvime işlenir]
    G -- Red --> I[Çağırana bildirim gider]
    G -- Süre doldu --> J[Davet expired olur]
    H --> K[Çalışma günü]
    K --> L[İş tamamlandı]
    L --> M[Ödeme durumu]
    M --> N[Kazançlarım]
    N --> O[Haftalık / aylık kazanç özeti]
```
