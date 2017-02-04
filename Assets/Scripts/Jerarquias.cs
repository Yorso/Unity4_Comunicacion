using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerarquias : MonoBehaviour {
	//Ejercicio: Ver si un Game Object tiene Game Objects hijos y de tenerlos, que me diga quiénes son
	//Este script estará en el GameObject padre (Padre) y buscaremos sus hijos
	public Transform miTransform;

	// Use this for initialization
	void Start () {
		miTransform = GetComponent<Transform> ();

		for (int i = 0; i < miTransform.childCount; i++) {
			Transform hijoTransform = miTransform.GetChild (i);
			Debug.Log (hijoTransform.gameObject.name);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
