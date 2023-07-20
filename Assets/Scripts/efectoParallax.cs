using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectoParallax : MonoBehaviour
{
    // Start is called before the first frame update
	
	//[SerializeField] private float parallax;
	private Transform camaraTransform;
	private Vector3 posicionPrevia;
    void Start()
    {
        camaraTransform = Camera.main.transform;
		posicionPrevia = camaraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float posicion = (camaraTransform.position.x - posicionPrevia.x) * 0.5f;
		transform.Translate(new Vector3(posicion, 0, 0));
		posicionPrevia = camaraTransform.position;
    }
}
