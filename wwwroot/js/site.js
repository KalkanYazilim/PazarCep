window.addEventListener("load", function () {
  try {
    var sidebar = document.getElementById("layout-menu");
    var resizer = document.getElementById("pcSidebarResizer");
    var storageKey = "pazarcep_sidebar_width";
    var desktopQuery = window.matchMedia("(min-width: 1200px)");

    if (!sidebar || !resizer) {
      return;
    }

    var isResizing = false;
    var savedWidth = parseInt(localStorage.getItem(storageKey) || "", 10);

    function clampWidth(width) {
      if (Number.isNaN(width)) {
        return 288;
      }

      return Math.min(360, Math.max(240, width));
    }

    function applyWidth(width) {
      var nextWidth = clampWidth(width);
      sidebar.style.width = nextWidth + "px";
      document.documentElement.style.setProperty("--pc-sidebar-width", nextWidth + "px");
      document.documentElement.style.setProperty("--bs-menu-width", nextWidth + "px");
    }

    function resetWidth() {
      sidebar.style.removeProperty("width");
      document.documentElement.style.removeProperty("--pc-sidebar-width");
      document.documentElement.style.removeProperty("--bs-menu-width");
      document.body.classList.remove("pc-sidebar-resizing");
      isResizing = false;
    }

    function syncSidebarMode() {
      if (!desktopQuery.matches) {
        resetWidth();
        return;
      }

      applyWidth(savedWidth || 288);
    }

    syncSidebarMode();

    resizer.addEventListener("mousedown", function (event) {
      if (!desktopQuery.matches) {
        return;
      }

      isResizing = true;
      document.body.classList.add("pc-sidebar-resizing");
      event.preventDefault();
    });

    document.addEventListener("mousemove", function (event) {
      if (!isResizing || !desktopQuery.matches) {
        return;
      }

      var rect = sidebar.getBoundingClientRect();
      applyWidth(event.clientX - rect.left);
    });

    document.addEventListener("mouseup", function () {
      if (!isResizing) {
        return;
      }

      isResizing = false;
      document.body.classList.remove("pc-sidebar-resizing");
      savedWidth = clampWidth(parseInt(window.getComputedStyle(sidebar).width, 10));
      localStorage.setItem(storageKey, savedWidth);
    });

    if (typeof desktopQuery.addEventListener === "function") {
      desktopQuery.addEventListener("change", syncSidebarMode);
    } else if (typeof desktopQuery.addListener === "function") {
      desktopQuery.addListener(syncSidebarMode);
    }
  } catch (error) {
    console.error("PazarCep sidebar resize hatası:", error);
  }
});
