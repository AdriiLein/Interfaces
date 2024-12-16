<?php 

//volcado parametros
var_dump($_REQUEST);

// recepcion de parametros
$a='12';
if (isset($_REQUEST['a'])and $_REQUEST['a']!='')  { $a=$_REQUEST['a']; }
$b='red';
if (isset($_REQUEST['b']) and $_REQUEST['b']!='') { $b=$_REQUEST['b']; }
$c='5';
if (isset($_REQUEST['c']) and $_REQUEST['c']!='') { $c=$_REQUEST['c']; }
$btn='0';
if (isset($_REQUEST['btn']) and $_REQUEST['btn']!='') { $btn=$_REQUEST['btn']; }

// main: que página cargar según el botón pulsado
if ($btn == '0' or $btn == 'volver'){
		$div1='block';$div2='none';
}
if ($btn == 'enviar'){
		$div1='none';$div2='block';
}

// variables para los estilos
$celda=30;
$mrg=3;
$cont=($celda+2*$mrg)*($a);

?>

<!DOCTYPE html>

<head>
		<title>phpGo2</title>
</head>
<html>
<style>
	input {
		display:block;margin:20px
	}
	#formulario {
		display:<?php echo $div1;?>
	}
	#tablero {
		display:<?php echo $div2;?>
	}
	#tabla{
		display:flex;
		width:<?php echo $cont;?>px;
		height:<?php echo $cont;?>px;
		flex-wrap:wrap;
	}
	#tabla>div{
		width:<?php echo $celda;?>px;
		height:<?php echo $celda;?>px;
		margin:<?php echo $mrg;?>px;
		background-color:<?php echo $b;?>;
		border-radius:<?php echo $c;?>px;
	}	
</style>

<body>

<div id='formulario'>
<h1>Completa los datos y pulsa enviar</h1>
<form method='get'>
	<input type='box' name='a' placeholder='celdas ?' />
	<input type='box' name='b' placeholder='color ?' />
	<input type='box' name='c' placeholder='radio ?' />	
	<input type='submit' name='btn' value='enviar' />
</form>
</div>

<div id='tablero'>
<form method='get'>
	<input type='submit' name='btn' value='volver' />
</form>	
<?php
echo "datos recibidos : celdas=$a, color=$b, radio=$c";
echo "<br/><br/>";
echo  "<div id='tabla'>";
$xx=1;
for ($i = 1; $i <= $a; $i++) {
    for ($j = 1; $j <= $a; $j++) {
		echo "<div>$xx</div>";
		$xx++;
	}
}
echo "</div>";

?>



</div>

</body>

</html>
