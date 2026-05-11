# 03 - Login ve Rol Değiştirme Akışı

Mevcut auth yapısında `AuthController` login/register viewlarını döndürür. Register ekranı `RegisterBasicViewModel.SelectedRoles` ile public rol tercihlerini alır ve `PublicUserRoles.AllowedRoleKeys` ile filtreler. Gerçek kullanıcı/rol kalıcılığı ve dashboard yönlendirmesi henüz öneri seviyesindedir.

## Hedef Akış

1. Kullanıcı giriş yapar.
2. Sistem kullanıcının onaylı rollerini bulur.
3. Tek rol varsa ilgili dashboarda yönlendirir.
4. Birden fazla rol varsa aktif rol seçimi gösterir.
5. Aktif rol session, claim veya profil tercihi olarak saklanır.
6. Dashboard, menü ve ortak sayfalar aktif role göre render edilir.
7. Ortak sayfalar `RoleKey`, tema sınıfı ve role özel aksiyonlarla uyarlanır.

## Mevcut Kod Bağlantıları

- Login/Register: `Controllers/AuthController.cs`, `Views/Auth/LoginBasic.cshtml`, `Views/Auth/RegisterBasic.cshtml`
- Role switcher: `Views/Panel/_RoleSwitcher.cshtml`
- Role dashboards: `Controllers/PanelController.cs`
- Menü: `Views/Shared/Sections/Menu/_VerticalMenu.cshtml`

## Eksikler

- ASP.NET Identity veya kalıcı kullanıcı rol tablosu ile bağlanmış aktif rol seçimi yok.
- Menüde tüm rol grupları görünür; kullanıcı rolüne göre filtreleme TODO olarak işaretlenmiştir.

Diagram: `diagrams/login-role-switch-flow.mmd`
