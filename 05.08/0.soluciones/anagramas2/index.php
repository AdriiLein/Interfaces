<?php
// formulario y procesamiento php 
// se usa $_REQUEST para determinar primera carga

function sonAnagramas($a,$b){
    // con arrays
    $a1=str_split(strtolower(str_replace(" ","",$a)));
    $b1=str_split(strtolower(str_replace(" ","",$b)));
    sort($a1); // $a1 es un array usado por referencia
    sort($b1);
    $a=implode($a1);
    $b=implode($b1);
    //echo "$a2-$b2<br/>"; // comprobacion
    return ($a==$b);
}
?>
<!DOCTYPE html>
<html>
<head>
<title>anagramas2</title>
<meta charset="UTF-8">
<style>
span{
    background-color:#DDD;
}
input{
    padding:6px;
    margin:10px;

}
</style>
</head>
<body>
<?php
if(!$_REQUEST){
// llamada sin parametros retorna el formulario
// action vuelve a llamar a la misma pagina con los parametros
?>
<form action="" method="GET">
palabra 1 <input type="text" name="a"><br>
palabra 2 <input type="text" name="b"><br>
<input type="submit" value='ENVIAR'>
</form>
<?php
    exit;
}else{
// llamada con parametros retorna el calculo del anagrama
    $a = $_REQUEST['a'];
    $b = $_REQUEST['b'];
    
    if ($a=='' and $b==''){
        echo "faltan parametros";
        exit;
    }
    
    if(sonAnagramas($a,$b)){
        echo "<span>-$a- y -$b-</span><b> son </b> anagramas";
    }else{
        echo "<span>-$a- y -$b-</span><b> no son </b> anagramas";
    }
}
?>
<br/>
<br/>
</body>
</html>