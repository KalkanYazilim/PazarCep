# 12 - Bildirim Akışı

Mevcut projede gerçek zamanlı notification servisi bulunmamaktadır. Role-aware operasyon sayfasında bildirimler ViewModel/UI placeholder olarak gösterilir. Üretim için notification altyapısı gereklidir.

## Bildirim Türleri

- İşçi işi kabul etti.
- İşçi işi reddetti.
- İşçi 30 dakika içinde onay vermedi.
- Ödeme bekliyor.
- Randevu yaklaşıyor.
- Nakliye işi yaklaşıyor.
- Tarla işi bugün planlandı.
- Teslimat yaklaşıyor.
- Hasat tarihi yaklaşıyor.

## Önerilen Altyapı

- SignalR: anlık UI güncellemesi.
- BackgroundService: süre dolumu ve planlı kontroller.
- Hangfire veya Quartz: kalıcı zamanlanmış işler.
- E-posta/SMS/push entegrasyonu.
- Notification table: kullanıcı bazlı okundu/okunmadı durumu.

## Önerilen Model

- `Notification.Id`
- `UserId`
- `RoleType`
- `NotificationType`
- `Title`
- `Message`
- `RelatedEntityType`
- `RelatedEntityId`
- `IsRead`
- `CreatedAt`
- `ReadAt`

Diagram: `diagrams/notification-flow.mmd`
