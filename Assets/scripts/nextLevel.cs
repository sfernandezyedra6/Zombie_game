using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {

	public string nombreNivel = "escena_02";

	public bool cargando = false;

	public float tiempoEspera = 2f;

	void OnTriggerStay2D(Collider2D target){
		if (target.transform.tag == "Player") {
			//Application.LoadLevel (nombreNivel);
			if(!cargando)
				StartCoroutine(cargaNivel());

		}
	}
void OnTriggerExit2D(Collider2D target){
	cargando = false;
}


IEnumerator cargaNivel(){
	cargando = true;
		Debug.Log ("Esperando");
	yield return new WaitForSeconds (tiempoEspera);
	if(cargando)
		Application.LoadLevel (nombreNivel);
    }
}