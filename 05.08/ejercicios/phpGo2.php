<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tablero con PHP</title>
    <style>
        #formulario{
            display: flex;
            flex-direction: column;
            justify-content: left;
            width: 30%;
            margin: 20px;
            gap: 20px;
        }
        #tablero{
            display: <?php echo "none"; ?>;
        }
    </style>
</head>
<body>
    <?php
        var_dump($_POST);
        isset($_REQUEST['a']) ? $a=$_POST['a'] : $a=12;
        isset($_REQUEST['b']) ? $b=$_POST['b'] : $b="red";
        isset($_REQUEST['c']) ? $c=$_POST['c'] : $c=10;

        $mostrarTablero = isset($_POST['btn']) && $_POST['btn'] === 'enviar';
        if(!$mostrarTablero){
            echo "";
        }else{
            echo "<style>#tablero{display:block;}</style>";
            echo "<style>#datos{display:none;}</style>";
        }
    ?>
    <div id="datos">
    <h1>Completa los datos y pulsa enviar</h1>
    <form id="formulario" method="post">
        <input type="box" name="a" placeholder="celdas ?"/>
        <input type="box" name="b" placeholder="color ?"/>
        <input type="box" name="c" placeholder="radio ?"/>
        <input type="submit" name="btn" value="enviar">
    </form>
    </div>

    <div id="tablero">
        <form method="post">
            <input type="submit" name="btn" value="volver">
        </form>

        <?php
            echo "datos recibidos: celda=$a color=$b radio=$c";
            echo "<br>";
        ?>
    </div>
</body>
</html>
