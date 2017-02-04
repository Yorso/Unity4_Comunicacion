using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformaciones : MonoBehaviour {

	//Creamos una referencia del componente Transform (optimización)
	//1º Acceso a un Game Object de manera local
	private Transform thisTransform = null; //Si hacemos aquí la asignación (private Transform thisTransform = GetComponent<Transform>();) 
	                                        //puede dar error porque el componente aún puede no estar cargado, por eso lo hacemos en el Start

	//2º Acceso a un Game Object de manera externa
	public GameObject otroGO;
	Transform transformOtroGo;

	// Use this for initialization
	void Start () {
		//1º Acceso a un Game Object de manera local
		thisTransform = GetComponent<Transform>();//Aquí ya podemos hacer la asignación, nos hemos asegurado al estar ya en Start que el componente ya está cargado
		thisTransform.position = new Vector3(2, 2, 2); //Pone el GameObject en la posición 2,2,2

		//2º Acceso a un Game Object de manera externa
		otroGO = GameObject.Find ("CuboRojo");
		transformOtroGo = otroGO.GetComponent<Transform>();
		transformOtroGo.position = new Vector3 (-2,-2,-2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
