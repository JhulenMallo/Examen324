<?php   $this->load->view('components/header'); 
 ?>

<body>
<div class="container">

        <h1 class="mt-5">Tabla de Personas</h1>
        <div class="text-right">
        <a href="<?php echo base_url('index.php/Agregar') ?>" class="btn btn-info"><ion-icon name="add"></ion-icon>Agregar Persona</a> 
        </div>
        <table class="table mt-4">
            <thead class="thead-light">
                <tr>
                <th scope="col">Ci</th>
                <th scope="col">Nombre completo</th>
                <th scope="col">Fecha de Nacimiento</th>
                <th scope="col">Departamento</th>
                </tr>
            </thead>
            <tbody>

                <?php foreach($data as $key => $value): ?>
                    <tr>
                        <th scope="row"><?php echo $value->ci; ?></th>
                        <td><?php echo $value->nombre_completo; ?></td>
                        <td><?php echo $value->fecha_nacimiento; ?></td>
                        <td><?php echo $value->departamento; ?></td>
                        <td>
                            <a href="<?php echo base_url(); ?>index.php/Editar/index2/<?php echo $value->ci; ?>" class="btn btn-primary fs-5"><ion-icon name="pencil"></ion-icon></a> 
                            <a href="<?php echo base_url(); ?>index.php/Main/delete/<?php echo $value->ci; ?>" class="btn btn-danger fs-5"><ion-icon name="trash"></ion-icon></a>
                        </td>
                    </tr>
                <?php endforeach; ?>

            </tbody>
        </table>
    </div>

    <?php   $this->load->view('components/footer'); 
 ?>