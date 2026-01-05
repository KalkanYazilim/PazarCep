// wwwroot/js/pc-menu-nav.js
document.addEventListener("DOMContentLoaded", function () {
  // Başlık linkleri: hem alt menüyü aç, hem navigasyona izin ver
  document.querySelectorAll('a.pc-navlink[data-pc-toggle="true"]').forEach(function (a) {
    a.addEventListener("click", function () {
      // Bu linkin üstündeki li.menu-item'ı bul
      const li = a.closest("li.menu-item");
      if (!li) return;

      // Menüyü açık hale getir (server-side "active open" gibi)
      li.classList.add("open");
      li.classList.add("active");

      // Alt menü ul varsa gösterilecek (tema css zaten open ile yönetiyor)
      // Navigasyon İPTAL ETMİYORUZ -> sayfa yüklenecek
    }, { capture: true });
  });
});
