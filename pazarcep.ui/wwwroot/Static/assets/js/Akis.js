/* Akis.js */

// Hikaye Görüntüleme İşlevi
function viewStory(storyId) {
    alert(`Hikaye ${storyId} görüntüleniyor!`);
}

// Beğenme İşlevi
function toggleLike(postId) {
    const button = document.getElementById(`like-btn-${postId}`);
    const likeCount = document.getElementById(`like-count-${postId}`);
    let currentLikes = parseInt(likeCount.textContent);

    if (button.classList.contains("liked")) {
        button.classList.remove("liked");
        button.textContent = "❤️ Beğen";
        likeCount.textContent = `${currentLikes - 1} Beğeni`;
    } else {
        button.classList.add("liked");
        button.textContent = "💔 Beğeni Kaldır";
        likeCount.textContent = `${currentLikes + 1} Beğeni`;
    }
}

// Yorum Yapma İşlevi
function commentPost(postId) {
    const comment = prompt("Yorumunuzu yazın:");
    if (comment) {
        alert(`Gönderi ${postId} için yorum eklendi: ${comment}`);
    }
}

// Daha Fazla Seçenek İşlevi
function moreOptions(postId) {
    alert(`Gönderi ${postId} için daha fazla seçenek açıldı.`);
}
