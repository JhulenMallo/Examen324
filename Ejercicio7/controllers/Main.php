<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Main extends CI_Controller {

	public function __construct() {
        parent::__construct();
        $this->load->model("Persona_model");
    }

	public function index()
	{
		$data = array("data"=>$this->Persona_model->getPersona());
		$this->load->view('persona/persona', $data);
	}

	public function delete($id)
	{
		$this->Persona_model->delete($id);
		redirect(base_url()."index.php/Main");
	}

}
