<?php
function get_request(){

    if(!function_exists('curl_init')){
        die('Cant find CURL module');
    }
    $service_url = 'http://localhost:8080/usuarios';
    $curl = curl_init();
    curl_setopt($curl, CURLOPT_URL, $service_url);
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
    $curl_response = curl_exec($curl);
    curl_close($curl);
    var_dump($curl_response);
    return $curl_response;
}
get_request();
?>
<html>
<head>
    <meta content="text/html;charset=utf-8" http-equiv="Content-Type">
<meta content="utf-8" http-equiv="encoding">
    <title>Cliente Rest-API PHP</title>
</head>
<body>
Resultado del get 
<?php get_request(); ?>
</body>
</html>

