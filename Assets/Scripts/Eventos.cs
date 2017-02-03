using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour {
	//Ocurre cuando se levanta el Game Object y va enciendiendo una y otra vez todos los componentes
	void Awake(){
		Debug.Log ("Hola Awake");
	}

	// Use this for initialization. Es el primer frame del juego, ocurre justo después de que Awake() levante todos los componentes y se ejecute OnEnable()
	void Start () {
		Debug.Log ("Hola Start");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Hola Update");
	}

	//Se mete aquí después del Awake y cada vez que tengamos la casilla chequeada del Game Object en el Inspector
	void OnEnable(){
		Debug.Log ("Hola OnEnable");
	}

	//Cada vez que apague el Game Object va a mandar un mensaje (a otros scripts, a consola, a otro Game Object, 
	//a otro componente [mandar un mensaje diciéndole que se desactive, por ejemplo], etc). apagar el Game Object es que ne el
	//Inspector chequeemos o no la casilla para que se vea el Game Object (ejemplo: un cubo) o no
	void OnDisable(){
		Debug.Log ("Hola OnDisable");
	}

	//Eventos del ratón => Envía eventos a través de los Colliders
	void OnMouseDown(){
		Debug.Log ("Hola OnMouseDown");
	}

	void OnMouseEnter(){
		Debug.Log ("Hola OnMouseEnter");
	}

	void OnMouseExit(){
		Debug.Log ("Hola OnMouseExit");
	}

	void OnMouseOver(){
		Debug.Log ("Hola OnMouseOver");
	}

}
