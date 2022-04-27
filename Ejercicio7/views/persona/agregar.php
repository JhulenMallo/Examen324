<?php   $this->load->view('components/header'); 
 ?>

<body>

    <div class="container">
        <h1 class="mt-5">Nueva Persona</h1>
        <form action="<?php echo base_url('index.php/Agregar/save'); ?>" class="mt-4" method="POST">
            <div class="row">
                <div class="col-lg-6">
                    <div class="form-group">
                        <label for="exampleInputEmail1">CI</label>
                        <input type="text" name="ci" class="form-control" placeholder="Carnet de Identidad">
                        <div class="invalid-feedback">
                        Please choose a username.
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="exampleInputEmail1">Nombre Completo</label>
                        <input type="text" name="nombrecompleto" class="form-control" placeholder="Nombre Completo">
                        <div class="invalid-feedback">
                        Please choose a username.
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Fecha de Nacimiento</label>
                        <input type="text" name="fechanac" class="form-control" placeholder="Año-Mes-Dia 2000-02-31">
                        <div class="invalid-feedback">
                        Please choose a username.
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="exampleInputPassword1">Departamento</label>
                        <input type="text" name="depto" class="form-control" placeholder="00">
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