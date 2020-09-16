using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTiro : MonoBehaviour {

    public GameObject projetil;
    public GameObject ponto;

    public float VelocidadeBala;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        if(Input.GetMouseButtonDown(0)) {
            GameObject bala = Instantiate(projetil);
            bala.transform.position = ponto.transform.position;

            bala.GetComponent<Rigidbody>().AddForce(transform.forward * VelocidadeBala, ForceMode.Impulse);
        }
        
    }
}
