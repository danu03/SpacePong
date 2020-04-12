using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleContoller : MonoBehaviour
{
    public float kecepatan;
    public float batasAtas;
    public float batasBawah;
    public float batasKanan;
    public float batasKiri;
    
    public string axis1;
    public string axis2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gerak1 = Input.GetAxis(axis1) * kecepatan * Time.deltaTime;
        float gerak2 = Input.GetAxis(axis2) * kecepatan * Time.deltaTime;
        float nextPos1 = transform.position.y + gerak1;
        float nextPos2 = transform.position.x + gerak2;
        if (nextPos1 > batasAtas)
        {
            gerak1 = 0;
        }
        if (nextPos1 < batasBawah)
        {
            gerak1 = 0;
        }
        if (nextPos2 > batasKanan)
        {
            gerak2 = 0;
        }
        if (nextPos2 < batasKiri)
        {
            gerak2 = 0;
        }
        transform.Translate(gerak2, gerak1, 0);
    }
}
