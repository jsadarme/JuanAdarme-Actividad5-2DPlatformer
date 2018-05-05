using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character : MonoBehaviour {

	//Declaro la velocidad desde el inicio y en ve del numero, coloco speed
	public float speed = 0.1f;

	//puntaje
	int coins = 0;
	public Text contadorCoins;

	int hearts = 3;
	public Text contadorHearts;

	int stars = 0;
	public Text contadorStars;
	 
	// Use this for initialization
	void Start () {
		
	}
	//Esta función es invocada cuando el ollider agregado a este gamObject to otro collider
	void OnCollisionEnter2D(Collision2D coll) {


		if (coll.collider.gameObject.tag == "coins") {
			//aumentar la cantidad de monedas que tiene el personaje
			coins = coins + 1;
			contadorCoins.text = coins.ToString ();
			Destroy (coll.collider.gameObject);

		}

		if (coll.collider.gameObject.tag == "hearts") {
			//aumentar la cantidad de monedas que tiene el personaje
			hearts = hearts + 1;
			contadorHearts.text = hearts.ToString ();
			Destroy (coll.collider.gameObject);
		}

		if (coll.collider.gameObject.tag == "stars") {
			//aumentar la cantidad de monedas que tiene el personaje
			stars = stars + 1;
			contadorStars.text = stars.ToString ();
			Destroy (coll.collider.gameObject);
		
		}
		if (coll.collider.gameObject.tag == "enemies") {
			//aumentar la cantidad de monedas que tiene el personaje
			hearts = hearts - 1;
			contadorHearts.text = hearts.ToString ();
			Destroy (coll.collider.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		//
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (speed, 0, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.Translate (-speed, 0, 0);

		}
		//Salto
		//Si la tecla Barra Espaciadora es presionada
		if(Input.GetKeyDown(KeyCode.Space)) {

			//Le agrego una fuerza hacia arriba

			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 5, ForceMode2D.Impulse);
	}
}
}
