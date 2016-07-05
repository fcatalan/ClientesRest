<?php 
function delete_request(){
    $service_url = 'http://localhost:8080/eliminarUsuario/'.$_GET['rut'];
    $ch = curl_init($service_url);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "DELETE");
    $curl_post_data = array(
            'rut' => $_GET['rut']
    );
    curl_setopt($curl, CURLOPT_POSTFIELDS, $curl_post_data);
    $response = curl_exec($ch);
    if ($curl_response === false) {
        $info = curl_getinfo($curl);
        curl_close($curl);
        die('error occured during curl exec. Additioanl info: ' . var_export($info));
    }
    curl_close($curl);
    $decoded = json_decode($curl_response);
    if (isset($decoded->response->status) && $decoded->response->status == 'ERROR') {
        die('error occured: ' . $decoded->response->errormessage);
    }
    echo 'response ok!';
    var_export($decoded->response);
}
delete_request(); 
?>
<html>
<head>
    <meta content="text/html;charset=utf-8" http-equiv="Content-Type">
<meta content="utf-8" http-equiv="encoding">
    <title>Cliente Rest-API PHP</title>
</head>
<body>
Rut <?php echo $_GET['rut']; ?> Eliminado
<a href="http://localhost/Cliente_PHP/">Volver</button>
</body>
</html>