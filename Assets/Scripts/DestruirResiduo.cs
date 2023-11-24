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
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                }
                break;
            case "organico":
                if (collision.gameObject.CompareTag("Organico"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                }
                break;
            case "papel":
                if (collision.gameObject.CompareTag("Papel"))
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos += 10f;
                    // Destruye el objeto actual (el residuo)
                    //Destroy(collision.gameObject);
                }
                else
                {
                    objetoPuntuje.GetComponent<Puntaje>().puntos -= 5f;
                }
                break;
            default:
                break;
        }
        Destroy(collision.gameObject);
        /*if (collision.gameObject.CompareTag("Container"))
        {
            // Destruye el objeto actual (el residuo)
            Destroy(gameObject);
        }*/
    }
}
