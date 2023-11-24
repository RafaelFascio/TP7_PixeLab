using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarParticulas : MonoBehaviour
{
    public GameObject efectoEstrella;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Container"))
        {
            Instantiate(efectoEstrella, transform.position, transform.rotation);
        }
    }
}
