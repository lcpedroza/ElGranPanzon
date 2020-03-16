$(function () {
    $(".boton-editar-empleado").click(function () {
        var id = $(this).attr("id");
        var empleadoId = id.substr(22);
        console.log("Empleados", empleados);
        for (var empleado of empleados) {
            if (empleado.Id == empleadoId) {
                $("#empleadoId").val(empleado.Id);
                $("#Nombres").val(empleado.Persona.Nombres);
                $("#Apellidos").val(empleado.Persona.Apellidos);
                $("#genero").val(empleado.Persona.GeneroId);
                $("#td").val(empleado.Persona.TipoDocumentoId);
                $("#numDoc").val(empleado.Persona.NumeroDocumento);
                $("#cargo").val(empleado.RolId);
                $("#telefono").val(empleado.Telefono);
                $("#salario").val(empleado.Salario);
                $("#Email").val(empleado.Correo);
                break;
            } 
        }
      
    });
});