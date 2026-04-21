document.addEventListener("DOMContentLoaded", function () {
  // Üst menüde hem menü açma hem de normal sayfa geçişini birlikte korur.
  document.querySelectorAll('a.pc-navlink[data-pc-toggle="true"]').forEach(function (link) {
    link.addEventListener(
      "click",
      function () {
        const menuItem = link.closest("li.menu-item");
        if (!menuItem) return;

        menuItem.classList.add("open");
        menuItem.classList.add("active");
      },
      { capture: true }
    );
  });
});
