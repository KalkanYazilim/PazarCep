// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// === PazarCep - Yan Menü Genişlik Ayarı (Resizable Sidebar) ===
window.addEventListener('load', function () {
  try {
    var sidebar = document.getElementById('layout-menu');
    var resizer = document.getElementById('pcSidebarResizer');
    var STORAGE_KEY = 'pazarcep_sidebar_width';

    // Elemanlar yoksa sessizce çık
    if (!sidebar || !resizer) {
      return;
    }

    // Sayfa açıldığında önceki genişliği uygula
    var savedWidth = localStorage.getItem(STORAGE_KEY);
    if (savedWidth) {
      applyWidth(parseInt(savedWidth, 10));
    }

    var isResizing = false;

    resizer.addEventListener('mousedown', function (e) {
      isResizing = true;
      document.body.classList.add('pc-sidebar-resizing');
      e.preventDefault();
    });

    document.addEventListener('mousemove', function (e) {
      if (!isResizing) return;

      var rect = sidebar.getBoundingClientRect();
      var newWidth = e.clientX - rect.left;

      // Min / max sınırlar
      if (newWidth < 200) newWidth = 200;
      if (newWidth > 420) newWidth = 420;

      applyWidth(newWidth);
    });

    document.addEventListener('mouseup', function () {
      if (!isResizing) return;

      isResizing = false;
      document.body.classList.remove('pc-sidebar-resizing');

      var width = parseInt(window.getComputedStyle(sidebar).width, 10);
      localStorage.setItem(STORAGE_KEY, width);
    });

    function applyWidth(width) {
      sidebar.style.width = width + 'px';
      document.documentElement.style.setProperty('--pc-sidebar-width', width + 'px');

      // 🔥 core.css’in içerik padding’i bununla hesaplanıyor
      document.documentElement.style.setProperty('--bs-menu-width', width + 'px');
    }
  } catch (err) {
    console.error('PazarCep sidebar resize hatası:', err);
  }
});
