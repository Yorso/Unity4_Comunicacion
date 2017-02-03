using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica1 : MonoBehaviour {

	//public GameObject gcubo; //Ésto no nos hace falta si ya está este script apuntando (que está este script asignado en el Inspector)a ese GameObject (cubo)

	//Podemos traernos otro Game Object de fuera, que no sea éste mismo... Por ejemplo, la cámara
	public GameObject miCamara; //Hay que poner como nombre a la cámara "miCamara" y se asigna al GameObject (cubo) arrastrando
								//la cámara hasta el Inspector del cubo, donde pone "Mecanica1 Script"

	public GameObject buscoGameObject; //Podemos buscar Game Objects en la escena actual

	public GameObject[] cubos; //Array de Game Objects

	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.name); //Resultado = Cube
		Debug.Log (miCamara.name); //Resultado = miCamara

		buscoGameObject = GameObject.Find ("Esfera"); //Estamos buscando en la escena un Game Object que se llame "Esfera"
													  //Cuando le demos a "Play" en el Inspector, en "Mecanica1 Script", en el apartado "Busco Game Object"
		                                              //asignará automáticamente el Game Object llamado "Esfera"

		cubos = GameObject.FindGameObjectsWithTag ("Player"); //En el Inspector, en el Game Object "Esfera" hay un "Tag", lo seteamos a "Player" y 
															  //creamos "Esfera" varias veces (copy/paste). "FindGameObjectsWithTag ("Player")" lo que hará
															  //será encontrarnos todos los GameObjects con la etiqueta "Player" y los irá almacenando en el array "cubos".
															  //Este resultado se verá en el Game Object "Cube".

		Debug.Log (cubos.Length); //Muestra todas las esferas con la etiqueta "Player" que hay en la escena
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
