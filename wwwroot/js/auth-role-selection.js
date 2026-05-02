(() => {
  const forms = document.querySelectorAll('[data-role-selection-form]');

  forms.forEach(form => {
    const message = form.querySelector('[data-role-validation-message]');
    const roleInputs = Array.from(form.querySelectorAll('input[name="SelectedRoles"]'));

    const updateState = () => {
      const hasSelection = roleInputs.some(input => input.checked);

      if (message && hasSelection && message.textContent.trim() === "Lütfen PazarCep’i hangi amaçla kullanacağınızı seçin.") {
        message.textContent = "";
      }

      roleInputs.forEach(input => {
        input.closest(".pc-role-option")?.classList.toggle("is-selected", input.checked);
      });

      return hasSelection;
    };

    roleInputs.forEach(input => input.addEventListener("change", updateState));

    form.addEventListener("submit", event => {
      if (updateState()) {
        return;
      }

      event.preventDefault();

      if (message) {
        message.textContent = "Lütfen PazarCep’i hangi amaçla kullanacağınızı seçin.";
      }

      roleInputs[0]?.focus();
    });

    updateState();
  });
})();
