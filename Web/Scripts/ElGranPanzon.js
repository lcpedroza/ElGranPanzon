$(function () {
    $(".boton-editar-empleado").click(function () {
        var id = $(this).attr("id");
        var empleadoId = id.substr(22);
        $("#Nombres").val("Nombres del " + empleadoId);
        console.log("Empleados", empleados);
        // console.log("Nombre del empleado: ", empleados[0].nombres);
    });
});