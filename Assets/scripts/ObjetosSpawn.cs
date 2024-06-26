using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosSpawn : MonoBehaviour
{
    public GameObject[] Derecha;
    public GameObject[] Izquierda;
    int RD;
    int RI;
    // Start is called before the first frame update
    void Start()
    {
    RI = Random.Range(0, Izquierda.Length);
    RD = Random.Range(0, Derecha.Length);
        Valores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Valores()
    {
        Derecha[RD].SetActive(true);
        Izquierda[RI].SetActive(true);
    }
}
