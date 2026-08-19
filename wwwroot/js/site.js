document.addEventListener("DOMContentLoaded", function () {
    const scrollElements = document.querySelectorAll(".scroll-animate");

    const elementInView = (el, dividend = 1) => {
        const elementTop = el.getBoundingClientRect().top;
        return (
            elementTop <= (window.innerHeight || document.documentElement.clientHeight) / dividend
        );
    };

    const displayScrollElement = (element) => {
        element.classList.add("animated-in");
    };

    const handleScrollAnimation = () => {
        scrollElements.forEach((el) => {
            if (elementInView(el, 1.15)) {
                displayScrollElement(el);
            }
        });
    };

    window.addEventListener("scroll", () => {
        handleScrollAnimation();
    });

    setTimeout(handleScrollAnimation, 150);

    const currentPath = window.location.pathname;
    const navLinks = document.querySelectorAll('.navbar-premium .nav-item a');

    navLinks.forEach(link => {
        const href = link.getAttribute('href');
        if (currentPath === href || (currentPath === '/' && href === '/Home/Index')) {
            link.parentElement.classList.add('active');
        }
    });

    //=====================SCROLL TO TOP=====================
    $(function () {
        const $scrollTopBtn = $('#scrollTopBtn');

        $(window).on('scroll', function () {
            if ($(this).scrollTop() > 300) {
                $scrollTopBtn.fadeIn();
            } else {
                $scrollTopBtn.fadeOut();
            }
        });

        $scrollTopBtn.on('click', function (e) {
            e.preventDefault();
            $('html, body').animate({ scrollTop: 0 }, 400);
        });
    });
    //=====================END=====================

    //=====================GALLERY PAGE=====================
    $(function () {
        $('.filter-pill').on('click', function () {
            $('.filter-pill').removeClass('active');
            $(this).addClass('active');

            var selectedCategory = $(this).attr('data-filter');

            if (selectedCategory === 'all') {
                $('.gallery-item').fadeIn();
            } else {
                $('.gallery-item').hide();
                $('.gallery-item[data-category="' + selectedCategory + '"]').fadeIn();
            }
        });

        $('.gallery-card').on('click', function () {
            var targetSrc = $(this).find('img').attr('src');
            var targetAlt = $(this).find('img').attr('alt');
            $('#modalViewportTargetImage').attr('src', targetSrc).attr('alt', targetAlt);
            var myModal = new bootstrap.Modal(document.getElementById('galleryViewComponentModal'));
            myModal.show();
        });
    });
    //=====================END=====================
});

function adjustMainOffset() {
    const navbar = document.querySelector('nav') || document.querySelector('.navbar');
    const mainContent = document.getElementById('main-content');

    if (navbar && mainContent) {
        const navHeight = navbar.offsetHeight;
        mainContent.style.paddingTop = navHeight + 'px';
    }
}
window.addEventListener('DOMContentLoaded', adjustMainOffset);
window.addEventListener('resize', adjustMainOffset);