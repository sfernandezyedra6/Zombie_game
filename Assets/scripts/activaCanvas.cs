using UnityEngine;
using System.Collections;

public class activaCanvas : MonoBehaviour {
	public GameObject canvas;
	public bool estacerca = false;
	public bool muestratexto = false;
	// Use this for initialization
	void Update () {
		if (estacerca) {
			canvas.SetActive(true);
		}else{
			canvas.SetActive(false);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag == "Player")
		estacerca = true;
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.transform.tag == "Player")
		estacerca = false;
	}	
}

