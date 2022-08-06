using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
public class virtualButtonBehave :  MonoBehaviour
{

    
    public GameObject pannel;
    public Text textObj;
    void Start()
    {
         GameObject  vButton = GameObject.Find("VirtualButton");
         vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
         vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
         pannel.SetActive(false);
    }

   public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        
        Debug.Log("Button pressed");
        pannel.SetActive(true);
        textObj.text = "Akhenaten came to power as the pharaoh of Egypt in either the year 1353 or 1351 BCE and reigned for roughly 17 years during the 18th dynasty of Egypt's New Kingdom. Akhenaten became best known to modern scholars for the new religion he created that centered on the Aten.";

    }
    
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
        pannel.SetActive(false);
    }

   
}
