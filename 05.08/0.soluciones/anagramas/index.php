<?php

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
    <title>anagramas</title>
			<meta charset="UTF-8">
    <style>
        span{
            background-color:#DDD;
        }
    </style>
</head>
<body>
    <?php
    if(!$_REQUEST){
		echo "faltan parametros en la consulta";
	}else{
        $a = $_REQUEST['a'];
        $b = $_REQUEST['b'];
        if(sonAnagramas($a,$b)){
            echo "<span>$a & $b</span><b> son </b> anagramas";
        }else{
            echo "<span>$a & $b</span><b> no son </b> anagramas";
        }
    }
    ?>
<br/><br/>
<pre>
<b>Actividad</b>
Resolver en php el problema de Alan Smithee descrito en:
<a href="http://www.programa-me.com/documents/ProblemsSets/2015/ProgramaMe-2015-Nacional.pdf">http://www.programa-me.com/documents/ProblemsSets/2015/ProgramaMe-2015-Nacional.pdf</a>
1) una url de llamada puede ser: .../index.php?a=Alan Smithee&b=The Alias Men
2) la respuesta puede ser: ** Alan Smithee & The Alias Men <b>son</b> anagramas
o tambien: ** Alan Smithee & The Alias Men <b>no son</b> anagramas. 
Haz una funcion en php para resolver si es o no anagrama.
2) en la respuesta el color de fondo de las palabras de entrada sera diferente del blanco
y los textos 'son' o 'no son' ira en negrita.

<b>Enunciado, Alan Smithee</b>
Muchos directores de cine que han tenido diferencias artísticas con los productores
o distribuidores de sus películas terminan firmándolas con el seudónimo
Alan Smithee para manifestar su insatisfacción con el resultado.
El nombre no es casualidad; fue acuñado por el sindicato de directores de
Estados Unidos en 1968 precisamente para ese uso, y es un anagrama de The
Alias Men ("los hombres con un alias").
Un anagrama es una palabra o frase que se construye con las mismas letras
que otra. Algunos ejemplos son esponja y japonés, letras y lastre o frase y fresa.
En los libros también hay anagramas famosos. Por ejemplo el antagonista de
Harry Potter se llama Tom Marvolo Riddle del que surge el anagrama I am Lord Voldemort.
Por su parte, en la novela El código Da Vinci aparecen varios anagramas que resultan
ser pistas ocultas para el protagonista.

<b>Entrada</b>
El programa recibirá, por la entrada estándar, un número indicando cuántos casos de prueba vendrán
a continuación. Cada caso de prueba estará compuesto de dos líneas, con dos palabras o frases a analizar.
Ninguna de ellas tendrá más de 1.000 letras y todas tendrán al menos una letra diferente de espacio.

<b>Salida</b>
Para cada caso de prueba el programa escribirá "SI" cuando la primera línea sea un anagrama
de la segunda y "NO" en caso contrario. Para dar la respuesta, no se deberá tener en cuenta el uso
de mayúsculas ni los espacios. Además, por simplicidad, sólo se utilizarán letras del alfabeto inglés
y cualquier palabra se considerará anagrama de sí misma.

<b>Entrada de ejemplo</b>
Alan Smithee - The Alias Men
frase - fresas
esponja - japones
sol - luna
Tom Marvolo Riddle - I am Lord Voldemort

<b>Salida de ejemplo</b>
SI
NO
SI
NO
SI
</pre>
</body>
</html>