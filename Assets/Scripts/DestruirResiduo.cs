using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirResiduo : MonoBehaviour
{
    [SerializeField]
    private string tipo;

    public GameObject objetoPuntuje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (tipo)
        {
            case "plastico":
                if (collision.gameObject.CompareTag("Plastico"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;

                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(0,255,0,255);
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                }
                break;
            case "vidrio":
                if (collision.gameObject.CompareTag("Vidrio"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(0,255,0,255);
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                }
                break;
            case "metal":
                if (collision.gameObject.CompareTag("Metal"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(0,255,0,255);                    
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }

                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                }
                break;
            case "papel":
                if (collision.gameObject.CompareTag("Papel"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(0,255,0,255);
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                }
                break;
            case "suelo":
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                break;
            default:
                break;
                
        }
        Destroy(collision.gameObject);
        Invoke("cambioColor",0.3f);
    }
    private void cambioColor(){
        objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(255,255,255,255);   

    }
}
