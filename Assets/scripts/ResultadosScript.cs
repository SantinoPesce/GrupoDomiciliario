using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultadosScript : MonoBehaviour
{
    public GameObject panelNotificaciones;
    public GameObject panelError;
    public Text botonJugarOtraVez;
    public Text botonSalir;
    public Text txt;
    public ObjetosSpawn objetospawn;
    int total;

    public Text txtpanel;
    public Text txtpanelError;

    // Start is called before the first frame update
    void Start()
    {
        panelNotificaciones.SetActive(false);
        panelError.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void botonpresionado()
    {
        if (txt.text == "")
        {
            panelError.SetActive(true);
        }

        total = objetospawn.Izquierda[objetospawn.RI].GetComponent<ObjetoValueScript>().Value + objetospawn.Derecha[objetospawn.RD].GetComponent<ObjetoValueScript>().Value;
        if (total.ToString() == txt.text.ToString())
        {
            panelNotificaciones.SetActive(true);
            txtpanel.text = "Resultado correcto";
            botonJugarOtraVez.text = "Reiniciar desafio";

        }
        if (total.ToString() != txt.text.ToString() && txt.text != "")
        {
            panelNotificaciones.SetActive(true);
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
        if (total.ToString() != txt.text.ToString() && txt.text != "")
        {
            panelNotificaciones.SetActive(false);
        }
    }

    public void Salir()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }

    public void BotonError()
    {
        panelError.SetActive(false);
    }
}
