# 11 - İşçi Daveti Akışı

İşçi daveti çiftçi, alıcı, lojistik ve danışman operasyonlarında ortak kullanılabilecek bir akıştır. Mevcut kodda `WorkerInvitationViewModel` ve role-aware operasyon sayfasında demo olarak modellenmiştir.

## Akış

1. Davet eden kullanıcı tarih veya iş seçer.
2. Sistem uygun işçileri listeler.
3. Kullanıcı bir veya daha fazla işçi seçer.
4. İş türü, konum, ücret, çalışma modeli, başlangıç/bitiş saati, yemek/yol bilgisi ve notlar girilir.
5. Davet gönderilir.
6. İşçinin 30 dakika onay süresi başlar.
7. İşçi kabul ederse:
   - Durum `Accepted`.
   - Takvimde mini avatar/rozet gösterilir.
   - Maliyet özeti güncellenir.
8. İşçi reddederse:
   - Durum `Rejected`.
   - Başka işçi çağırılabilir.
9. Süre dolarsa:
   - Durum `Expired`.
   - Davet edene bildirim gösterilir.
   - Mesaj: “İşçi 30 dakika içinde onay vermedi. Lütfen başka bir işçi çağırın.”

## Status Listesi

- Pending
- Accepted
- Rejected
- Expired
- Cancelled
- Completed
- Paid

## Model Önerisi

`WorkerInvitation`

- `Id`
- `InviterUserId`
- `WorkerUserId`
- `InviterRoleType`
- `JobType`
- `RelatedEntityType`
- `RelatedEntityId`
- `WorkDate`
- `StartTime`
- `EndTime`
- `Location`
- `OfferedWage`
- `WorkModel`
- `FoodIncluded`
- `TransportIncluded`
- `InvitationStatus`
- `InvitationSentAt`
- `ApprovalDeadlineAt`
- `RespondedAt`
- `Notes`
- `CreatedAt`
- `UpdatedAt`

Diagram: `diagrams/worker-invitation-flow.mmd`
