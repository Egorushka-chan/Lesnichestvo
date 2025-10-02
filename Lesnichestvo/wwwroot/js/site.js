// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Фильтрация в представлении Dacha
$(function () {
    var $description = $('#dachaDescriptionFilter');
    var debounceTimer = null;

    function filterDachas() {
        var descriptionVal = ($description.val() || '').toString().trim().toLowerCase();

        $('table tbody tr').each(function () {
            var $tr = $(this);

            // Индексы колонок: 0-ID, 1-NetworkID, 2-Description
            var description = ($tr.find('td').eq(2).text() || '').toLowerCase();

            var matchDescription = true;

            if (descriptionVal) {
                matchDescription = description.indexOf(descriptionVal) !== -1;
            }

            if (matchDescription) {
                $tr.show();
            } else {
                $tr.hide();
            }
        });
    }

    // Дебаунс для плавного ввода
    $description.on('input', function () {
        clearTimeout(debounceTimer);
        debounceTimer = setTimeout(filterDachas, 150);
    });
});
