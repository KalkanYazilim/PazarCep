# 14 - Yetki ve Erişim Matrisi

Semboller:

- ✅ Tam erişim
- ⚠️ Sınırlı erişim
- ❌ Erişim yok

| Module | Farmer | Buyer | Worker | Logistics | Consultant | Notes |
|--------|--------|-------|--------|-----------|------------|-------|
| Dashboard | ✅ | ✅ | ✅ | ✅ | ✅ | Her rolün ayrı dashboardu vardır. |
| Operations Calendar | ✅ | ✅ | ✅ | ✅ | ✅ | Aynı ortak sayfa role göre uyarlanır. |
| Income / Expense | ✅ | ✅ | ⚠️ | ✅ | ✅ | Worker tarafında daha çok kazanç/gider takibi. |
| Worker Invitation | ✅ | ✅ | ❌ | ⚠️ | ⚠️ | Worker davet alır; davet oluşturmaz. |
| Worker Availability | ⚠️ | ⚠️ | ✅ | ⚠️ | ⚠️ | Worker kendi uygunluğunu yönetir. |
| Field Management | ✅ | ❌ | ❌ | ❌ | ⚠️ | Consultant saha raporunda tarlayı referans alabilir. |
| Product Purchase | ❌ | ✅ | ❌ | ❌ | ❌ | Alıcı modülüdür. |
| Stock Management | ❌ | ✅ | ❌ | ❌ | ❌ | Alıcı stok yönetir. |
| Vehicle Management | ❌ | ❌ | ❌ | ✅ | ❌ | Lojistik rolüne özeldir. |
| Transport Job | ⚠️ | ⚠️ | ❌ | ✅ | ❌ | Çiftçi/alıcı talep görebilir; lojistik yönetir. |
| Appointment Management | ⚠️ | ⚠️ | ❌ | ⚠️ | ✅ | Danışman tam yönetir. |
| Field Visit Report | ⚠️ | ❌ | ❌ | ❌ | ✅ | Çiftçi raporu görüntüleyebilir. |
| Earnings | ❌ | ❌ | ✅ | ❌ | ❌ | Yevmiyeci kazanç ekranı. |
| Notifications | ✅ | ✅ | ✅ | ✅ | ✅ | Role göre filtrelenir. |

## Not

Mevcut projede authorization policy seviyesinde uygulanmış rol kısıtları yoktur. Bu tablo hedef yetki modelidir.
