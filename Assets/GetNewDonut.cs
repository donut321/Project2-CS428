using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNewDonut : MonoBehaviour
{
    public GameObject donut;
    public GameObject currentDonut;
    public bool created;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        x = currentDonut.transform.position.x;
        y = currentDonut.transform.position.y;
        z = currentDonut.transform.position.z;
        created = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentDonut.transform.position.x < 0f && !created)
        {
            // Instantiate new object and assign it to this current script
            currentDonut = Instantiate(donut, new Vector3(x, y, z), Quaternion.identity);
            created = true;
        }
    }
}
