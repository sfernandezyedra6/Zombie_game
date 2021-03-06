﻿using UnityEngine;
using System.Collections;

public class teleportScript : MonoBehaviour {
	
	public Transform destino;
	bool delantepuerta = false;
	bool teletransporta = false;
	//public float tiempoEspera = 0.0f; // Tiempo que el Player tiene que estar para cargar
	//bool cargando = false; // Controla si el player esta dentro del trigger
	
	
	void Update (){
		if (Input.GetKeyDown ("up")&& delantepuerta) {
			teletransporta = true;
		}
	}
	
	
	void OnDrawGizmosSelected() {
		if (destino != null) {
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(transform.position,  destino.position);
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D target){
		if (target.transform.tag == "Player")
			delantepuerta = true;
	}
	
	void OnTriggerStay2D(Collider2D target){
		if (teletransporta){
			target.transform.position = destino.position;
			teletransporta = false;
		}	
	}
	
	void OnTriggerExit2D(Collider2D target){
		if (target.transform.tag == "Player") 
			delantepuerta = false;	
	}
}
/*	if (target.transform.tag == "Player") {
			Debug.Log("Entrando");
			if(!cargando) // Si no esta cargando empezamos la cuenta atras
				StartCoroutine(cargaSalto(target));
			
		}
	}
	
	//Si salimos del trigger cortamos la carga
	void OnTriggerExit2D(Collider2D target){
		cargando = false;
	}
	
	// Ejecutamos esto cuando entramos en el trigger
	IEnumerator cargaSalto(Collider2D target) {
		cargando = true;
		Debug.Log("Before Waiting 2 seconds");
		yield return new WaitForSeconds(tiempoEspera); // Esperamos el tiempo definido
		if(cargando) // Si sigue en el trigger cargamos la escena
			target.transform.position = punto1.position;
	}
}

*/