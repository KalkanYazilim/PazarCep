# 00 - Genel Uygulama Rol Akışı

## Amaç

Tüm PazarCep rollerinin login/register, rol algılama, aktif rol seçimi, rol dashboardları ve ortak modüllerle ilişkisini tek görselde göstermek.

## Roller

Çiftçi, Alıcı, Yevmiyeci, Lojistikçi ve Danışman.

## Ana Akış

Kullanıcı PazarCep’e girer, login/register sürecinden geçer, sistem onaylı rolleri algılar. Tek rol varsa ilgili dashboard açılır; çok rol varsa role switcher ile aktif rol seçilir. Aktif rol menüyü, temayı, izinleri ve aksiyonları belirler.

## İlgili Rotalar ve Sayfalar

- `/Auth/LoginBasic`, `/Auth/RegisterBasic`
- `/Panel/Ciftci`, `/Panel/Alici`, `/Panel/Yevmiyeci`, `/Panel/Lojistik`, `/Panel/Danisman`
- `/Panel/Operasyon?role=...`
- `/Panel/*Finans`

## Eksik / Planlanan Parçalar

Kalıcı auth/role store, active role persistence, role-based authorization ve gerçek notification altyapısı henüz production seviyesinde bağlı değildir.

## Mermaid Önizleme

```mermaid
flowchart TD
    A[Kullanıcı PazarCep'e girer] --> B[Login / Register]
    B --> C[Authentication]
    C --> D{Rol algılandı mı?}
    D -- Hayır --> E[Rol başvurusu / onay bekleme]
    D -- Evet --> F{Tek rol mü?}
    F -- Evet --> G[Aktif rol otomatik seçilir]
    F -- Hayır --> H[Role switcher]
    H --> I[Aktif rol seçimi]
    G --> J[Rol bazlı menü]
    I --> J
    J --> K[Rol bazlı tema]
    K --> L[Rol bazlı izinler]
    L --> M{Dashboard}
    M --> N[Çiftçi Paneli]
    M --> O[Alıcı Paneli]
    M --> P[Yevmiyeci Paneli]
    M --> Q[Lojistik Paneli]
    M --> R[Danışman Paneli]
    N --> S[Ortak Operasyon Sayfası]
    O --> S
    P --> S
    Q --> S
    R --> S
    S --> T[Ortak Finans Modülü]
    S --> U[İşçi Daveti Sistemi]
    S --> V[Takvim Sistemi]
    S --> W[Bildirim Sistemi]
```
