<html>
    <body>
        <?php
        if (isset($_GET['submitUser'])){
                echo "Welcome ".$_GET["fname"]."!<br/>";
                echo "You are ".$_GET["age"]." years old.";
            }
        ?>
    </body>
</html>