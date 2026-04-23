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
    var closeMobileMenu = function () {
      mobileToggle.classList.remove("active");
      mobileToggle.setAttribute("aria-expanded", "false");
      mobileNav.classList.remove("open");
      document.body.classList.remove("pc-mobile-nav-open");
    };

    var openMobileMenu = function () {
      mobileToggle.classList.add("active");
      mobileToggle.setAttribute("aria-expanded", "true");
      mobileNav.classList.add("open");
      document.body.classList.add("pc-mobile-nav-open");
    };

    mobileToggle.setAttribute("aria-expanded", "false");

    mobileToggle.addEventListener("click", function () {
      var isOpen = mobileNav.classList.contains("open");
      if (isOpen) {
        closeMobileMenu();
      } else {
        openMobileMenu();
      }
    });

    mobileNav.querySelectorAll("a, button").forEach(function (el) {
      el.addEventListener("click", function () {
        closeMobileMenu();
      });
    });

    document.addEventListener("keydown", function (event) {
      if (event.key === "Escape") {
        closeMobileMenu();
      }
    });

    document.addEventListener("click", function (event) {
      if (!mobileNav.classList.contains("open")) return;

      var clickedInsideMenu = mobileNav.contains(event.target);
      var clickedToggle = mobileToggle.contains(event.target);
      if (!clickedInsideMenu && !clickedToggle) {
        closeMobileMenu();
      }
    });

    window.addEventListener("resize", function () {
      if (window.innerWidth > 991) {
        closeMobileMenu();
      }
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
