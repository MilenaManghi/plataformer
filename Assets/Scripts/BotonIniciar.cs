using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonIniciar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void botonEmpezar()
    {
        Time.timeScale = 1;
        GameManager.nivel = +1;
        SceneManager.LoadScene(GameManager.nivel);
    }
}
