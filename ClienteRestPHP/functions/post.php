<?php
function post_request(){
    //next example will insert new conversation
    $service_url = 'http://localhost:8080/agregarUsuario';
    $curl = curl_init($service_url);

    $curl_post_data = array(
            'email'=>$_POST['email'],
            'pass'=>$_POST['pass'],
            'rut'=>$_POST['rut'],
            'apellidoP'=>$_POST['apellidoP'],
            'apellidoM'=>$_POST['apellidoM']

    );
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($curl, CURLOPT_POST, true);
    curl_setopt($curl, CURLOPT_POSTFIELDS, $curl_post_data);
    $curl_response = curl_exec($curl);
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
post_request();
?>
<html>
<head>
    <meta content="text/html;charset=utf-8" http-equiv="Content-Type">
<meta content="utf-8" http-equiv="encoding">
    <title>Cliente Rest-API PHP</title>
</head>
<body>
</body>
</html>