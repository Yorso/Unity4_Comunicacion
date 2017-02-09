using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour {

	public GameObject[] cubos;

	// Use this for initialization
	void Start () {
		cubos = GameObject.FindGameObjectsWithTag ("Player"); //Buscar Game Objects por string como en este caso es más costoso que buscarlo por tipo de Game Object.
		                                                      //Pero para el ejemplo nos vale. No olvides de poner el Tag de los cubos como "Player" en el Inspector
		//Llamada a  la corrutina. La corrutina corre en paralelo al Update
		StartCoroutine(DesactivarCubos());
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Hola en el Update");
	}

	//Ésta es la corrutina. La corrutina corre en paralelo al Update
	IEnumerator DesactivarCubos(){
		yield return new WaitForSeconds (2.5f);//A los 2.5 segundos apaga el cubo 0
		cubos[0].SetActive(false);

		yield return new WaitForSeconds (2.5f);//A los 2.5 segundos apaga el cubo 1
		cubos[1].SetActive(false);

		yield return new WaitForSeconds (2.5f);//A los 2.5 segundos apaga el cubo 2
		cubos[2].SetActive(false);
	}
}
