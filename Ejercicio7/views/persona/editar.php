<?php   $this->load->view('components/header'); 
 ?>

<body>

    <div class="container">
        <h1 class="mt-5">Editar Persona: <?php echo $nombre_completo; ?></h1>
        <form action="<?php echo base_url(); ?>index.php/Editar/update/<?php echo $ci; ?>" class="mt-4" method="POST">
            <div class="row">
                <div class="col-lg-6">
                    <div class="form-group">
                        <label for="exampleInputEmail1">CI</label>
                        <input type="text" name="ci" class="form-control" placeholder="Carnet de Identidad" value="<?php echo $ci; ?>">
                        <div class="invalid-feedback">
                        Please choose a username.
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="exampleInputEmail1">Nombre Completo</label>
                        <input type="text" name="nombrecompleto" class="form-control" placeholder="Nombre Completo" value="<?php echo $nombre_completo; ?>">
                        <div class="invalid-feedback">
                        Please choose a username.
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Fecha de Nacimiento</label>
                        <input type="text" name="fechanac" class="form-control" placeholder="Año-Mes-Dia 2000-02-31" value="<?php echo $fecha_nacimiento; ?>">
                        <div class="invalid-feedback">
                        Please choose a username.
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="exampleInputPassword1">Departamento</label>
                        <input type="text" name="depto" class="form-control" placeholder="00" value="<?php echo $departamento; ?>">
                        <div class="invalid-feedback">
                        Please choose a username.
                        </div>
                    </div>
                </div>

                <div class="col-lg-12">
                    <button type="submit" class="btn btn-primary">Guardar</button>
                </div>
            </div>
        </form>
    </div>

    <?php   $this->load->view('components/footer'); 
 ?>