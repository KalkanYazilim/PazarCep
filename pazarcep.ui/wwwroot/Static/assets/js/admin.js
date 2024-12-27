// Sayfa Yüklendiğinde Çalışan İşlevler
document.addEventListener('DOMContentLoaded', function () {
    console.log('Admin Paneli Yüklendi!');
  
    // Sidebar Aç/Kapat
    const sidebarToggle = document.getElementById('sidebarCollapse');
    const sidebar = document.getElementById('sidebar');
    if (sidebarToggle && sidebar) {
      sidebarToggle.addEventListener('click', function () {
        sidebar.classList.toggle('active');
      });
    }
  
    // DataTables Başlatma
    const tables = ['#kullaniciTablosu', '#hizmetTablosu', '#ilanTablosu'];
    tables.forEach(selector => {
      const table = document.querySelector(selector);
      if (table) {
        $(table).DataTable();
      }
    });
  
    // Chart.js Grafikler
    initializeCharts();
  });
  
  // Grafik Başlatma
  function initializeCharts() {
    const dashboardChartCtx = document.getElementById('kullaniciGrafik');
    if (dashboardChartCtx) {
      new Chart(dashboardChartCtx, {
        type: 'line',
        data: {
          labels: ['Ocak', 'Şubat', 'Mart', 'Nisan', 'Mayıs', 'Haziran'],
          datasets: [{
            label: 'Yeni Kullanıcılar',
            data: [50, 75, 60, 100, 125, 200],
            backgroundColor: 'rgba(54, 162, 235, 0.2)',
            borderColor: 'rgba(54, 162, 235, 1)',
            borderWidth: 1,
          }]
        },
        options: {
          responsive: true,
          plugins: {
            legend: {
              position: 'top',
            },
          },
          scales: {
            y: {
              beginAtZero: true,
            },
          },
        }
      });
    }
  
    const reportChartCtx = document.getElementById('raporGrafik');
    if (reportChartCtx) {
      new Chart(reportChartCtx, {
        type: 'bar',
        data: {
          labels: ['Kullanıcılar', 'Hizmetler', 'İlanlar', 'Randevular'],
          datasets: [{
            label: 'Toplamlar',
            data: [1234, 567, 89, 45],
            backgroundColor: [
              'rgba(255, 99, 132, 0.2)',
              'rgba(54, 162, 235, 0.2)',
              'rgba(255, 206, 86, 0.2)',
              'rgba(75, 192, 192, 0.2)'
            ],
            borderColor: [
              'rgba(255, 99, 132, 1)',
              'rgba(54, 162, 235, 1)',
              'rgba(255, 206, 86, 1)',
              'rgba(75, 192, 192, 1)'
            ],
            borderWidth: 1,
          }]
        },
        options: {
          responsive: true,
          plugins: {
            legend: {
              position: 'top',
            },
          },
          scales: {
            y: {
              beginAtZero: true,
            },
          },
        }
      });
    }
  }
  
  // Kullanıcı Silme İşlevi
  function kullaniciSil(id) {
    if (confirm('Bu kullanıcıyı silmek istediğinize emin misiniz?')) {
      alert(`Kullanıcı başarıyla silindi. ID: ${id}`);
      // Backend entegrasyonu ile kullanıcı silme işlemini burada gerçekleştirebilirsiniz.
    }
  }
  
  // Hizmet Silme İşlevi
  function hizmetSil(id) {
    if (confirm('Bu hizmeti silmek istediğinize emin misiniz?')) {
      alert(`Hizmet başarıyla silindi. ID: ${id}`);
      // Backend entegrasyonu ile hizmet silme işlemini burada gerçekleştirebilirsiniz.
    }
  }
  
  // İlan Silme İşlevi
  function ilanSil(id) {
    if (confirm('Bu ilanı silmek istediğinize emin misiniz?')) {
      alert(`İlan başarıyla silindi. ID: ${id}`);
      // Backend entegrasyonu ile ilan silme işlemini burada gerçekleştirebilirsiniz.
    }
  }
  