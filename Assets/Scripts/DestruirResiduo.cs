using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirResiduo : MonoBehaviour
{
    [SerializeField]
    private string tipo;
    private SoundManager soundManager;

    public GameObject objetoPuntuje;
    public GameObject efectoEstrella;
    void Awake(){
        soundManager = FindObjectOfType<SoundManager>();
    }
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
                    soundManager.SeleccionAudio(0, 0.5f);
                    Instantiate(efectoEstrella, collision.transform.position, collision.transform.rotation);
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
                    Instantiate(efectoEstrella, collision.transform.position, collision.transform.rotation);
                    soundManager.SeleccionAudio(0, 0.5f);
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                    soundManager.SeleccionAudio(1, 0.5f);
                }
                break;
            case "vidrio":
                if (collision.gameObject.CompareTag("Vidrio"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(0,255,0,255);
                    soundManager.SeleccionAudio(0, 0.5f);
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                    soundManager.SeleccionAudio(1, 0.5f);
                }
                break;
            case "metal":
                if (collision.gameObject.CompareTag("Metal"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(0,255,0,255);
                    Instantiate(efectoEstrella, collision.transform.position, collision.transform.rotation);
                    soundManager.SeleccionAudio(0, 0.5f);                    
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }

                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                    soundManager.SeleccionAudio(1, 0.5f);
                }
                break;
            case "papel":
                if (collision.gameObject.CompareTag("Papel"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color = new Color(0,255,0,255);
                    Instantiate(efectoEstrella, collision.transform.position, collision.transform.rotation);
                    soundManager.SeleccionAudio(0, 0.5f);
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                    soundManager.SeleccionAudio(1, 0.5f);                
                }
                break;
            case "suelo":
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 10f;
                    objetoPuntuje.GetComponent<Puntaje>().textoPuntos.color= new Color(255,0,0,255);
                    soundManager.SeleccionAudio(1, 0.5f);

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
