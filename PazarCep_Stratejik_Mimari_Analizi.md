# PazarCep Stratejik Ürün ve Sistem Tasarımı (Kurumsal Analiz)

## 1) Executive Summary

PazarCep, **yalnızca bir e-ticaret platformu değil**, tarım tedarik zincirini (üretici → lojistik → son satıcı) dijitalleştiren, kurallı, puan/itibar odaklı, coğrafya ve zaman duyarlı, **hibrit bir B2B marketplace + lojistik orkestrasyon + güven platformu** olarak konumlanmalıdır. Platformun başarısı üç eksene bağlıdır:

1. **Ticari Akış Güvenilirliği:** Ürün kalitesi, zamanında teslimat, söz verilen kapasite.
2. **Operasyonel Orkestrasyon:** Randevu, takvim, taşıma planı, yük birleştirme, ürün ömrü.
3. **İtibar ve Kural Motoru:** Otomatik puan, kota/limit, kısıtlama, rozet, doğrulama.

Kısa vadede hedef; “çiftçi ürün listeleyebilsin, son satıcı güvenli sipariş verebilsin, taşımacı taşıma alabilsin, tüm taraflar takvim/randevu ile koordine olabilsin” çekirdeğini üretime hazır kalitede ayağa kaldırmaktır. Orta vadede sözleşmeli randevu, açık artırma ödül sistemi ve gelişmiş coğrafi öneriler; uzun vadede veri güdümlü fiyatlama, risk skoru ve tedarik optimizasyonu devreye alınmalıdır.

---

## 2) Domain Analysis

### 2.1 Ana Domainler (Bounded Context)

1. **Identity & Access Domain**
   - Üyelik, rol, yetki, KYC/verification, profile completion.
2. **Trading Domain (B2B Commerce)**
   - Ürün, ilan, sipariş, teklif/pazarlık, açık artırma.
3. **Logistics Domain**
   - Araç, yük talebi/teklifi, shipment, rota, parçalı taşıma, yük birleştirme.
4. **Scheduling Domain**
   - Randevu, takvim uygunlukları, slot yönetimi, iptal/erteleme.
5. **Trust & Reputation Domain**
   - Puan event’leri, ürün bazlı ve genel skor, rozetler, yorumlar.
6. **Compliance & Quality Domain**
   - Son ilaçlama, ürün raporu, yeşil rozet, moderasyon, içerik güvenliği.
7. **CRM & Engagement Domain**
   - Müşteri ilişkisi, bildirimler, mesajlar, tekrar satın alma kolaylaştırma.
8. **Geo-Matching Domain**
   - Mesafe, bölge kuralı, rota uyumluluğu, öneri motoru.
9. **Workforce Domain**
   - İşçi bulma, iş ilanı, aday ilgisi, sezonluk iş akışı.

### 2.2 Kritik Domain Bağımlılıkları

- Trading → Logistics: Siparişin sevkiyata dönüşmesi.
- Trading → Scheduling: Hasat, yükleme, teslim slotları.
- Trading/Logistics → Reputation: Tamamlanan işlemden puan event üretimi.
- Compliance → Trading: Son ilaçlama + 15 gün kuralı, satışa açılma kısıtı.
- Geo-Matching → Trading/Logistics: Öneri sıralaması, kota dinamikleri.

### 2.3 Domain Event Örnekleri

- `OrderPlaced`, `AppointmentAccepted`, `ShipmentDelivered`, `ReviewSubmitted`, `ReportVerified`, `MedicationRestrictionLifted`, `ScoreUpdated`, `QuotaAdjusted`.

---

## 3) Product Vision Breakdown

### 3.1 Platform Tipi

- **Hibrit yapı:**
  - **B2B marketplace:** çiftçi ↔ son satıcı ticareti.
  - **Lojistik koordinasyon:** taşımacı eşleşmesi, planlama, partili sevkiyat.
  - **Güven platformu:** puan, rozet, doğrulama, moderasyon.

### 3.2 Kısa Vade (0–6 ay) Çekirdek Senaryolar

1. Rol bazlı üyelik + profil tamamlama.
2. Çiftçi ürün ilanı açma (hasat/ilaçlama bilgisi dahil).
3. Son satıcı sipariş + teklif/pazarlık.
4. Randevu talebi ve takvim senkronu.
5. Taşımacı araç kaydı ve taşıma ataması.
6. Temel puanlama + yorum + kota başlangıç modeli.
7. Moderasyon (medya, belge, yorum).

### 3.3 Orta Vade (6–12 ay)

- Sözleşmeli randevu.
- Yük birleştirme ve parçalı taşıma optimizasyonu.
- Ürün bazlı puan + genel puan hibrit modeli.
- Coğrafi öneri motoru (kâr/zayi optimizasyonu).
- Yeşil rozet doğrulama pipeline’ı.
- Ödül bağlı açık artırma erişimi.

### 3.4 Uzun Vade (12+ ay)

- Tahmini hasat-zaman-fiyat motoru.
- Dinamik sigorta/riske dayalı işlem limitleri.
- Bölgesel tedarik ağları ve franchise benzeri iş ortaklıkları.
- API marketplace (3rd-party lojistik/finans entegrasyonları).

### 3.5 İşlem Yapan vs Gözlemci Roller

- **İşlem yapan:** Çiftçi, Son Satıcı, Taşımacı, Yük Veren, Yük Alan, Admin.
- **Gözlemci:** Tüketici (yalnızca gezinme, satın alma yok).

---

## 4) Role & Permission Matrix

> Not: Yetkiler policy-based (claim + role + resource ownership) çalışmalıdır.

### 4.1 Admin
- Görebilir: Tüm modüller, denetim kayıtları.
- Oluşturabilir: Kural politikaları, moderasyon kararları, kategori/veri sözlüğü.
- Düzenleyebilir: Konfigürasyon, onay iş akışları.
- Satın al/sat: Hayır (operasyonel rol).
- Onay: Belge doğrulama, ürün model talepleri, moderasyon kararları.
- Planlama: Sistem genel kampanya/politika pencereleri.
- Puan/Kota: **Puanı doğrudan değiştiremez**, sadece kural setini yönetir.
- Raporlar: Tam erişim.
- Takvim: Uyuşmazlık çözümü için görüntüleme.
- Medya/Belge: İnceleme/engelleme/silme.

### 4.2 Çiftçi
- Görebilir: Kendi panosu, ürün talepleri, satıcı profilleri, taşıyıcı önerileri.
- Oluşturabilir: Ürün ilanı, hasat/ilaçlama kaydı, randevu talebi, medya paylaşımı.
- Düzenleyebilir: Profil, tarla/adres, ilan taslağı.
- Satın al/sat: Satış odaklı (ürün satışı).
- Onay: Kendisine gelen randevu/satış tekliflerini.
- Planlama: Hasat, yükleme, teslim slotu.
- Puan/Kota: Ürün bazlı + genel puana bağlı satış kotası.
- Raporlar: Kendi ürün raporları ve alıcıya açtıkları.
- Takvim: Kendi + paylaşıma açtığı karşı taraf takvimi.
- Medya/Belge: Tarla görsel/video, ürün kalite raporu.

### 4.3 Taşımacı
- Görebilir: Yük ilanları, rota eşleşmeleri, taşıma fırsatları.
- Oluşturabilir: Araç/profil, taşıma teklifi, uygunluk takvimi.
- Düzenleyebilir: Araç kapasite, sertifika, güzergâh tercihleri.
- Satın al/sat: Taşıma hizmeti satar.
- Onay: Taşıma ataması, sevkiyat adımları.
- Planlama: Multi-leg route, slot ve partili taşıma.
- Puan/Kota: Teslim doğruluğu/zamanında teslim üzerinden taşıma limiti.
- Raporlar: Sevkiyat performans raporu.
- Takvim: Kendi + atandığı sevkiyat takvimi.
- Medya/Belge: Araç belgeleri, teslim kanıtı.

### 4.4 Son Satıcı
- Görebilir: Ürün katalogları, çiftçi profilleri, kalite raporları, yeşil rozet.
- Oluşturabilir: Sipariş, teklif/pazarlık, randevu talebi.
- Düzenleyebilir: Tedarik kapasite bilgisi (gün/hafta/ay).
- Satın al/sat: Satın alır (platformdaki ana alıcı).
- Onay: Sipariş, teslim ve kalite kabul.
- Planlama: Teslim alma slotları.
- Puan/Kota: Alım limiti güven ve geçmişe bağlı.
- Raporlar: Satın aldığı ürünlerin raporları.
- Takvim: Kendi + ilişkilendiği çiftçi/taşıyıcı takvimi (izinli).
- Medya/Belge: Kalite geri bildirimleri.

### 4.5 Yük Veren
- Görebilir: Yük talepleri, taşımacı teklifleri, sevkiyat durumları.
- Oluşturabilir: Load request.
- Düzenleyebilir: Yükleme noktası/zamanı.
- Satın al/sat: Taşıma hizmeti satın alır.
- Onay: Taşıyıcı seçimi.
- Planlama: Yükleme planı.
- Puan/Kota: Taşıma güven skoruna bağlı erişim.

### 4.6 Yük Alan
- Görebilir: Atanan yükler, teslim evrakı.
- Oluşturabilir: Teslim teyidi.
- Düzenleyebilir: Teslim notu.
- Satın al/sat: Yok.
- Onay: Teslim alma onayı.
- Planlama: Teslim slotu.
- Puan/Kota: Teslim doğrulama kalitesi üzerinden.

### 4.7 Tüketici
- Görebilir: Katalog, hikaye/içerik, doğrulanmış ürünler.
- Oluşturabilir: Hesap (opsiyonel), favori listesi.
- Düzenleyebilir: Kendi temel profil.
- Satın al/sat: **Yok**.
- Onay/Planlama/Kota: Yok.

---

## 5) Module Architecture

Aşağıda her modül için amaç, girdi/çıktı, bağımlılık, ekran, entity, kural özeti verilmiştir.

### 5.1 Kimlik / Hesap / Profil
- Amaç: Rol bazlı üyelik, güvenli erişim, profil olgunluğu.
- Girdi: Kayıt bilgisi, kimlik/belge.
- Çıktı: Doğrulanmış hesap, profile completion skoru.
- Bağımlı: Puan, Kota, Moderasyon.
- Ekran: Kayıt, giriş, profil yönetimi, yetki ekranı.
- Entity: User, Role, UserProfile, VerificationRequest.
- Kural: Profil tamamlandıkça küçük ama kontrollü puan artışı.

### 5.2 Ürün Yönetimi
- Amaç: Ürün, varyant, hasat/ilaçlama bilgisiyle satışa hazırlık.
- Girdi: Product, HarvestInfo, LastMedicationRecord.
- Çıktı: ProductListing.
- Bağımlı: Restriction, Report, Reputation.
- Ekran: Ürün ekle/düzenle, ürün detay.
- Entity: Product, ProductVariant, ProductCategory, ProductListing.
- Kural: Son ilaçlama + 15 gün kuralı otomatik kontrol.

### 5.3 Ürün Model Yönetimi & Ürün Ekleme Talebi
- Amaç: Yeni ürün/model taleplerini yönetişimle eklemek.
- Entity: ProductAddRequest, ModerationCase.
- Kural: Admin onayı + sınıflandırma doğruluğu.

### 5.4 E-Ticaret / Sipariş
- Amaç: Teklif, sipariş, onay, teslim.
- Entity: Order, OrderItem, PaymentIntent (ileride), DeliveryPreference.
- Kural: Kota/limit uygunluğu olmadan kesin sipariş alınmaz.

### 5.5 Teklif / Pazarlık / Açık Artırma
- Amaç: Fiyat keşfi ve ödül bazlı açık artırma.
- Entity: Offer, CounterOffer, Auction, AuctionBid.
- Kural: Açık artırma yetkisi bir “ödül/itibar erişimi” olarak açılır.

### 5.6 Randevu
- Amaç: Çiftçi-satıcı buluşma/teslim hazırlığı.
- Entity: Appointment, ContractAppointment.
- Kural: Onay/ret/erteleme state machine.

### 5.7 Takvim
- Amaç: Ortak slot görünürlüğü ve planlama.
- Entity: CalendarAvailability, CalendarSlot.
- Kural: Görünürlük role + ilişki + izin bazlı.

### 5.8 Lojistik / Taşıma Planlama / Yük Birleştirme
- Amaç: Uygun taşıyıcı, rota, kapasite ve parti yönetimi.
- Entity: LogisticsVehicle, LoadRequest, LoadOffer, Shipment, ShipmentLeg, RoutePlan, ConsolidatedLoad.
- Kural: Soğuk zincir, tonaj, hacim, zaman penceresi ve rota uyumu zorunlu.

### 5.9 CRM
- Amaç: İlişki geçmişi, tekrar işlem kolaylaştırma.
- Entity: CustomerLink, InteractionNote, FollowUpTask.
- Kural: Memnuniyet geçmişi yüksek eşleşmelere öncelik.

### 5.10 Puanlama ve İtibar
- Amaç: Güvenilirlik ölçümü, işlem erişim seviyesi.
- Entity: ReputationScore, ReputationEvent, Rating, Review, Badge.
- Kural: Event-sourcing; manuel puan yazımı yok.

### 5.11 Kota / Kısıt / Limit
- Amaç: Risk yönetimi ve dengeli büyüme.
- Entity: LimitPolicy, SaleQuota, PurchaseQuota, RestrictionRule.
- Kural: Ürün tipi + coğrafya + skor + geçmiş davranış.

### 5.12 Medya / Video / Görsel
- Amaç: Sahadan güven artırıcı içerik.
- Entity: MediaAsset, ModerationCase.
- Kural: Uygunsuz/başkasına ait içerik tespiti sonrası aksiyon.

### 5.13 Ürün Raporları / Belge Doğrulama
- Amaç: Kalite belgelendirme, rozet üretimi.
- Entity: ProductReport, VerificationRequest, Badge.
- Kural: Rapora dayalı “Yeşil Rozet”.

### 5.14 İçerik / Bilgi Paylaşımı
- Amaç: Eğitim ve güven iletişimi.
- Entity: Article, FAQ, Announcement.

### 5.15 İşçi Bulma / İş İlanları
- Amaç: Sezonluk iş gücü eşleşmesi.
- Entity: WorkOpportunity, WorkerInterest.
- Kural: Ayrı modül olarak başlat, başlangıçta basit eşleşme.

### 5.16 Admin / Moderasyon / Uyum
- Amaç: Kuralları uygulama, uyuşmazlık çözümü.
- Entity: AdminAuditLog, ModerationCase.

### 5.17 Bildirim / Uyarı / Mesajlaşma
- Amaç: Olay tabanlı bilgilendirme.
- Entity: Notification, MessageThread.

### 5.18 Coğrafi Eşleştirme ve Öneri Motoru
- Amaç: Mesafe-zaman-kapasite odaklı öneri.
- Entity: GeoRule, MatchingSuggestion.
- Kural: “En yakın her zaman en iyi” değil; kalite ve güvenle birlikte skorlanmalı.

---

## 6) Entity Model Proposal

> Aşağıdaki yapı ilişkisel veri tabanı (PostgreSQL/MS SQL) için önerilmiştir.

### 6.1 Ortak Alan Standartları
- Tüm ana tablolarda: `Id (GUID)`, `CreatedAt`, `CreatedBy`, `UpdatedAt`, `UpdatedBy`, `IsDeleted`, `DeletedAt`, `RowVersion`.
- Statü alanı: `Status` (enum/string code).
- Soft delete: İşlemsel/history kritik tablolarda zorunlu.

### 6.2 Çekirdek Varlıklar ve Kurallar

1. **User**
   - Alanlar: Email, Phone, PasswordHash, IsActive, LastLoginAt.
   - İlişki: UserProfile (1-1), Role (N-N), Address (1-N).
   - İndeks: unique Email, unique Phone.

2. **Role**
   - Alanlar: Name, Code.
   - İlişki: UserRole.

3. **UserProfile / FarmerProfile / RetailerProfile / CarrierProfile**
   - Zorunlu: Ad, soyad/ticari unvan, il/ilçe.
   - CarrierProfile: Vergi no, lisans, çalışma bölgesi.

4. **Address**
   - Alanlar: Type, City, District, Lat, Lon, IsPrimary.
   - Kural: Ücretsiz adres limiti sonrası ücretli plan.
   - İndeks: UserId + IsPrimary, Geo index (Lat/Lon).

5. **Field/Farm/ProductionLocation**
   - Alanlar: Name, GeoPolygon/GeoPoint, AreaSize.
   - İlişki: FarmerProfile.

6. **Product / ProductVariant / ProductCategory / ProductListing**
   - Listing alanları: Quantity, Unit, MinOrderQty, AvailableFrom, AvailableTo.
   - İndeks: ProductId, FarmerId, Available window.

7. **HarvestInfo & LastMedicationRecord**
   - Medication alanları: MedicationDate, ActiveIngredient, WithholdingDays.
   - Kural: Satış açılış tarihi = MedicationDate + max(15, ürün-kural-günü).

8. **ProductReport**
   - Alanlar: ReportType, Laboratory, ReportDate, ResultSummary, FileId.
   - İlişki: ProductListing.

9. **Badge**
   - Alanlar: BadgeType (GreenBadge vb), GrantedAt, ExpireAt, ReasonCode.

10. **ReputationScore & ReputationEvent**
   - Event: EventType, Delta, SourceEntityId, EvidenceRef, CalculatedAt.
   - İndeks: UserId + CalculatedAt, ProductId + UserId (ürün bazlı skor).
   - Kural: Event dışında score update yok.

11. **LimitPolicy / PurchaseQuota / SaleQuota**
   - Alanlar: Scope (Global/User/Product/Geo), Value, PeriodType.
   - Kural: Runtime rule engine ile evaluate edilir.

12. **Appointment / ContractAppointment**
   - Alanlar: RequestedAt, StartAt, EndAt, Location, Status.
   - Contract: RecurrenceRule, ValidFrom/To, TermsDoc.

13. **CalendarAvailability / CalendarSlot**
   - Alanlar: Date, StartTime, EndTime, CapacityType.
   - İndeks: UserId + Date.

14. **LogisticsVehicle / VehicleType / VehicleCapability / VehicleWeightRule**
   - Araç: Plate, VolumeM3, MaxPayloadKg, TareWeightKg, AxleCount, HasColdChain, HasTent.
   - Transit tonaj: `maxLegalGross - tareWeight`.

15. **LoadRequest / LoadOffer / Shipment / ShipmentLeg / RoutePlan / ConsolidatedLoad**
   - LoadRequest: pickup/dropoff, product constraints, temp range.
   - ShipmentLeg: sıra ve zaman pencereleri.
   - ConsolidatedLoad: birden çok siparişin ortak taşıması.

16. **Rating / Review**
   - Alanlar: Score(1-5), CategoryScores, Comment, TargetRole.
   - Kural: İşlem sonrası pencere içinde girilebilir.

17. **MediaAsset**
   - Alanlar: MediaType, StoragePath, Hash, Source, ModerationStatus.
   - Kural: duplicate hash ve telif şüphe skoru.

18. **VerificationRequest / ProductAddRequest**
   - Süreç bazlı durum akışı (Pending/Approved/Rejected).

19. **Auction / AuctionBid**
   - Auction: StartAt, EndAt, MinBidStep, ReservePrice, AccessPolicy.

20. **WorkOpportunity / WorkerInterest**
   - Sezon, görev tipi, ücret modeli.

21. **Notification**
   - Channel, TemplateCode, IsRead, Priority.

22. **AdminAuditLog / ModerationCase**
   - Değişmez log yapısı, aksiyon sebebi zorunlu.

23. **GeoRule / RestrictionRule / MatchingSuggestion**
   - GeoRule: bölge ve mesafe politikaları.
   - RestrictionRule: ürün tipi/kalite/kural tetikleri.

---

## 7) Business Rules & Algorithms

### 7.A Puan Sistemi

1. **Kazanım Olayları**
   - Zamanında teslimat, doğrulanmış rapor yükleme, randevuya uyum, düşük ihtilaf oranı, profil tamamlama.
2. **Düşüş Olayları**
   - Gecikme, no-show, iptal suistimali, hatalı beyan, uygunsuz içerik, teslim uyuşmazlığı.
3. **Zor kazanım prensibi**
   - +1/+2 küçük adımlar; negatif olaylarda -3/-5 gibi daha sert düşüş.
4. **Yeni üye adaleti**
   - “Nötr başlangıç + korumalı gözlem dönemi” (örn. ilk 10 işlemde sınırlı volatilite).
5. **Admin müdahalesi neden yok?**
   - Güvenilirlik ve manipülasyon direnci için score yalnızca event’lerden türemeli.
6. **Event sourcing uygunluğu**
   - Evet. `ReputationEvent` immutable; score projection türetilmiş veri.
7. **Ürün bazlı + genel puan birlikte**
   - Evet: `GeneralTrustScore` + `ProductCategoryScore` hibriti.
8. **Rol bazlı ayrı skor**
   - Çiftçi: kalite/tutarlılık. Taşımacı: teslim performansı. Satıcı: ödeme/ret oranı.
9. **Limit bağlantısı**
   - Min trust threshold altında büyük hacim engeli.

### 7.B Kota & Limit
- Kota = `BaseQuota * TrustMultiplier * GeoMultiplier * SeasonMultiplier`.
- Düşük puan kullanıcı: düşük max order, ön ödeme/ek doğrulama zorunluluğu.
- Yeni üye: kademeli açılım (Aşama-1 düşük limit, Aşama-2 doğrulama sonrası artış).

### 7.C Kısıtlama
- Son ilaçlama + 15 gün minimum.
- Hızlı bozulan ürünlerde (ürüne göre) sipariş açılışı erken olabilir ama teslim penceresi daha sıkı.
- Taze/kuru ürün farklı rule set.
- Karşılıklı memnuniyet ve doğrulanmış işlem geçmişiyle bazı operasyonel kısıtlar azaltılabilir.

### 7.D Lojistik
- Taşıyıcı öneri skoru:
  - `RouteFit + CapacityFit + ColdChainFit + Reliability + CostScore + TimeWindowFit`.
- Yük birleştirme:
  - aynı rota koridoru, sıcaklık uyumu, zaman penceresi yakınlığı.
- Parçalı taşıma:
  - 1 sipariş çoklu leg veya çoklu araç.
- Transit tonaj kontrolü:
  - yasal brüt sınırı aşan atamalar reddedilir.

### 7.E Randevu & Takvim
- Durumlar: Requested → Accepted/Rejected → Completed/Cancelled/Rescheduled.
- Taşımacı planı, kabul edilen randevu slotlarından beslenir.
- Takvim görünürlüğü: yalnız ilişki kurulan taraflar + izinli detay düzeyi.
- Sözleşmeli randevu: recurring rule + minimum ceza/kural seti.

### 7.F İçerik & Güven
- Düzenli saha içeriği paylaşımı küçük pozitif puan event’i üretir.
- Medya moderasyon pipeline: hash, AI risk skoru, manuel inceleme.
- Yeşil rozet doğrulama: geçerli ürün raporu + ilaçlama kural uyumu + moderasyon temizliği.

### 7.G Ek Notların Ürünleştirilmesi
- **Sloganlar:** Pazarlama katmanında landing + kampanya modülüne bağlanmalı; işlem motoruna değil.
- **Puan suistimali önleme:** aynı taraflar arasında tekrarlı düşük hacimli sahte işlemlere anti-gaming kuralı.
- **Yeni üye başlangıcı:** düşük riskli nötr skor + doğrulamaya dayalı hızlandırılmış iyileştirme.
- **Randevu+lojistik takvim:** tek takvim motoru, farklı görünüm/izin katmanlarıyla.
- **İlaçlama-rapor-rozet:** kural motoru + belge doğrulama + tarihsel geçerlilik kontrolü.
- **Açık artırma ödülü:** güven skoru eşiği + başarılı işlem adedi eşiği ile açılmalı.
- **İşçi bulma:** orta vadede ayrı modül (yan özellik değil), çünkü farklı veri modeli ve riskleri var.

---

## 8) Screen / UX Map

### 8.1 Ortak Ekran Seti

1. **Dashboard (rol bazlı)**
   - Amaç: KPI, bekleyen aksiyon, risk uyarıları.
   - Ana alanlar: sipariş, randevu, skor, kota.
   - Mobil: kart öncelikli, tek kolon.

2. **Profil**
   - Amaç: hesap, doğrulama, adres/araç/kapasite bilgisi.
   - Validasyon: zorunlu belge ve format kontrolleri.

3. **Ürün Listeleme & Detay**
   - Amaç: ürün keşfi, güven göstergeleri.
   - Alanlar: kalite raporu, son ilaçlama, rozet, lojistik uygunluk.

4. **Sipariş Akışı**
   - Aksiyon: teklif ver, sipariş oluştur, teslim tercihi.
   - Hata durumu: kota/limit aşıldı, kısıt ihlali.

5. **Randevu Talep + Takvim**
   - Aksiyon: slot seç, onayla, ertele.
   - Boş durum: uygun slot yoksa öneri.

6. **Taşıma Planlama + Araç Kayıt**
   - Aksiyon: yük eşleştir, leg planla, kapasite doğrula.
   - Hata: soğuk zincir uyumsuzluğu, tonaj aşımı.

7. **Müşteri Detay / CRM**
   - İlişki geçmişi, memnuniyet, tekrar işlem önerisi.

8. **Puan ve Güven Paneli**
   - Skor kırılımı (genel + ürün bazlı), son event’ler, geliştirme önerileri.

9. **Ürün Rapor Yükleme**
   - Belge format/doğrulama kontrolü.

10. **Açık Artırma**
   - Yalnız ödül hakkı olan kullanıcılar erişir.

11. **Ürün Ekleme Talebi**
   - Yeni tür/model için istek ekranı.

12. **İşçi Bulma**
   - İlan açma, başvuru yönetimi.

13. **Yönetim + Moderasyon Paneli**
   - Vaka kuyruğu, aksiyon, audit log görünümü.

14. **Coğrafi Öneri Ekranı**
   - Harita, mesafe, rota, öneri skoru bileşenleri.

15. **Bildirim Merkezi**
   - Öncelik, okundu, aksiyon bağlantıları.

---

## 9) Mobile-First Quality Standards

1. Breakpoint: 360/390, 768, 1024, 1280.
2. Dashboard kartları: yatay taşma yok, kritik aksiyon butonu “thumb zone”.
3. Tablolar: kartlaştırma + kolon gizleme + detay drawer.
4. Formlar: tek kolon, adım bazlı wizard (uzun formlarda).
5. Takvim: haftalık/ajanda toggle; küçük ekranda timeline ağırlıklı.
6. Harita/lojistik: tam ekran map + alt çekme paneli.
7. Modal yerine mobilde bottom-sheet tercih.
8. Navbar: alt sabit hızlı aksiyonlar; sidebar yalnız tablet/desktop.
9. Erişilebilirlik: min 44px dokunma alanı, kontrast ve odak görünürlüğü.
10. Performans: görsel lazy-load, kritik CSS, skeleton state.

---

## 10) Technical Architecture Recommendations

### 10.1 Katmanlı Mimari (ASP.NET Core MVC)
- `PazarCep.Web` (MVC + Areas + ViewComponents)
- `PazarCep.Application` (UseCase/Service, DTO, Validators)
- `PazarCep.Domain` (Entity, ValueObject, DomainService, Events)
- `PazarCep.Infrastructure` (EF Core, repository, integrations)
- `PazarCep.Contracts` (API contracts)

### 10.2 Önerilen Prensipler
- Controller ince, servis kalın (iş kuralı application/domain’de).
- Repository yalnız aggregate erişimi için.
- CQRS-lite: kritik okuma ekranları için read model.
- Modül bazlı `Areas`: Admin, Farmer, Retailer, Carrier.
- Ortak ViewComponent: skor kartı, rozet etiketi, kural ihlal uyarısı.

### 10.3 Teknik Borç Azaltma
- Tekrarlı validation’lar FluentValidation/policy setlerine taşınmalı.
- Enum/string code standardizasyonu.
- Modül başına integration test paketi.

---

## 11) Security & Moderation Strategy

1. RBAC + resource-based authorization.
2. Kritik aksiyonlarda ikinci doğrulama (step-up auth).
3. İçerik moderasyon pipeline (otomatik + manuel).
4. Anti-abuse: rate limit, davranışsal anomaly, sahte işlem tespiti.
5. Değişmez audit log (admin işlemleri dahil).
6. Kural motoru ihlali anında uyarı + aksiyon kilidi.
7. PII koruması: şifreleme, masking, KVKK/GDPR uyum kabiliyeti.

---

## 12) Operational / Deployment Considerations

1. Ortamlar: Dev / Staging / Prod ayrımı.
2. CI/CD: build-test-security scan-migration gate.
3. Docker image: çok aşamalı build, minimum runtime image.
4. Static assets: versioned hash, CDN/edge cache.
5. Log/metric/tracing: merkezi gözlemlenebilirlik.
6. Rollback planı: blue/green veya canary.
7. DB migration: backward compatible aşamalı geçiş.

---

## 13) Short-Term MVP Scope

1. Kimlik/rol/profil + doğrulama temel akış.
2. Ürün ilanı + hasat/ilaçlama + rapor yükleme.
3. Sipariş/teklif temel akış.
4. Randevu + takvim temel slot yönetimi.
5. Taşımacı araç kayıt + temel eşleştirme.
6. Puan event altyapısı + temel kota.
7. Moderasyon paneli v1.

---

## 14) Mid-Term Expansion Scope

1. Sözleşmeli randevu ve recurring takvim.
2. Yük birleştirme + parçalı taşıma optimizasyonu.
3. Ürün bazlı puan + genel puan hibrit görünüm.
4. Coğrafi öneri ve dinamik kota v2.
5. Açık artırma ödül mekanizması.
6. İşçi bulma modülü v1.

---

## 15) Long-Term Platform Strategy

1. Bölgesel tedarik ağlarının kurumsallaşması.
2. Veri güdümlü fiyat/tedarik öngörüleri.
3. Finans/insurtech entegrasyonları.
4. Platform API ekosistemi.
5. Çoklu ülke/lokalizasyon hazırlığı.

---

## 16) Risks / Ambiguities / Open Questions

1. Yük veren/yük alan rollerinin çiftçi-satıcıdan ayrışma sınırı.
2. Açık artırmanın hangi ürün kategorilerinde uygun olduğu.
3. Coğrafi yakınlık önerisinin rekabet ve fiyat etkisi.
4. Puanın hukuki itiraz/itiraz çözüm süreci.
5. Video içeriklerin dış platform (YouTube) uyum ve hak yönetimi.
6. Ek adres ücretlendirme modelinin tahsilat altyapısı.

---

## 17) Recommended First Implementation Steps

### 17.1 Önceliklendirme (Koddan Önce)
1. Domain sözlüğü ve statü/state tanımlarını netleştir.
2. Rol-matrisi policy listesini kesinleştir.
3. Puan event katalogunu ve quota formülünü imzala.
4. Randevu+lojistik takviminin ortak veri sözleşmesini yaz.
5. Kısıt motoru (ilaçlama/hasat/taze-kuru) kural tablolarını tamamla.

### 17.2 İlk Dokunulacak Dosya/Modül Listesi (Küçük ve Kontrollü)
1. Domain katmanı: `ReputationEvent`, `RestrictionRule`, `QuotaPolicy` modelleri.
2. Application katmanı: skor hesaplayıcı, limit evaluator servisleri.
3. Web katmanı: rol bazlı dashboard ve uyarı bileşeni.
4. Admin alanı: moderasyon kuyruk ekranı.

### 17.3 Bağımsız & Test Edilebilir İş Parçaları
1. **Puan event hesaplama servisi** (unit test).
2. **Kısıt kontrol servisi** (ilaçlama + gün kuralı) (unit test).
3. **Taşıyıcı öneri skoru** (deterministik test).
4. **Randevu state machine** (transition test).
5. **Kota evaluator** (boundary test).

### 17.4 Sıfırdan Refactor Yerine Kontrollü Evrim
- Mevcut çalışan akışlar korunur.
- Her sprintte 1–2 modülün kural motoru olgunlaştırılır.
- Veri modeli migration’ları backward-compatible yapılır.

