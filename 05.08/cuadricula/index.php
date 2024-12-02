<?php
// css dinamico desde php
$tm=1.5;
// declaracion de funciones
function cuadricula($size,$m1,$m2,$m3,$m4){	
	//  $size : numero de columnas
	//  $m1: incremento de rojo
	//  $m2: incremento de verde
	//  $m3: incremento de azul
	// title: formato a 3 digitos rellenando con ceros a la izquierda
	$estilo='style="height:'.$m4.'px;width:'.$m4.'px';	
	for ($a=0;$a<$size;$a++){
		$red=$a*$m1;
		$green=$a*$m2;
		for ($b=0;$b<$size;$b++){	
			$blue=$b*$m3;
			$color="rgb(".$red.",".$green.",".$blue.")";
			echo '<div title=" R'.
			str_pad($red, 3,"0",STR_PAD_LEFT).' G'.
			str_pad($green, 3,"0",STR_PAD_LEFT).' B'.
			str_pad($blue, 3,"0",STR_PAD_LEFT).
			'" '.$estilo.';background:'.$color.'"></div>'."\n";	
		}
		echo '<div style="clear:left"></div>'."\n";
	}
	echo "<br/><br/>";
}
?>
<html>
<head>
	<title>cuadricula</title>	
<style>
div{
	border:0px solid;
	float:left;
}
</style>
</head>
<body>
<?php
	cuadricula(150,2,1,2,2);
	cuadricula(5,10,30,20,16);
	cuadricula(10,1,2,20,16);
?>
</body>
</html>