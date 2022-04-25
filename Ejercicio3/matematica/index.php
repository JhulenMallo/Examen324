
<!-- Cabecera -->
<?php 
    include "../header.inc.php";
    require_once "../conexion.inc.php";
    session_start();
?>

<!-- Cuerpo -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" href="../index2.php">FCPN</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item"><a class="nav-link" aria-current="page" href="../informatica/index.php">Informática</a></li>
                        <li class="nav-item"><a class="nav-link active" href="#!">Matemática</a></li>
                        <li class="nav-item"><a class="nav-link" href="../fisica/index.php">Física</a></li>
                    </ul>
                </div>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item"><a class="nav-link disabled">Bienvenido <?php echo $_SESSION["idusuario"] ?></a></li>
                        <li class="nav-item"><a class="nav-link " aria-current="page" href="../cerrarsesion.php">Cerrar Sesion</a></li>
                    </ul>
                </div>
            </div>
        </nav>

        <header class="py-5 bg-image-full" style="background-image: url('../imagenes/mate1280.jpg')">
            <div class="text-center my-5">
                <img class="img-fluid rounded-circle mb-4" src="../imagenes/mate.png" alt="..." />
                <h1 class="text-white fs-3 fw-bolder">Carrera de Matemática</h1>
                <p class="text-white-50 mb-0">UMSA</p>
            </div>
        </header>

        <section class="py-5">
            <div class="container my-5">
                <div class="row justify-content-center">
                    <div class="col-lg-6">
                        <h2>Carrera de Matemática</h2>
                        <p class="lead">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Voluptas porro cumque dolorum enim beatae obcaecati explicabo odit sapiente corrupti ipsum? Iure beatae soluta deserunt illum magni perspiciatis dolorum vero quisquam.</p>
                    </div>
                </div>
            </div>
        </section>

<!-- Footer-->
<?php 
    include "../footer.inc.php";
?>