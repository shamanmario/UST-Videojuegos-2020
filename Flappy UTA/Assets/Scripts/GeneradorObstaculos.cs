using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    public float tiempoMax = 1;
    private float tiempoInicial = 0;

    public float altura = 3;
    public GameObject tuberias;
    void Start()
    {
        GameObject tuberiaNueva = Instantiate(tuberias);
        tuberiaNueva.transform.position = transform.position + new Vector3(0,0,0);
        Destroy(tuberiaNueva, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempoInicial > tiempoMax){
            GameObject tuberiaNueva = Instantiate(tuberias);
            tuberiaNueva.transform.position = transform.position + new Vector3(0,Random.Range(-altura, altura),0);
            Destroy(tuberiaNueva, 5);
            tiempoInicial = 0;
        } else {
            tiempoInicial += Time.deltaTime;
        }
    }
}
