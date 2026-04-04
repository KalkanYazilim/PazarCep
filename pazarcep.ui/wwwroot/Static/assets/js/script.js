document.addEventListener("DOMContentLoaded", () => {
    // Header Yükleme
    fetch("/Partials/Header&Footer.html") // Header dosyasının doğru yolunu kontrol edin
        .then(response => response.text())
        .then(data => {
            const tempDiv = document.createElement("div");
            tempDiv.innerHTML = data;
            
            // Sadece <nav> etiketini bul
            const navBar = tempDiv.querySelector("Header");
            if (navBar) {
                document.body.insertBefore(navBar, document.body.firstChild); // Nav'ı body'nin başına ekle
            } else {
                console.error("Nav etiketi bulunamadı.");
            }
        })
        .catch(error => console.error("Header yükleme hatası:", error));

    // Footer Yükleme
    fetch("/Partials/Header&Footer.html")
        .then(response => response.text())
        .then(data => {
            const tempDiv = document.createElement("div");
            tempDiv.innerHTML = data;
            const footer = tempDiv.querySelector("footer");
            if (footer) {
                document.body.appendChild(footer); // Footer'ı body'nin sonuna ekle
            } else {
                console.error("Footer bulunamadı.");
            }
        })
        .catch(error => console.error("Footer yükleme hatası:", error));
});
// Sayfa Yüklendiğinde Çalışan Genel İşlevler
document.addEventListener('DOMContentLoaded', function () {
  console.log('Sayfa başarıyla yüklendi!');

  // Dropdown Menü Animasyonu
  const dropdowns = document.querySelectorAll('.dropdown-toggle');
  dropdowns.forEach(dropdown => {
    dropdown.addEventListener('click', function () {
      const menu = this.nextElementSibling;
      if (menu) {
        menu.classList.toggle('show');
      }
    });
  });

  // Form Doğrulama
  const forms = document.querySelectorAll('.needs-validation');
  forms.forEach(form => {
    form.addEventListener('submit', function (event) {
      if (!form.checkValidity()) {
        event.preventDefault();
        event.stopPropagation();
      }
      form.classList.add('was-validated');
    });
  });

  // Modalları Otomatik Kapatma
  const modals = document.querySelectorAll('.modal');
  modals.forEach(modal => {
    modal.addEventListener('hidden.bs.modal', function () {
      const form = modal.querySelector('form');
      if (form) {
        form.reset();
        form.classList.remove('was-validated');
      }
    });
  });
});

// Navbar Aktif Link Güncelleme
const navbarLinks = document.querySelectorAll('.navbar .nav-link');
navbarLinks.forEach(link => {
  if (link.href === window.location.href) {
    link.classList.add('active');
  }
});

// Toast Mesajı Gösterme
function showToast(message, type = 'success') {
  const toastContainer = document.getElementById('toast-container');
  if (toastContainer) {
    const toast = document.createElement('div');
    toast.className = `toast toast-${type}`;
    toast.textContent = message;
    toastContainer.appendChild(toast);

    setTimeout(() => {
      toast.remove();
    }, 3000);
  }
}

// Genel Modal İşlevleri
function openModal(modalId) {
  const modal = document.getElementById(modalId);
  if (modal) {
    const modalInstance = new bootstrap.Modal(modal);
    modalInstance.show();
  }
}

function closeModal(modalId) {
  const modal = document.getElementById(modalId);
  if (modal) {
    const modalInstance = bootstrap.Modal.getInstance(modal);
    modalInstance.hide();
  }
}

// Sayfa Kaydırma İşlevi
function scrollToSection(sectionId) {
  const section = document.getElementById(sectionId);
  if (section) {
    section.scrollIntoView({ behavior: 'smooth' });
  }
}
