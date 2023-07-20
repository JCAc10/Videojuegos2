using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag=="personaje"){  // <- Se debe establecer un tag en el personaje
			other.gameObject.GetComponent<agarrarMonedas>().agarrar();
			Destroy(gameObject);
		}
	}
}
