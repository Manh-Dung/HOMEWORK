<html>
    <body>
        <?php
        $tien;
        $sodien=$_GET["dienmoi"] - $_GET["diencu"];
        if (isset($_GET['submit'])) 
        {

            if($sodien <= 100)
            {
                $tien = $sodien * 2000;
            }
            elseif ($sodien > 100 && $sodien <= 150) {
                $tien = 100 * 2000 + ($sodien - 100) * 2500;
            }
            elseif ($sodien > 150 && $sodien <= 200)
            {
                $tien = 100 * 2000 + 50 * 2500 + ($sodien - 150) * 2800;
            }
            else
            {
                $tien = 100 * 2000 + 50 * 2500 + 50 * 2800 + ($sodien - 200) * 3500;
            }
            echo "Số tiền phải trả là: ".$tien. " đ.";
        }
        ?>
    </body>
</html>