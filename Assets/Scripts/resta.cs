using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resta : MonoBehaviour
{
    // Start is called before the first frame update
	
	public GameObject enemigo, player;
	private Vector2 distancia;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = enemigo.transform.position - player.transform.position;
		Debug.Log("La distancia es: " + distancia);
		Debug.Log("La distancia es: " + distancia.magnitude);
		
		if(distancia.magnitude < 3){
			enemigo.transform.position = Vector2.Lerp(enemigo.transform.position, player.transform.position, 0.01f);
		}
    }
}
