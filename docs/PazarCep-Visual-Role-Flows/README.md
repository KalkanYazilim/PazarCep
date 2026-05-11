# PazarCep Görsel Rol Akışları

Son güncelleme: 2026.05.11

Bu klasör PazarCep uygulamasındaki rol bazlı kullanıcı akışlarını görsel Mermaid diyagramları ve kısa açıklama dokümanlarıyla toplar. Diyagramlar mevcut ASP.NET Core MVC kod yapısına göre hazırlanmıştır; eksik production parçaları ilgili dokümanlarda “Planlanan / önerilen akış” olarak işaretlenmiştir.

## Kapsam

- Genel uygulama rol akışı
- Çiftçi / Üreten akışı
- Alıcı / Manav / Market / Pazarcı akışı
- Yevmiyeci / İşçi akışı
- Lojistikçi / Nakliyeci akışı
- Danışman / Ziraat Uzmanı akışı
- Ortak operasyon sayfası akışı
- Finans ve bildirim akışı

## Mevcut Kod Bağlantıları

- Controller: `Controllers/PanelController.cs`
- Auth: `Controllers/AuthController.cs`
- ViewModel/factory: `Models/BusinessPanelViewModels.cs`
- Panel viewları: `Views/Panel/*.cshtml`
- Menü: `Views/Shared/Sections/Menu/_VerticalMenu.cshtml`
- Randevu: `Areas/ETicaret/Controllers/RandevuController.cs`

## Diyagramlar

Mermaid kaynakları `diagrams/` klasöründedir. GitHub, Visual Studio Code Mermaid eklentileri veya Mermaid Live Editor ile önizlenebilir.

SVG/PNG export bu turda eklenmedi; repoda ek Mermaid CLI veya güvenli export aracı bulunmadığı için `.mmd` kaynakları teslim edildi.
