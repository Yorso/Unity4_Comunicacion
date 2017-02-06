using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energia : MonoBehaviour {

	//OJO: El atributo IsTrigger de Energia (en el Inspector) debe estar checado y el Player debe tener un Rigibody con Use Gravity no checkado para que todo esto funcione
	void OnTriggerEnter(Collider other){//Evento que se lanza en cuanto entra en contacto Jugador con Energia
		//Destroy (other.gameObject);

		Debug.Log (other.name);//Sacamos por consola el nombre del Game Object (Jugador) que entra en contarcto con Energia
		if(other.GetComponent<Jugador>() != null){//Le estamos diciendo que si el Game Object que entra en contacto con Energia tiene 
												  //el componente Jugador (tiene asociado el C#Script "Jugador"), entonces que desaparezca Energía
			Destroy (this.gameObject); //Cuando este Game Object (Energía) entre en contacto con otro Game Object, Energía desaparecerá (se destruye)
		}
	}

	void OnTriggerStay(Collider other){//Evento que se lanza mientras Jugador está en contacto con  Energia
		if(other.GetComponent<Jugador>() != null){
			Debug.Log (other.name);//Sacamos por consola el nombre del Game Object (Jugador) que entra en contarcto con Energia
		}
	}

	void OnTriggerExit(Collider other){//Evento que se lanza cuando Jugador deja de estar en contacto con Energia
		if(other.GetComponent<Jugador>() != null){
			Debug.Log (other.name);//Sacamos por consola el nombre del Game Object (Jugador) que entra en contarcto con Energia
		}
	}
}
