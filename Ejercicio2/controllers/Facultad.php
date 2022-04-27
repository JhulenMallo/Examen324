<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Facultad extends CI_Controller {

	public function index()
	{
        $data['subview'] = 'fcpn';
		$this->load->view('index', $data);      
	}

    public function infox()
	{
        $data['subview'] = 'infox';
		$this->load->view('index', $data);      
	}

	public function mate()
	{
        $data['subview'] = 'mate';
		$this->load->view('index', $data);      
	}

	public function fisica()
	{
        $data['subview'] = 'fisica';
		$this->load->view('index', $data);      
	}
}
