using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VolverMenu : MonoBehaviour
{
   public void Volver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

}
}
