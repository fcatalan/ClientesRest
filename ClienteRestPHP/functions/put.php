<?php
function put_request(){
    //next eample will change status of specific conversation to resolve
    $service_url = 'http://localhost:8080/actualizarUsuario';
    $ch = curl_init($service_url);
     
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "PUT");
    $data = array("status" => 'R');
    curl_setopt($ch, CURLOPT_POSTFIELDS,http_build_query($data));
    $response = curl_exec($ch);
    if ($response === false) {
        $info = curl_getinfo($ch);
        curl_close($ch);
        die('error occured during curl exec. Additioanl info: ' . var_export($info));
    }
    curl_close($ch);
    $decoded = json_decode($response);
    if (isset($decoded->response->status) && $decoded->response->status == 'ERROR') {
        die('error occured: ' . $decoded->response->errormessage);
    }
    echo 'response ok!';
    var_export($decoded->response);   
}
?>
<html>
<head>
    <meta content="text/html;charset=utf-8" http-equiv="Content-Type">
<meta content="utf-8" http-equiv="encoding">
    <title>Cliente Rest-API PHP</title>
</head>
<body>
Resultado del put
<?php put_request(); ?>
</body>
</html>