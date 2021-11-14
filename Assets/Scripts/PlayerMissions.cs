using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject missionLight;
    public bool missionComplete = false;
    float timeToComplete = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(missionComplete == false)
        {
            missionLight.GetComponent<Light>().color = new Color(1, 0, 0, 1); 
        } else if(missionComplete == true) 
        {
            missionLight.GetComponent<Light>().color = new Color(0, 1, 0, 1);
        }
    }

    private void OnTriggerStay(Collider other) {

        if(other.gameObject.CompareTag("Player"))
        {
            if(missionComplete == false){
             if(timeToComplete > 0)
              {
              timeToComplete -= Time.deltaTime;
              } 
             else {
              missionComplete = true;
             }
            }
    
        }
    }
}
