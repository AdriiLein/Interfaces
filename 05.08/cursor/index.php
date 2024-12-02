<?php

// al inicio del fichero ponermos las funciones de php
// se han llevado funciones de js a php

// \t\n para imprimir la hoja html

function pinta($n,$m){ // variables con $
	$cadena="<textarea id='caja'>HOLA</textarea><br/><br/>\n";
	$clase='par'; // ponemos aqui los colores alternos con las clases de la hoja de estilos
	if ($m>16){$n=16;}
	for($i=0;$i<$n;$i++){
		for($j=0;$j<$m;$j++){
			//$z=$i+$j; // suma de enteros 
			$id = "b$i$j"; // reemplazo de variables
			$nombreBoton= "$i$j";
			if ($clase=='par'){$clase='impar';}else{$clase='par';} // alternar clases
			// añadimos class , cambiamos y solo pasamos this
			$cadena.="\t\t<button id='$id' class='$clase' onmouseover='sobre(this)'>$nombreBoton</button>\n";
		}
		$cadena.="\t\t<br/>\n";
	}
	return $cadena;
}
// ahora la pagina html de la anterior version
?>


<!DOCTYPE HTML>
<!-- inicio html estatico -->
<html>
	<head>
		<title>cursor</title>
		<meta charset="UTF-8">
		<link rel="stylesheet" type="text/css" href="estilo.css">
		<script src="script.js"></script> 
	</head>
	<body>
		<?php 
			echo pinta(9,9); // llamada a funcion php , parte dinamica
		?>
		<script>
			// js esta enlazado en script.js
		</script>
	</body>
</html>
