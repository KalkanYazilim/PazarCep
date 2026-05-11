# 06 - Yevmiyeci / İşçi Akışı

## Amaç

Yevmiyeci iş davetlerini görür, 30 dakikalık onay süresi içinde kabul/reddeder, takvimini ve kazançlarını takip eder.

## Ana Route

- Dashboard: `/Panel/Yevmiyeci`
- Operasyon: `/Panel/YevmiyeciOperasyon`

## Menü Öğeleri

- Genel Bakış
- Operasyon Takvimi
- İş Davetleri
- Takvimim
- Kazançlarım

## Ana Kullanıcı Aksiyonları

- Davetleri listeleme.
- Onay süresini görme.
- Daveti kabul veya reddetme.
- Kabul edilen işi takvimde görme.
- Tamamlanan işi kazanç listesine yansıtma.
- Ödeme durumunu takip etme.

## 30 Dakika Onay Mantığı

- `InvitationSentAt`: davetin gönderildiği zaman.
- `ApprovalDeadlineAt = InvitationSentAt + 30 dakika`.
- İşçi süre içinde kabul ederse status `Accepted`.
- İşçi reddederse status `Rejected`.
- Süre dolarsa status `Expired`.
- Süre dolduğunda davet eden kullanıcıya şu mesaj gösterilir: “İşçi 30 dakika içinde onay vermedi. Lütfen başka bir işçi çağırın.”

## Mevcut Riskler

- Countdown UI simülasyon seviyesindedir.
- Gerçek zamanlı bildirim ve kalıcı davet durumu yoktur.

## Öneriler

- Worker invitation endpointleri eklenmeli.
- `ApprovalDeadlineAt` background job ile kontrol edilmeli.
- Kabul edilen işler takvim ve finans kayıtlarıyla ilişkilendirilmeli.

Diagram: `diagrams/worker-flow.mmd`
