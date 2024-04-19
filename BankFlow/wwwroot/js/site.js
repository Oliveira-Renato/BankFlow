// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {

    var clienteSelect = document.getElementById('clienteSelect');
    clienteSelect.addEventListener('change', function () {
        var selectedOption = this.options[this.selectedIndex];
        var saldo = selectedOption.getAttribute('data-saldo');
        
        document.getElementById('saldoDisponivel').textContent = 'R$ ' + saldo;
    });
});