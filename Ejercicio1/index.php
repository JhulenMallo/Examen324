
<!-- Cabecera -->
<?php 
    include "cabecera.inc.php";
?>

<!-- Cuerpo -->
        <link href="styles.css" rel="stylesheet" />
    </head>
    <body>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" href="#!">FCPN</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item"><a class="nav-link active" aria-current="page" href="informatica/index.php">Informática</a></li>
                        <li class="nav-item"><a class="nav-link" href="matematica/index.php">Matemática</a></li>
                        <li class="nav-item"><a class="nav-link" href="fisica/index.php">Física</a></li>
                    </ul>
                </div>
            </div>
        </nav>

        <header class="py-5 bg-image-full" style="background-image: url('imagenes/fcpn1280.jpg')">
            <div class="text-center my-5">
                <img class="img-fluid rounded-circle mb-4" src="imagenes/fcpn.png" alt="..." />
                <h1 class="text-white fs-3 fw-bolder">Facultad de Ciencias Puras y Naturales</h1>
                <p class="text-white-50 mb-0">UMSA</p>
            </div>
        </header>

        <section class="py-5">
            <div class="container my-5">
                <div class="row justify-content-center">
                    <div class="col-lg-6">
                        <h2>Facultad de Ciencias Puras y Naturales</h2>
                        <p class="lead">A single, lightweight helper class allows you to add engaging, full width background images to sections of your page.</p>
                        <p class="mb-0">The universe is almost 14 billion years old, and, wow! Life had no problem starting here on Earth! I think it would be inexcusably egocentric of us to suggest that we're alone in the universe.</p>
                    </div>
                </div>
            </div>
        </section>

<!-- Footer-->
<?php 
    include "footer.inc.php";
?>