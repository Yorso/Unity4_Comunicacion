using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiComponente : MonoBehaviour {
	
	public Transform transformCamara; //Acepta Transform de la cámara

	//Creamos un Box Collider y accedemos a él así
	public BoxCollider miCollider;

	// Use this for initialization
	void Start () {
		miCollider = GetComponent<BoxCollider>(); //Le tenemos que decir el tipo de collider que hemos añadido (es un Box Collider)
		miCollider.enabled = false; //Hace que desaparezca el collider cuando le demos a "Play" (nos deschequea el check en el apartado
		                            //BoxCollider de "GameObject"

		Debug.Log(gameObject.transform.position.x); //Nos saca la posición (en este caso x) del Game Object en cuestión
		Debug.Log(transformCamara.position.x); //Nos saca la posición (en este caso x) de la cámara (asignarla en el Inspector a 
		                                       //"Mi Componente" en el Game Object llamado "GameObject" que hemos creado vacío)
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
