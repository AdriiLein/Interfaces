<?php
// css dinamico desde php
$tm=1.5;
// declaracion de funciones
function cuadricula($size,$m1,$m2,$m3){
	//  $size : numero de columnas
	//  $m1: incremento de rojo
	//  $m2: incremento de verde
	//  $m3: incremento de azul
	//
	for ($a=0;$a<$size;$a++){
		$red=$a*$m1;
		$green=$a*$m2;
		for ($b=0;$b<$size;$b++){	
		$blue=$b*$m3;
		$color="rgb(".$red.",".$green.",".$blue.")";
			echo '<div style="background:'.$color.'"></div>'."\n";
		}
		echo '<br/>'."\n";
	}
}
?>
<html>
<head>
	<title>cuadricula</title>	
<style>
div{
	border:1px solid;
	width:<?php echo $tm?>em;
	height:1em;
	float:left;
}
</style>
</head>
<body>
<?php
	cuadricula(10,10,5,10);
	cuadricula(5,10,30,20);
	cuadricula(20,1,3,20);
?>
</body>
</html>