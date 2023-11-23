using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBehaviour : MonoBehaviour
{
    public GameObject[] prefabsResiduos;
    private Transform puntoGeneracion;
    public float tiempoEspera = 5f;
    // Start is called before the first frame update
    void Start()
    {
        puntoGeneracion = transform;

        StartCoroutine(GenerarResiduos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GenerarResiduos()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempoEspera);

            // Selecciona aleatoriamente un prefab de residuo
            GameObject residuoAleatorio = prefabsResiduos[Random.Range(0, prefabsResiduos.Length)];

            // Instancia el residuo en la posición del generador
            Instantiate(residuoAleatorio, puntoGeneracion.position, Quaternion.identity);
        }
    }
}
