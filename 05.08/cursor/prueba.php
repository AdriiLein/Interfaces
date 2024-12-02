<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <script>
        for (let i = 0; i < 9; i++) {
            for (let j = 0; j < 9; j++) {
                var ele = document.createElement('div');
                ele.style.width = '100px';
                ele.style.height = '100px';
                ele.style.border = '1px solid black';
                ele.style.margin = '50px';
                ele.style.position = 'absolute';
                ele.style.left = i * 50 + 'px';
                ele.style.top = j * 50 + 'px';
                ele.innerHTML = j + '' +  i;
                document.body.appendChild(ele);
            }
        }
    </script>
</body>
</html>