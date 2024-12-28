/* Mesajlar.js */

// Mesaj Detayı Açma
function openMessage(messageId) {
    const chatContent = document.getElementById("chat-content");
    const chatUsername = document.getElementById("chat-username");
  
    if (messageId === 1) {
      chatUsername.textContent = "Ali Veli";
      chatContent.innerHTML = `
        <div class="chat-message sender">
          <p>Merhaba! Ürünleriniz harika görünüyor.</p>
        </div>
        <div class="chat-message receiver">
          <p>Teşekkür ederim! Daha fazla bilgi almak ister misiniz?</p>
        </div>
      `;
    } else if (messageId === 2) {
      chatUsername.textContent = "Ayşe Çelik";
      chatContent.innerHTML = `
        <div class="chat-message sender">
          <p>Cevizlerin fiyatı nedir?</p>
        </div>
        <div class="chat-message receiver">
          <p>Kilosu 50 TL'dir. Daha fazla bilgi almak ister misiniz?</p>
        </div>
      `;
    }
  }
  
  // Yeni Mesaj Başlatma
  function startNewMessage() {
    alert("Yeni mesaj başlatma ekranına yönlendiriliyorsunuz.");
  }
  
  // Mesaj Gönderme
  function sendMessage() {
    const newMessage = document.getElementById("new-message").value.trim();
    if (newMessage) {
      const chatContent = document.getElementById("chat-content");
      const newMessageHTML = `
        <div class="chat-message sender">
          <p>${newMessage}</p>
        </div>
      `;
      chatContent.innerHTML += newMessageHTML;
      document.getElementById("new-message").value = ""; // Girdi temizle
    } else {
      alert("Mesaj boş olamaz!");
    }
  }
  