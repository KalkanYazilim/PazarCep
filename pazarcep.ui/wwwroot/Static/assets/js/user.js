// Sayfa Yüklendiğinde Çalışan İşlevler
document.addEventListener('DOMContentLoaded', function () {
    console.log('Kullanıcı Paneli Yüklendi!');
  
    // Randevu Takvimi Başlatma
    initializeCalendar();
  
    // İlan Ekleme/Düzenleme Modalları
    const ilanModals = document.querySelectorAll('.ilan-modal');
    ilanModals.forEach(modal => {
      modal.addEventListener('hidden.bs.modal', function () {
        const form = modal.querySelector('form');
        if (form) {
          form.reset();
        }
      });
    });
  
    // Sepet İşlevleri
    initializeCartFunctions();
  });
  
  // Takvim Başlatma
  function initializeCalendar() {
    const calendarEl = document.getElementById('takvim');
    if (calendarEl) {
      const calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth',
        locale: 'tr',
        headerToolbar: {
          left: 'prev,next today',
          center: 'title',
          right: 'dayGridMonth,timeGridWeek,timeGridDay'
        },
        events: [
          // Örnek etkinlikler
          {
            title: 'Domates Teslimi',
            start: '2024-01-10',
            end: '2024-01-11'
          },
          {
            title: 'Kiraz Hasadı',
            start: '2024-01-15'
          }
        ],
        dateClick: function (info) {
          alert(`Tarih seçildi: ${info.dateStr}`);
          // Tarih seçimi sonrası ek işlevler buraya eklenebilir.
        }
      });
      calendar.render();
    }
  }
  
  // Sepet İşlevleri
  function initializeCartFunctions() {
    const removeButtons = document.querySelectorAll('.btn-remove');
    removeButtons.forEach(button => {
      button.addEventListener('click', function () {
        const cartItem = this.closest('.cart-item');
        if (cartItem) {
          cartItem.remove();
          updateCartTotal();
        }
      });
    });
  }
  
  // Sepet Toplamını Güncelle
  function updateCartTotal() {
    const cartItems = document.querySelectorAll('.cart-item');
    let total = 0;
  
    cartItems.forEach(item => {
      const priceElement = item.querySelector('.item-price');
      if (priceElement) {
        const price = parseFloat(priceElement.textContent.replace('₺', ''));
        total += price;
      }
    });
  
    const totalElement = document.querySelector('.cart-total');
    if (totalElement) {
      totalElement.textContent = `Toplam: ₺${total.toFixed(2)}`;
    }
  }
  
  // İlan İşlevleri
  function ilanEkle(event) {
    event.preventDefault();
    const ilanForm = document.getElementById('ilanForm');
    if (ilanForm) {
      const ilanTitle = ilanForm.querySelector('#ilanTitle').value;
      const ilanDescription = ilanForm.querySelector('#ilanDescription').value;
  
      alert(`Yeni ilan eklendi: ${ilanTitle}\n${ilanDescription}`);
      // Backend entegrasyonu burada yapılmalıdır.
  
      // Form sıfırlama ve modal kapatma
      ilanForm.reset();
      const modal = bootstrap.Modal.getInstance(document.getElementById('ilanEkleModal'));
      modal.hide();
    }
  }
  
  function ilanSil(id) {
    if (confirm('Bu ilanı silmek istediğinize emin misiniz?')) {
      alert(`İlan başarıyla silindi. ID: ${id}`);
      // Backend entegrasyonu ile ilan silme işlemini burada gerçekleştirebilirsiniz.
    }
  }
  