<html>
<head>
    <meta content="text/html;charset=utf-8" http-equiv="Content-Type">
<meta content="utf-8" http-equiv="encoding">
    <title>Cliente Rest-API PHP</title>
</head>
<script src="js/jquery.min.js"></script>
<script>
    $(document).ready(function(){
        $('#div-agregar').hide();
        $('#div-eliminar').hide();
        $('#div-modificar').hide();

        $('#agregar').click(function(){

            $('#div-eliminar').hide();
            $('#div-modificar').hide();
            $('#div-agregar').show();
        });
        

        $('#ver').click(function(){

            $('#div-eliminar').hide();
            $('#div-modificar').hide();
            $('#div-agregar').hide();
        });
        

        $('#eliminar').click(function(){

            $('#div-eliminar').show();
            $('#div-modificar').hide();
            $('#div-agregar').hide();
        });
        

        $('#modificar').click(function(){

            $('#div-eliminar').hide();
            $('#div-modificar').show();
            $('#div-agregar').hide();
        });
        
        $('#ver').click(function(){
            var nombre = $('#nombre').val();
            window.location.href = 'functions/get.php';
        });
        $('#delete').click(function(){
            var rut = $('#rut').val();
            window.location.href = 'functions/delete.php?rut='+rut;
        });
        $('#post').click(function(){
            var email =$('.email').val();
            var rut= $('.rut').val();
            var apellidoP= $('.apellidoP').val();
            var apellidoM= $('.apellidoM').val();
            window.location.href = 'functions/post.php';
        });
    });
</script>
<body>
Indique el tipo de acción que desea ejecutar
<button id="ver">Ver</button>
<button id="agregar">Agregar</button>
<button id="eliminar">Eliminar</button>
<button id="modificar">Modificar</button>


<div id="div-agregar">
    <h3>Agregar Nuevo Registro</h3>
    <label>email</label><input class="email" />
    <label>rut</label><input class="rut" />
    <label>Apellido Materno</label><input class="apellidoP" />
    <label>Apellido Paterno</label><input class="apellidoM" />
    <button id="post">Agregar Datos</button>
</div>
<div id="div-eliminar">
    <h3>Eliminar Registro</h3>
    <label>RUT</label><input id="rut" />
    <button id="delete">Eliminar</button>
</div>

<div id="div-modificar">
    <h3>Modificar Registro</h3>
    <button id="put">Modificar</button>
</div>
</body>
</html>