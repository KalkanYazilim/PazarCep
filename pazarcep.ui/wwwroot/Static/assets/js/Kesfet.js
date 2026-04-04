/* Keşfet.js */

// Beğenme İşlevi
function toggleLike(postId) {
    alert(`Gönderi (${postId}) beğenildi!`);
  }
  
  // Kaydetme İşlevi
  function toggleSave(postId) {
    alert(`Gönderi (${postId}) kaydedildi!`);
  }
  
  // Paylaşma İşlevi
  function sharePost(postId) {
    alert(`Gönderi (${postId}) paylaşıldı!`);
  }
  
  // Yorum Modalını Açma
  function openComments(postId) {
    const modal = document.getElementById("comments-modal");
    modal.style.display = "block";
  }
  
  // Yorum Modalını Kapatma
  function closeCommentsModal() {
    const modal = document.getElementById("comments-modal");
    modal.style.display = "none";
  }
  
  // Yorum Ekleme
  function addComment(postId) {
    const commentInput = document.getElementById("new-comment");
    const comment = commentInput.value.trim();
    if (comment) {
      alert(`Gönderi (${postId}) için yorum eklendi: ${comment}`);
      commentInput.value = ""; // Input temizle
    } else {
      alert("Yorum boş bırakılamaz!");
    }
  }
  
  // Daha Fazla Seçenek
  function moreOptions(postId) {
    alert(`Gönderi (${postId}) için diğer seçenekler açıldı.`);
  }
  