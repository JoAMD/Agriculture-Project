using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlants : MonoBehaviour
{
    public GameObject plant;
    public float nextTime = 0f;
    public Vector3 position = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextTime)
        {
            Instantiate(plant, position, Quaternion.identity, transform);
            nextTime = Time.time + 1f;
        }
    }
}
