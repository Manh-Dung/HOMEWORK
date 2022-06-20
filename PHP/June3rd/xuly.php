<html>
    <body>
        <?php
            if (isset($_POST['submitUser'])){
                echo "Welcome ".$_POST["fname"]."!<br/>";
                echo "You are ".$_POST["age"]." years old.";
            }
        ?>
    </body>
</html>