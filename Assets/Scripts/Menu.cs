using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
public void Jugar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

}
public void Intrucciones(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

}
public void Salir(){
    Debug.Log("Salir...");
    Application.Quit();
}
}
