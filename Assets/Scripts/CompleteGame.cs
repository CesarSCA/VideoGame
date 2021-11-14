using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteGame : MonoBehaviour
{
    // Start is called before the first frame update

        public GameObject[] MISIONES;
        bool[] miss = new bool[5];
        [SerializeField] GameObject puerta;
        [SerializeField] float velocidad = 0.5f;

    void Start()
    {
        miss[0] = false;
        miss[1] = false;
        miss[2] = false;
        miss[3] = false;
    }

    // Update is called once per frame
    void Update()
    {   
        completar();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < 4; i++)
            {
                Debug.Log(miss[i]);
            }
        }
        if(miss[0] == true && miss[1] == true && miss[2] == true && miss[3] == true)
        {
            openDoor();
        }
    }

    void completar()
    {
        for (int i = 0; i < 4; i++)
        {
            bool mission = MISIONES[i].GetComponent<PlayerMissions>().missionComplete;

            if(mission == true){
                miss[i] = true;
            }
        }

    }
    void openDoor()
    {
        if(puerta.transform.position.magnitude > 3.3f)
        {
            return;
        }
        puerta.transform.Translate(velocidad * Time.deltaTime * new Vector3(0, 1, 0));
    }
}
