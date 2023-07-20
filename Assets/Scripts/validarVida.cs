using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validarVida : MonoBehaviour
{
    // Start is called before the first frame update
	public Text totalvidas;
	public int vidas = 3;
	public GameObject vida1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalvidas.text = vidas.ToString();
    }
	
	public void aumentarVidas(){
		vidas += 1;
	}
	
	public void reducirVidas(){
		vidas -= 1;
	}
	
	private void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag=="enemigo"){
			reducirVidas();
			validarVidas();
			if (vidas ==0){
				Destroy(gameObject); // <- Destruye al personaje si sus vidas son igual a 0
			}
		}
		
		if(other.gameObject.tag=="semilla"){
			aumentarVidas();
			//Destroy(gameObject); // <- Destruye la manzana
		}
	}
	
	public void validarVidas(){
		if(vidas == 2){
			vida1.gameObject.SetActive(false);
		}
	}
}
