using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC : MonoBehaviour
{
    private GameObject ca, cb;

    // Start is called before the first frame update
    void Start()
    {
        ca = GameObject.Find("CA");
        cb = GameObject.Find("CB");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        var x = ca.transform.localScale.x;
        var y = ca.transform.localScale.y;
        ca.transform.localScale = new Vector3(x, y+(y*.20f), 1);
        cb.transform.Rotate(Vector3.right * 90 * Time.deltaTime);
        cb.transform.Rotate(Vector3.right * 90 * Time.deltaTime);
        cb.transform.Rotate(Vector3.right * 90 * Time.deltaTime);
        cb.transform.Rotate(Vector3.right * 90 * Time.deltaTime);
    }
}
