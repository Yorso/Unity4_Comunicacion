using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	private Transform transform = null;
	public float velocidad;

	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += new Vector3 (0, 0, 1); //Cada frame se le suma 1 a la z == avanza
		//transform.position += new Vector3 (0,0,1 * velocidad); //Aquí velocidad es cero, podemos controlarlo desde el Inspector con el ratón
		transform.position += new Vector3 (0,0,1 * velocidad * Time.deltaTime); //Movemos unidades por segundo => si velocidad = 10 entonces se mueve 10 unidades por segundo
	}
}
