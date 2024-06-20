// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function toggleDropdown(iconElement) {
    var dropdown = iconElement.nextElementSibling;
    if (dropdown.style.display === "none" || dropdown.style.display === "") {
        dropdown.style.display = "block";
    } else {
        dropdown.style.display = "none";
    }
}

// Optional: Close dropdown when clicking outside
document.addEventListener('click', function (event) {
    var isClickInside = document.querySelector('.textbox-with-icon').contains(event.target);

    if (!isClickInside) {
        var dropdowns = document.querySelectorAll('.dropdown-options');
        dropdowns.forEach(function (dropdown) {
            dropdown.style.display = 'none';
        });
    }
});

