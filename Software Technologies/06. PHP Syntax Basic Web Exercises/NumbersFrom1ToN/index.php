<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <title>Numbers-from-1-to-N</title>
    </head>
    <body>
        <form>
            N: <input type="text" name="num" />
            <input type="submit" />
        </form>
        <?php
            if (isset($_GET['num'])) {
                $n = intval($_GET['num']);

                for ($i = 1; $i <= $n; $i++) {
                    echo $i . " ";
                }
            }
        ?>
    </body>
</html>