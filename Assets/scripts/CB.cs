using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB : MonoBehaviour
{

    private GameObject ca, cc;
    public Material yellow;

    // Start is called before the first frame update
    void Start()
    {
        ca = GameObject.FindWithTag("tagA");
        cc = GameObject.FindWithTag("tagC");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        cc.GetComponent<Renderer>().material = yellow;
        var x = ca.transform.localScale.x;
        var y = ca.transform.localScale.y;
        ca.transform.localScale = new Vector3(x+(x*.20f), y, 1);
    }
}
