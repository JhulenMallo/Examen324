<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Editar extends CI_Controller {

	public function __construct() {
        parent::__construct();
        $this->load->model("Persona_model");
    }

	public function index()
	{
		$this->load->view('persona/editar');
	}

	public function index2($ci)
	{
		$data=$this->Persona_model->getPerson($ci);
		$this->load->view('persona/editar', $data);
	}

	public function update($id)
	{
		$ci = $this->input->post("ci");
		$nombrecompleto = $this->input->post("nombrecompleto");
		$fechanac = $this->input->post("fechanac");
		$depto = $this->input->post("depto");
		
		$data = array(
			"ci"=>$ci,
			"nombre_completo"=>$nombrecompleto,
			"fecha_nacimiento"=>$fechanac,
			"departamento"=>$depto
		);

		$this->Persona_model->update($data, $id);
		redirect(base_url()."index.php/Main");
	}

}
