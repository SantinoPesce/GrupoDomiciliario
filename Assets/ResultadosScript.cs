using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultadosScript : MonoBehaviour
{
    public GameObject panel;
    public InputField txt;


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
        }
       
    }
}
