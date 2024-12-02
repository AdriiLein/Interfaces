<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pick a Color</title>
    <style>
        .color-grid {
            display: grid;
            grid-template-columns: repeat(128, 2px);
        }
        .color-box {
            width: 2px;
            height: 2px;
            display: inline-block;
        }
    </style>
</head>
<body>

    <div class="color-grid">
        <?php
        function createColorGrid($r, $g, $b) {
            for ($i = 0; $i <= 255; $i += 2) { 
                for ($j = 0; $j <= 255; $j += 2) { 
                    $color = sprintf("rgb(%d, %d, %d)", $r ? $r : $i, $g ? $g : $j, $b);
                    echo "<div class='color-box' style='background-color: $color;' title='$color'></div>";
                }
            }            
        }

        $r = isset($_GET['r']) ? intval($_GET['r']) : 0;
        $g = isset($_GET['g']) ? intval($_GET['g']) : 0;
        $b = isset($_GET['b']) ? intval($_GET['b']) : 0;

        createColorGrid($r, $g, $b);
        ?>
    </div>
</body>
</html>
