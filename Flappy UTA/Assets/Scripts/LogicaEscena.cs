using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOver;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void perdiste(){
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void reiniciar(){

    }
}
