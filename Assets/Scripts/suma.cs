using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suma : MonoBehaviour
{
    // Start is called before the first frame update
	
	public GameObject obj1, obj2, obj3;
	private Vector2 sumar;
	//private prueba=1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sumar = obj1.transform.position + obj2.transform.position;
		Debug.Log("La suma es: " + sumar);
		obj3.transform.position = sumar;
    }
}
