﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(".btnDelete").click(function () {
        var currentBtn = $(this);
        if (confirm("Do you want to delete this student")) {
            $.ajax({
                url: "/Students/Delete?id=" + currentBtn.attr("id"),
                method: "Delete",
                success: function () {
                    $(".alert-success").text("Delete success");
                    currentBtn.closest("tbody>tr").remove();
                },
                error: function () {
                    $(".alert-danger").text("Delete Fail")
                }
            })
        }
    });
})