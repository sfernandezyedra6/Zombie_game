﻿using UnityEngine;
using System.Collections;

public class gameControl : MonoBehaviour {
	public string nombreNivel;

	public void salir(){
		Application.Quit ();
			
	}
	
	public void jugar (){
		Application.LoadLevel (nombreNivel);
	}
}