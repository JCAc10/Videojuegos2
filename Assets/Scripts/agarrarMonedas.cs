using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class agarrarMonedas : MonoBehaviour
{
    public Text puntos;
	public int monedas;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = monedas.ToString();
    }
	
	public void agarrar(){
		monedas += 1;
	}
}
