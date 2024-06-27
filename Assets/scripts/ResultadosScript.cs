using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultadosScript : MonoBehaviour
{
    public GameObject panel;
    public Text botonJugarOtraVez;
    public Text botonSalir;
    public Text txt;
    public ObjetosSpawn objetospawn;
    int total;

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

        total = objetospawn.Izquierda[objetospawn.RI].GetComponent<ObjetoValueScript>().Value + objetospawn.Derecha[objetospawn.RD].GetComponent<ObjetoValueScript>().Value;
        if (total.ToString() == txt.text.ToString())
        {
            panel.SetActive(true);
            txtpanel.text = "Resultado correcto";
            botonJugarOtraVez.text = "Reiniciar desafio";

        }
        if (total.ToString() != txt.text.ToString() && txt.text != "")
        {
            panel.SetActive(true);
            txtpanel.text = "El resultado es incorrecto";
            botonJugarOtraVez.text = "Volver a intentarlo";
        }
    }

    public void JugarOtraVez()
    {
        if (total.ToString() == txt.text.ToString())
        {
            SceneManager.LoadScene("Scene1");
        }
    }
}
