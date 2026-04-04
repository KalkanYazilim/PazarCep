/* Profil.js */

// Yorumlar Modalını Açma
function openCommentsModal(postId) {
  const modal = document.getElementById("comments-modal");
  modal.style.display = "block";
}

// Yorumlar Modalını Kapatma
function closeCommentsModal() {
  const modal = document.getElementById("comments-modal");
  modal.style.display = "none";
}

// Yorum Ekleme İşlevi
function addComment(postId) {
  const commentInput = document.getElementById("new-comment");
  const comment = commentInput.value.trim();
  if (comment) {
    alert(`Yeni yorum eklendi: ${comment}`);
    commentInput.value = ""; // Girdi temizleniyor
  } else {
    alert("Yorum boş bırakılamaz!");
  }
}

// Beğenme İşlevi
function toggleLike(postId) {
  const likeButton = document.getElementById(`like-btn-${postId}`);
  const likeCount = document.getElementById(`like-count-${postId}`);
  let currentLikes = parseInt(likeCount.textContent);

  if (likeButton.classList.contains("liked")) {
    likeButton.classList.remove("liked");
    likeButton.textContent = "❤️ Beğen";
    likeCount.textContent = `${currentLikes - 1} Beğeni`;
  } else {
    likeButton.classList.add("liked");
    likeButton.textContent = "💔 Beğeni Kaldır";
    likeCount.textContent = `${currentLikes + 1} Beğeni`;
  }
}

// Beğenmeme İşlevi
function toggleDislike(postId) {
  const dislikeButton = document.getElementById(`dislike-btn-${postId}`);
  const dislikeCount = document.getElementById(`dislike-count-${postId}`);
  let currentDislikes = parseInt(dislikeCount.textContent);

  if (dislikeButton.classList.contains("disliked")) {
    dislikeButton.classList.remove("disliked");
    dislikeButton.textContent = "👎 Beğenmeme";
    dislikeCount.textContent = `${currentDislikes - 1} Beğenmeme`;
  } else {
    dislikeButton.classList.add("disliked");
    dislikeButton.textContent = "👍 Beğenmeme Kaldır";
    dislikeCount.textContent = `${currentDislikes + 1} Beğenmeme`;
  }
}
