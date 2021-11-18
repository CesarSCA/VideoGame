using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private float afterTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,afterTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
