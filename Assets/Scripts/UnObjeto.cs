using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnObjeto : MonoBehaviour {
	//Ejercicio: Todos los objetos que tengan el componente Pared, que se almacenen en un array
	public Pared[] arrayDeParedes; 

	// Use this for initialization
	void Start () {
		arrayDeParedes = Object.FindObjectsOfType (typeof(Pared)) as Pared[]; //"as Pared[]" es como se propone que se haga la devolución de los objetos Pared que encuentre
																		      //Encuentra los objetos y los devuelve como un array de Pared (as Pared[])
		Debug.Log (arrayDeParedes.Length);
		Debug.Log (arrayDeParedes.ToString()); //Nos muestra en Unity que es un array de tipo Pared => Pared[]
	}

}
