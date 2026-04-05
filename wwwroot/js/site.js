const navbar = document.querySelector('.navbar');
if (navbar) {
    window.addEventListener('scroll', () => {
        if (window.scrollY > 10) {
            navbar.style.boxShadow = '0 12px 40px rgba(139,26,26,0.16)';
        } else {
            navbar.style.boxShadow = '';
        }
    }, { passive: true });
}
