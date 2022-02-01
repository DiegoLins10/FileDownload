
// Função que chama o dowload quando clickado
(function () {
    $(document).ready(function () {
        $(":button").click(function () {
            window.open('https://localhost:5001/api/download', '_blank')
        });
    });
})();