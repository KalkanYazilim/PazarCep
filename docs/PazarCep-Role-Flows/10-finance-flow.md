# 10 - Finans Akışı

Finans akışı tüm roller için ortak olmalıdır. Mevcut kodda `FinanceTransactionViewModel` ve `FinancePageViewModel` üzerinden demo seviyesinde temsil edilir.

## Model Önerisi

`FinanceTransaction`

- `Id`
- `UserId`
- `RoleType`
- `TransactionType`: Income / Expense
- `Category`
- `Amount`
- `TransactionDate`
- `PaymentStatus`
- `RelatedEntityType`
- `RelatedEntityId`
- `Description`
- `CreatedAt`
- `UpdatedAt`

## Akış

1. Rol bazlı işlem oluşur.
2. Kullanıcı gelir/gider kaydı girer.
3. Kategori aktif role göre belirlenir.
4. İlgili kayıt bağlantısı tutulur: tarla, iş, sipariş, araç, randevu.
5. Ödeme durumu takip edilir.
6. Günlük, aylık, yıllık özetler hesaplanır.
7. Net bakiye dashboard kartlarına yansır.

## Payment Status

- Ödendi
- Kısmi Ödendi
- Ödenmedi
- Onay Bekliyor

## Eksikler

- Kalıcı tablo ve repository/service katmanı yok.
- Rapor/export altyapısı henüz yok.

Diagram: `diagrams/finance-flow.mmd`
