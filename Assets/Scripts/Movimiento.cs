using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
	// DISPARO
	public Transform PuntoDisparo;
	public GameObject Bala;
	//
	[SerializeField] float velocidad = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
		transform.Translate(
			horizontal*velocidad*Time.deltaTime, 0, 0
		);
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(Bala, PuntoDisparo.position, Quaternion.identity);
		}
    }
	
	private void OnTriggerEnter2D(Collider2D collision){
		Debug.Log("Choque");
		GetComponent<SpriteRenderer>().color = Color.yellow; // Goku cambia de color con el choque
	}
}
