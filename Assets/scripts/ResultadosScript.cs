using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultadosScript : MonoBehaviour
{
    public GameObject panel;
    public Text txt;
    public ObjetosSpawn objetospawn;

    public Text txtpanel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void botonpresionado()
    {
      if (txt.text == "")
        {
            panel.SetActive(true);
            txtpanel.text = "Debes ingresar un resultado";

        }
       
     int total = objetospawn.Izquierda[objetospawn.RI].GetComponent<ObjetoValueScript>().Value + objetospawn.Derecha[objetospawn.RD].GetComponent<ObjetoValueScript>().Value;
        if (total.ToString() == txt.text.ToString())
        {
            panel.SetActive(true);
            txtpanel.text = "Resultado correcto";

        }
        if (total.ToString() != txt.text.ToString() && txt.text != "") 
        {
            panel.SetActive(true);
            txtpanel.text = "El resultado es incorrecto";
        }
    }
    public void panelsinresultado()
    {
        panel.SetActive(false);
    }
}
