(() => {
  const calendarGrid = document.querySelector("[data-calendar-grid]");
  const dayButtons = Array.from(document.querySelectorAll("[data-calendar-day]"));
  const detailPanels = Array.from(document.querySelectorAll("[data-day-detail]"));
  const selectedDateTitle = document.querySelector("[data-selected-date-title]");

  if (!calendarGrid || dayButtons.length === 0 || detailPanels.length === 0) {
    return;
  }

  const selectDay = button => {
    const targetId = button.dataset.target;
    const targetPanel = document.getElementById(targetId);

    if (!targetPanel) {
      return;
    }

    dayButtons.forEach(item => {
      item.classList.toggle("pc-calendar-day--selected", item === button);
      item.setAttribute("aria-pressed", item === button ? "true" : "false");
    });

    detailPanels.forEach(panel => panel.classList.toggle("is-active", panel === targetPanel));

    if (selectedDateTitle) {
      selectedDateTitle.textContent = targetPanel.dataset.dateTitle || "";
    }
  };

  dayButtons.forEach(button => {
    button.addEventListener("click", () => selectDay(button));
  });
})();
