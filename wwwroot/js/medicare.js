// MediCare Dashboard — JS helpers

// Notification bell toggle (example)
document.querySelectorAll('.notif-btn').forEach(btn => {
    btn.addEventListener('click', () => {
        btn.classList.toggle('active');
    });
});

// Action more-menu placeholder
document.querySelectorAll('.action-more').forEach(btn => {
    btn.addEventListener('click', (e) => {
        e.stopPropagation();
        alert('Actions: Edit / Delete / View Profile');
    });
});
