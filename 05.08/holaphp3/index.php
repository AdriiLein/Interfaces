<!DOCTYPE html>
<html>
<head>
	<title>holaphp3</title>
	<style>
	button{cursor:cell;}
	</style>
</head>
<style>
 button{
 	color: red;
 }
</style>

<body>

cinco botones rojos dentro de &lt;a&gt; dentro de una &lt;table&gt;
<?php echo "<br/><br/>\n"; ?>

<table style='width:100%'>
<tr>
<?php

// combinacion de comillas, otros recursos ficheros de texto
// abrir inspector > red > envio > recepcion
// html entities
// salto de linea php \n

for ($i=0;$i<5;$i++){
$indice=$i+1;
$name="hola$indice.txt";
echo "<td><a href='$name'><button>hola$indice.txt</button></a></td>\n";
}
?>
</tr>
</table>

</body>
</html>
