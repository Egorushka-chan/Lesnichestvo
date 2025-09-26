// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Фильтрация в представлении Customers
$(function () { 
    var $nameType = $('#customerNameTypeFilter');
    var $status = $('#customerStatusFilter');
    var debounceTimer = null;

    function filterCustomers() {
        var nameVal = ($nameType.val() || '').toString().trim().toLowerCase();
        var statusVal = ($status.val() || '').toString().trim().toLowerCase();

        $('table tbody tr').each(function () {
            var $tr = $(this);

            // Индексы колонок: 0-ID, 1-Имя, 2-ИНН, 3-Тип компании, 4-Дата, 5-Статус
            var name = ($tr.find('td').eq(1).text() || '').toLowerCase();
            var companyType = ($tr.find('td').eq(3).text() || '').toLowerCase();
            var status = ($tr.find('td').eq(5).text() || '').toLowerCase();

            var matchNameType = true;
            var matchStatus = true;

            if (nameVal) {
                matchNameType = name.indexOf(nameVal) !== -1 || companyType.indexOf(nameVal) !== -1;
            }

            if (statusVal) {
                matchStatus = status.indexOf(statusVal) !== -1;
            }

            if (matchNameType && matchStatus) {
                $tr.show();
            } else {
                $tr.hide();
            }
        });
    }

    // Дебаунс для плавного ввода
    $nameType.on('input', function () {
        clearTimeout(debounceTimer);
        debounceTimer = setTimeout(filterCustomers, 150);
    });

    $status.on('input', function () {
        clearTimeout(debounceTimer);
        debounceTimer = setTimeout(filterCustomers, 150);
    });
});

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
