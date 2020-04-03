$(function () {
    var filaTablaEditar = null;

    //Botón de la tabla que abre el modal de editar empleado
    $(".boton-editar-empleado").click(function () {
        filaTablaEditar = $(this).closest("tr");
        console.log("La filas son", filaTablaEditar);
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

    $("#Boton-EditarEmpleado").click(function (e) {
        var IdEmpleado = $("#empleadoId").val();
        var empleado = {
            EmpleadoId: IdEmpleado,
            Nombres: $("#Nombres").val(),
            Apellidos: $("#Apellidos").val(),
            GeneroId: $("#genero").val(),
            TiposdeDocumentoId: $("#td").val(),
            numeroDocumento: $("#numDoc").val(),
            RolId: $("#cargo").val(),
            telefono: $("#telefono").val(),
            salario: $("#salario").val(),
            correo: $("#Email").val(),
            clave: $("#clave").val()
        };

        $.ajax("/api/empleados/" + IdEmpleado, {
            method: "PUT",
            data: empleado
        }).done(function (resp) {
            alert("Respuesta: " + resp);
            $("#modaEditarEmpleado").modal('hide');
            var columnas = filaTablaEditar.children();
            console.log("Las columnas son", columnas);
            columnas[0].textContent = empleado.Nombres;
            columnas[1].textContent = empleado.Apellidos;
            columnas[2].textContent = empleado.TiposdeDocumentoId;
            columnas[3].textContent = empleado.numeroDocumento;
            columnas[4].textContent = empleado.GeneroId;
            columnas[5].textContent = empleado.RolId;
            columnas[6].textContent = empleado.telefono;
            columnas[7].textContent = empleado.correo;


        }).fail(function (error) {
            console.log("Error al editar", error);
            alert("Error: " + error);
        });
    });
});