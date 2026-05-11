# 07 - Lojistikçi / Nakliyeci Akışı

## Amaç

Lojistikçi araçları, sürücüleri, nakliye işleri, rota, yakıt, bakım gideri, teslimat geliri ve net bakiyeyi yönetir.

## Ana Route

- Dashboard: `/Panel/Lojistik`
- Operasyon: `/Panel/LojistikOperasyon`

## Menü Öğeleri

- Genel Bakış
- Operasyon Takvimi
- Araçlarım
- Nakliye İşleri
- Gelir / Gider

## Ana Kullanıcı Aksiyonları

- Araç kaydı yönetme.
- Nakliye işi oluşturma.
- Araç/sürücü atama.
- Alış ve teslim zamanlarını takip etme.
- Nakliye geliri kaydetme.
- Yakıt, bakım, sürücü ve yol gideri kaydetme.

## Yönetilen Veri

Araç adı, plaka, araç tipi, kapasite, sürücü, durum, ürün/sipariş, alış noktası, teslim noktası, ücret, yakıt gideri.

## Ortak Sayfalar

- Operasyon Takvimi: nakliye işi, teslimat tarihi, ödeme hatırlatmaları.
- Gelir / Gider: nakliye geliri, yakıt ve bakım gideri.

## Riskler

- Araç ve nakliye işleri demo ViewModel verisidir.
- Rota/harita entegrasyonu yoktur.

## Öneriler

- `Vehicle`, `TransportJob`, `RouteStop`, `FuelExpense` modelleri eklenmeli.
- Teslimat yaklaşınca bildirim üretilmeli.

Diagram: `diagrams/logistics-flow.mmd`
