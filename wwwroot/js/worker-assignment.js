(() => {
  const root = document.querySelector("[data-worker-assignment]");
  if (!root) {
    return;
  }

  const zones = Array.from(root.querySelectorAll("[data-worker-zone]"));
  const wageInput = root.querySelector("[data-wage-input]");
  const assignedCount = root.querySelector("[data-assigned-count]");
  const totalCost = root.querySelector("[data-total-cost]");
  let draggedCard = null;

  const formatMoney = value => new Intl.NumberFormat("tr-TR", {
    style: "currency",
    currency: "TRY",
    maximumFractionDigits: 0
  }).format(value);

  const updateCost = () => {
    const assignedZone = root.querySelector('[data-worker-zone="assigned"]');
    const count = assignedZone ? assignedZone.querySelectorAll("[data-worker-card]").length : 0;
    const wage = Number(wageInput?.value || 0);

    if (assignedCount) {
      assignedCount.textContent = count.toString();
    }

    if (totalCost) {
      totalCost.textContent = formatMoney(count * wage);
    }
  };

  const attachCardEvents = card => {
    card.addEventListener("dragstart", event => {
      draggedCard = card;
      event.dataTransfer.effectAllowed = "move";
      event.dataTransfer.setData("text/plain", card.dataset.workerId || "");
    });

    card.addEventListener("dragend", () => {
      draggedCard = null;
      zones.forEach(zone => zone.classList.remove("is-over"));
      updateCost();
    });
  };

  root.querySelectorAll("[data-worker-card]").forEach(attachCardEvents);

  zones.forEach(zone => {
    zone.addEventListener("dragover", event => {
      event.preventDefault();
      zone.classList.add("is-over");
    });

    zone.addEventListener("dragleave", () => {
      zone.classList.remove("is-over");
    });

    zone.addEventListener("drop", event => {
      event.preventDefault();
      zone.classList.remove("is-over");

      if (draggedCard) {
        zone.appendChild(draggedCard);
        updateCost();
      }
    });
  });

  wageInput?.addEventListener("input", updateCost);
  updateCost();
})();
