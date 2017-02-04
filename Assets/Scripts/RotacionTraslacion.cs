using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTraslacion : MonoBehaviour {

	private Transform transform = null;
	public float velocidad;
	public float velocidadRotacion;

	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.forward * velocidad * Time.deltaTime);//Se despalza en el plano, parece igual que transform.position
		//transform.Rotate (Vector3.up * velocidadRotacion * Time.deltaTime);//El Game Object hace círculos
		transform.Translate (Vector3.forward * -velocidad * Time.deltaTime);
		transform.Rotate (-Vector3.up * velocidadRotacion * Time.deltaTime);
	}
}
