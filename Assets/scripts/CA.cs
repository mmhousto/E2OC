using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA : MonoBehaviour
{

    public GameObject cb, cc;
    public Material orange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        cc.GetComponent<Renderer>().material = orange;
        cb.transform.Rotate(Vector3.up * 180 * Time.deltaTime);
        cb.transform.Rotate(Vector3.up * 180 * Time.deltaTime);
    }
}
