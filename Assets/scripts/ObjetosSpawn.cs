using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosSpawn : MonoBehaviour
{
    public GameObject[] Derecha;
    public GameObject[] Izquierda;
    public int RD;
    public int RI;

    public Text txtDerecha;
    public Text txtIzquierda;

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
        txtDerecha.text = "$ " + Derecha[RD].GetComponent<ObjetoValueScript>().Value;
        txtIzquierda.text = "$ " + Izquierda[RI].GetComponent<ObjetoValueScript>().Value;
    }
    public void Valores()
    {
        Derecha[RD].SetActive(true);
        Izquierda[RI].SetActive(true);
    }
}
