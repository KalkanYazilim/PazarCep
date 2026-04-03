// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
        // YIL
document.addEventListener("DOMContentLoaded", function () {
  // YIL
  var yearEl = document.getElementById("pcYear");
  if (yearEl) {
    yearEl.textContent = new Date().getFullYear();
  }

  // SMOOTH SCROLL HELPER
  window.scrollToSection = function (id) {
    var el = document.getElementById(id);
    if (!el) return;
    el.scrollIntoView({ behavior: "smooth", block: "start" });
  };

  // MOBILE NAV TOGGLE
  var mobileToggle = document.getElementById("pcMobileToggle");
  var mobileNav = document.getElementById("pcMobileNav");

  if (mobileToggle && mobileNav) {
    mobileToggle.addEventListener("click", function () {
      mobileToggle.classList.toggle("active");
      mobileNav.classList.toggle("open");
    });

    mobileNav.querySelectorAll("a").forEach(function (a) {
      a.addEventListener("click", function () {
        mobileToggle.classList.remove("active");
        mobileNav.classList.remove("open");
      });
    });
  }

  // FAQ ACCORDION
  var faqItems = document.querySelectorAll(".pc-faq-item");
  faqItems.forEach(function (item) {
    var header = item.querySelector(".pc-faq-header");
    if (!header) return;

    header.addEventListener("click", function () {
      var isActive = item.classList.contains("active");
      faqItems.forEach(function (it) {
        it.classList.remove("active");
      });
      if (!isActive) {
        item.classList.add("active");
      }
    });
  });

  // CONTACT FORM (DEMO VALIDATION)
  var contactForm = document.getElementById("pcContactForm");
  var formSuccess = document.getElementById("pcFormSuccess");

  if (contactForm) {
    contactForm.addEventListener("submit", function (e) {
      e.preventDefault();

      var formData = new FormData(contactForm);
      var requiredFields = ["name", "role", "phone", "city", "message"];
      var valid = true;

      requiredFields.forEach(function (field) {
        if (!formData.get(field)) {
          valid = false;
        }
      });

      if (!valid) {
        alert("Lütfen tüm alanları doldurun.");
        return;
      }

      contactForm.reset();

      if (formSuccess) {
        formSuccess.classList.add("visible");
        setTimeout(function () {
          formSuccess.classList.remove("visible");
        }, 4000);
      }
    });
  }
});
