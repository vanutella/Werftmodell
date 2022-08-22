using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;
//using System.IO.Ports; //Um den SerialPort anzusprechen

public class CubeTriggerScript : MonoBehaviour {
    public GameObject Station1;
    public GameObject Station2;
    public GameObject Station3;
    public GameObject Station4;
    public GameObject Station5;
    public GameObject Station6;
    public string SerialCom;
    SerialPort sp;


    // Use this for initialization
    void Start () {
        sp = new SerialPort(SerialCom, 9600);
        sp.Open();
        sp.ReadTimeout = 1;
        Station1.SetActive(false);
        Station2.SetActive(false);
        Station3.SetActive(false);
        Station4.SetActive(false);
        Station5.SetActive(false);
        Station6.SetActive(false);

      
    }
	
	// Update is called once per frame
	void Update () {
        if (sp.IsOpen)
        {
            try
            {
                doWhatArduinoSaid(sp.ReadLine());
                print(sp.ReadLine());
            }
            catch (System.Exception)
            {

            }
        }



        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1 was pressed");
            Station1.SetActive(true);
            Station2.SetActive(false);
            Station3.SetActive(false);
            Station4.SetActive(false);
            Station5.SetActive(false);
            Station6.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("2 was pressed");
            Station2.SetActive(true);
            Station1.SetActive(false);
            Station3.SetActive(false);
            Station4.SetActive(false);
            Station5.SetActive(false);
            Station6.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("3 was pressed");
            Station3.SetActive(true);
            Station1.SetActive(false);
            Station2.SetActive(false);
            Station4.SetActive(false);
            Station5.SetActive(false);
            Station6.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("4 was pressed");
            Station4.SetActive(true);
            Station1.SetActive(false);
            Station2.SetActive(false);
            Station3.SetActive(false);
            Station5.SetActive(false);
            Station6.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log("5 was pressed");
            Station5.SetActive(true);
            Station1.SetActive(false);
            Station2.SetActive(false);
            Station3.SetActive(false);
            Station4.SetActive(false);
            Station6.SetActive(false);
              
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Debug.Log("6 was pressed");
            Station6.SetActive(true);
            Station1.SetActive(false);
            Station2.SetActive(false);
            Station3.SetActive(false);
            Station4.SetActive(false);
            Station5.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Station6.SetActive(false);
            Station1.SetActive(false);
            Station2.SetActive(false);
            Station3.SetActive(false);
            Station4.SetActive(false);
            Station5.SetActive(false);


        }
	}

    void doWhatArduinoSaid(string ArduinoOrder)
    {
        if (ArduinoOrder == "KEY1")
        {
            Debug.Log("Key 1 was pressed.");
            Station1.SetActive(true);
            Station2.SetActive(false);
            Station3.SetActive(false);
            Station4.SetActive(false);
            Station5.SetActive(false);
            Station6.SetActive(false);
        }

        if (ArduinoOrder == "KEY2")
        {
            Debug.Log("Key 2 was pressed.");
            Station1.SetActive(false);
            Station2.SetActive(true);
            Station3.SetActive(false);
            Station4.SetActive(false);
            Station5.SetActive(false);
            Station6.SetActive(false);
        }
    }
}
