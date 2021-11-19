using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public int kecepatan;
    public float batas;

    Vector2 posisiawal;
    // Start is called before the first frame update
    void Start()
    {
        posisiawal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(kecepatan,0,0);

        if(transform.position.x<batas)
        {
            transform.position = posisiawal;
        }
    }
}
