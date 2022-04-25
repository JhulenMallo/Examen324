<!-- Cabecera -->
<?php 
    include "cabecera.inc.php";
    require_once "conexion.inc.php";
    session_start();
    $query = mysqli_query($con, "SELECT * FROM persona WHERE ci=".$_SESSION["ciusuario"]);
    $datos = mysqli_fetch_array($query);
?>

<!-- Cuerpo -->
<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" href="index2.php">FCPN</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item"><a class="nav-link" aria-current="page" href="informatica/index.php">Informática</a></li>
                        <li class="nav-item"><a class="nav-link" href="matematica/index.php">Matemática</a></li>
                        <li class="nav-item"><a class="nav-link" href="fisica/index.php">Física</a></li>
                        
                    </ul>
                </div>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item"><a class="nav-link disabled">Bienvenido <?php echo $_SESSION["idusuario"] ?></a></li>
                        <li class="nav-item"><a class="nav-link active" href="notas.php">Ver Notas</a></li>
                        <li class="nav-item"><a class="nav-link " aria-current="page" href="cerrarsesion.php">Cerrar Sesion</a></li>
                        
                    </ul>
                </div>
                
            </div>
        </nav>

        <header class="py-5 bg-image-full" style="background-image: url('imagenes/fcpn1280.jpg')">
            <div class="text-center my-5">
                <h1 class="text-white fs-1 fw-bolder">NOTAS</h1>
            </div>
        </header>

        <?php 
            $query = mysqli_query($con, "SELECT * FROM persona WHERE ci=".$_SESSION["ciusuario"]);
            $datos = mysqli_fetch_array($query);

            $sql="SELECT * FROM inscripcion WHERE ciestudiante=".$_SESSION["ciusuario"];
	        $notas=mysqli_query($con, $sql);

            if($_SESSION["ciusuario"]!=777)
            {
                ?>
                <section class="py-5">
                    <div class="container my-5">
                        <div class="row justify-content-center">
                            <div class="col-lg-6">
                                <h4>Notas del estudiante:  <?php echo $datos['nombre_completo'] ?> </h4>
                            <table class="table">
                                <thead>
                                    <tr>
                                    <th scope="col">Sigla</th>
                                    <th scope="col">Nota 1</th>
                                    <th scope="col">Nota 2</th>
                                    <th scope="col">Nota 3</th>
                                    <th scope="col">Nota Final</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                    <?php
                                        while($fila=mysqli_fetch_array($notas)) {
                                            echo "<tr>";
                                            echo "<td>".$fila['sigla']."</td>";
                                            echo "<td>".$fila['nota1']."</td>";
                                            echo "<td>".$fila['nota2']."</td>";
                                            echo "<td>".$fila['nota3']."</td>";
                                            echo "<td>".$fila['notafinal']."</td>";
                                            echo "</tr>";
                                        }
                                    ?>
                                </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </section>
               <?php
            }
        ?>


        

        
<!-- Footer-->
<?php 
    include "footer.inc.php";
?>