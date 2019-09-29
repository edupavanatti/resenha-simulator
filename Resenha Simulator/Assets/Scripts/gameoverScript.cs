using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverScript : MonoBehaviour {

    void Update()
    {
        // Teclando Space volta para o Menu
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Menu");
        }
    }

}
