/* Global.js */

// Takip Et / Takipten Çık İşlevi
function toggleFollow(userId, isFollowing) {
    if (isFollowing) {
      alert("Takipten Çıkıldı!");
      document.getElementById(`follow-btn-${userId}`).textContent = "Takip Et";
    } else {
      alert("Takip Edildi!");
      document.getElementById(`follow-btn-${userId}`).textContent = "Takipten Çık";
    }
  }
  
  // Gönderiyi Beğen İşlevi
  function toggleLike(postId) {
    const likeButton = document.getElementById(`like-btn-${postId}`);
    if (likeButton.classList.contains("liked")) {
      likeButton.classList.remove("liked");
      likeButton.textContent = "❤️ Beğen";
    } else {
      likeButton.classList.add("liked");
      likeButton.textContent = "💔 Beğeni Kaldır";
    }
  }
  
  // Yorum Yapma İşlevi
  function commentPost(postId) {
    const comment = prompt("Yorumunuzu yazın:");
    if (comment) {
      alert(`Yorum eklendi: ${comment}`);
    }
  }
  
  // Daha Fazla Seçenek İşlevi
  function moreOptions(itemId) {
    alert("Daha fazla seçenek açılıyor...");
  }
  