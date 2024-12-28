
# Veritabanı Adı
PazarCep_DB

## Tablo Yapıları ve İlişkiler

### 1. Kullanıcılar Tablosu (Kullanicilar)
**Amaç**: Tüm kullanıcıların temel bilgilerini saklamak.
**Kolonlar**:
- `KullaniciID` (PK, INT, AUTO_INCREMENT): Kullanıcının benzersiz kimliği.
- `AdSoyad` (VARCHAR(255)): Kullanıcının adı ve soyadı.
- `Email` (VARCHAR(255)): Kullanıcının e-posta adresi.
- `Sifre` (VARCHAR(255)): Kullanıcının şifresi (hashlenmiş).
- `Rol` (ENUM: 'Çiftçi', 'Satıcı', 'Taşımacı', 'Yük Veren'): Kullanıcının rolü.
- `KayitTarihi` (DATETIME): Kullanıcının kayıt tarihi.
- `Durum` (ENUM: 'Aktif', 'Pasif'): Kullanıcının durumu.

---

### 2. Çiftçi Bilgileri Tablosu (CiftciBilgileri)
**Amaç**: Çiftçilere özel bilgileri saklamak.
**Kolonlar**:
- `CiftciID` (PK, FK, INT): Çiftçinin kimliği (`Kullanicilar.KullaniciID` ile ilişkilidir).
- `TarlaAdi` (VARCHAR(255)): Tarlanın adı.
- `Konum` (VARCHAR(255)): Tarlanın konumu.
- `UrunListesi` (TEXT): Çiftçinin ürettiği ürünler.
- `TasimaTercihi` (ENUM: 'Kendi', 'Platform'): Taşımacılık tercihi.
- `ResimYolu` (VARCHAR(255)): Tarlaya ait resimlerin yolu.

---

### 3. Ürünler Tablosu (Urunler)
**Amaç**: Çiftçiler tarafından eklenen ürün bilgilerini saklamak.
**Kolonlar**:
- `UrunID` (PK, INT, AUTO_INCREMENT): Ürünün benzersiz kimliği.
- `CiftciID` (FK, INT): Ürünü ekleyen çiftçinin kimliği (`CiftciBilgileri.CiftciID` ile ilişkilidir).
- `UrunAdi` (VARCHAR(255)): Ürünün adı.
- `UrunTipi` (ENUM: 'Yaş', 'Kuru'): Ürünün tipi.
- `Miktar` (DECIMAL(10, 2)): Ürünün miktarı (kg/ton).
- `Fiyat` (DECIMAL(10, 2)): Ürünün fiyatı.
- `EklenmeTarihi` (DATETIME): Ürünün eklenme tarihi.

---

### 4. Yük Veren Bilgileri Tablosu (YukVerenBilgileri)
**Amaç**: Yük Veren rolüne özel bilgileri saklamak.
**Kolonlar**:
- `YukVerenID` (PK, FK, INT): Yük Veren kullanıcının kimliği (`Kullanicilar.KullaniciID` ile ilişkilidir).
- `FirmaAdi` (VARCHAR(255)): Yük Veren firmanın adı.
- `IletisimBilgileri` (TEXT): Firmanın iletişim bilgileri.
- `VergiNo` (VARCHAR(20)): Firmanın vergi numarası (opsiyonel).

---

### 5. Yük İlanları Tablosu (YukIlanlari)
**Amaç**: Yük Veren rolüne ait taşımacılık taleplerini saklamak.
**Kolonlar**:
- `YukID` (PK, INT, AUTO_INCREMENT): Yük ilanının benzersiz kimliği.
- `YukVerenID` (FK, INT): İlanı oluşturan Yük Veren kimliği (`YukVerenBilgileri.YukVerenID` ile ilişkilidir).
- `UrunAdi` (VARCHAR(255)): Taşınacak yükün adı.
- `Miktar` (DECIMAL(10, 2)): Taşınacak yük miktarı.
- `KonumBaslangic` (VARCHAR(255)): Yükün alınacağı konum.
- `KonumBitis` (VARCHAR(255)): Yükün teslim edileceği konum.
- `TasimaDurumu` (ENUM: 'Bekliyor', 'Yüklendi', 'Teslim Edildi'): Yükün taşınma durumu.
- `OlusturmaTarihi` (DATETIME): İlanın oluşturulma tarihi.

---

### 6. Taşımacı Bilgileri Tablosu (TasimaciBilgileri)
**Amaç**: Taşımacılara özel bilgileri saklamak.
**Kolonlar**:
- `TasimaciID` (PK, FK, INT): Taşımacının kimliği (`Kullanicilar.KullaniciID` ile ilişkilidir).
- `AracPlaka` (VARCHAR(20)): Taşımacının aracının plakası.
- `Tonaj` (DECIMAL(10, 2)): Aracın taşıma kapasitesi (ton).
- `Sogutma` (BOOLEAN): Aracın soğutmalı olup olmadığı.
- `Guzergah` (TEXT): Taşımacının düzenli güzergah bilgileri.

---

### 7. Randevular Tablosu (Randevular)
**Amaç**: Tüm roller arasında gerçekleşen randevuları takip etmek.
**Kolonlar**:
- `RandevuID` (PK, INT, AUTO_INCREMENT): Randevunun benzersiz kimliği.
- `OlusturanID` (FK, INT): Randevuyu oluşturan kullanıcının kimliği (`Kullanicilar.KullaniciID` ile ilişkilidir).
- `HedefID` (FK, INT): Randevunun hedef tarafının kimliği (`Kullanicilar.KullaniciID` ile ilişkilidir).
- `UrunID` (FK, INT): Randevuya dahil olan ürünün kimliği (`Urunler.UrunID` ile ilişkilidir).
- `RandevuTarihi` (DATETIME): Randevunun gerçekleşeceği tarih ve saat.
- `Durum` (ENUM: 'Planlandı', 'Onaylandı', 'Tamamlandı', 'İptal Edildi'): Randevunun durumu.

---

### 8. Teslimat Durumları Tablosu (TeslimatDurumlari)
**Amaç**: Yük ve ürünlerin teslimat durumlarını saklar.
**Kolonlar**:
- `TeslimatID` (PK, INT, AUTO_INCREMENT): Teslimat kaydının benzersiz kimliği.
- `TasimaID` (FK, INT): Taşıma kaydının kimliği (`TasimaciBilgileri.TasimaciID` ile ilişkilidir).
- `UrunID` (FK, INT): Teslim edilen ürünün kimliği (`Urunler.UrunID` ile ilişkilidir).
- `Durum` (ENUM: 'Yolda', 'Teslim Edildi'): Teslimat durumu.
- `TeslimTarihi` (DATETIME): Teslimatın gerçekleştiği tarih.

---

## Tablolar Arası İlişkiler
- **Kullanicilar →** CiftciBilgileri, YukVerenBilgileri, TasimaciBilgileri: Bir kullanıcı bir role sahiptir.
- **Kullanicilar →** Randevular, YukIlanlari: Bir kullanıcı birden fazla randevu veya ilan oluşturabilir.
- **Urunler →** Siparisler, Randevular, TeslimatDurumlari: Ürünler bu tablolarla ilişkilidir.
- **TasimaciBilgileri →** TeslimatDurumlari: Taşımacılar teslimatlarla ilişkilidir.
