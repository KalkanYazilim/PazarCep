# 15 - Önerilen İyileştirmeler

## A) Critical

| Problem | Suggested Solution | Affected Areas | Priority | Implementation Note |
|---------|--------------------|----------------|----------|---------------------|
| Rol yetkilendirme kalıcı değil. | ASP.NET Identity veya mevcut user altyapısına `UserRole` ve active role eklenmeli. | Auth, PanelController, Menu | Critical | Public/internal roller ayrılmalı; internal roller public sayfalarda görünmemeli. |
| Menü tüm rol gruplarını gösteriyor. | Menü onaylı rollere göre filtrelenmeli. | `_VerticalMenu.cshtml` | Critical | Mevcut TODO üretim öncesi kapatılmalı. |
| İşçi davetleri kalıcı değil. | `WorkerInvitation` tablosu, service ve endpointleri eklenmeli. | BusinessPanelViewModels, Operations | Critical | 30 dakika süre server tarafında kontrol edilmeli. |

## B) High Priority

| Problem | Suggested Solution | Affected Areas | Priority | Implementation Note |
|---------|--------------------|----------------|----------|---------------------|
| Finans verileri demo ViewModel. | `FinanceTransaction` tablosu ve ortak finance service eklenmeli. | Finance, Operations | High | RoleType ve RelatedEntity alanları zorunlu olmalı. |
| Operasyon sayfası server-side demo veriye bağlı. | Role config + repository tabanlı veri yükleme yapılmalı. | `BusinessPanelFactory` | High | Factory demo data provider olarak ayrılabilir. |
| Register rol tercihleri kalıcı değil. | Role preference ve approval status saklanmalı. | Auth | High | Buyer otomatik, diğerleri pending olabilir. |

## C) Medium Priority

| Problem | Suggested Solution | Affected Areas | Priority | Implementation Note |
|---------|--------------------|----------------|----------|---------------------|
| Route yapısı action isimleriyle çalışıyor. | Temiz role-based route wrapper eklenmeli. | PanelController | Medium | `/Panel/Ciftci/Operasyon` gibi route kullanılabilir. |
| Randevu ve operasyon takvimi ayrı veri kaynakları kullanıyor. | Ortak calendar event modeli oluşturulmalı. | ETicaret/Randevu, Panel/Operations | Medium | Event type ve status enumları ortaklaşmalı. |
| Drag-and-drop sadece UI seviyesinde. | Progressive enhancement korunarak endpoint ile kayıt yapılmalı. | `worker-assignment.js` | Medium | JS kapalıyken select/multiple form çalışmalı. |

## D) Future

- SignalR ile gerçek zamanlı işçi onayı.
- BackgroundService, Hangfire veya Quartz ile davet süresi dolumu.
- SMS, e-posta ve push notification.
- Harita ve rota entegrasyonu.
- Takvim dışa aktarımı ve takvim senkronizasyonu.
- Gelişmiş finans raporları, karlılık analizleri, export.
- Multi-tenant işletme hesapları.
- Mobil uygulama destekli aktif rol geçişi.
- Danışman belge/diploma doğrulama süreci.
