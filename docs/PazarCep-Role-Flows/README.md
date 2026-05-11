# PazarCep Rol Akışları Dokümantasyonu

Son güncelleme: 2026.05.11

Bu klasör PazarCep içindeki rol akışlarını, rol değiştirme davranışını, ortak sayfaları, finans akışını, işçi daveti sürecini, bildirim yaklaşımını, menü/route haritasını ve önerilen geliştirmeleri dokümante eder.

## Roller

- Çiftçi / Üreten
- Alıcı / Manav / Market / Pazarcı
- Yevmiyeci / İşçi
- Lojistikçi / Nakliyeci
- Danışman / Ziraat Uzmanı

Aracı, komisyoncu, broker veya middleman benzeri roller bu dokümantasyona dahil edilmez.

## Nasıl Okunur

1. `01-role-overview.md` ile rol modelini okuyun.
2. `03-role-login-and-switching-flow.md` ile giriş ve aktif rol seçimi davranışını inceleyin.
3. İlgili rol dosyasından rol bazlı iş akışını takip edin.
4. Ortak sayfalar için `09-shared-pages-flow.md`, finans için `10-finance-flow.md`, işçi daveti için `11-worker-invitation-flow.md` dosyalarını kullanın.
5. Uygulama planlaması için `13-menu-and-routing-map.md`, `14-permission-and-access-matrix.md` ve `15-recommended-improvements.md` dosyalarına bakın.

## Diyagramlar

Mermaid diyagramları `diagrams/` klasöründedir:

- `role-overview.mmd`
- `login-role-switch-flow.mmd`
- `farmer-flow.mmd`
- `buyer-flow.mmd`
- `worker-flow.mmd`
- `logistics-flow.mmd`
- `consultant-flow.mmd`
- `shared-operations-flow.mmd`
- `finance-flow.mmd`
- `worker-invitation-flow.mmd`
- `notification-flow.mmd`
- `menu-routing-map.mmd`

## Mermaid Notu

GitHub, Mermaid destekleyen editörler ve Mermaid Live Editor ile `.mmd` dosyaları önizlenebilir. Diyagramlardaki metinler Türkçedir.

## Mimari İlkeler

- Tek kullanıcı birden fazla onaylı role sahip olabilir.
- Aktif rol dashboard, menü, ortak sayfa teması ve aksiyonlarını belirler.
- Ortak sayfalar kopyalanmadan role göre uyarlanmalıdır.
- Finans, takvim, işçi daveti, ödeme ve bildirim altyapıları ortak modellerle genişletilmelidir.
- Mevcut kodda rol paneli akışı demo/ViewModel tabanlıdır; üretim için veri tabanı, yetkilendirme ve bildirim altyapısı gereklidir.
