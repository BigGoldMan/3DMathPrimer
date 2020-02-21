using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_4 : MonoBehaviour
{
    public Vector3 Vector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //得到负向量
        //几何解释 向量变负 将得到一个和原向量大小相等，方向相反的向量
        Debug.DrawLine(Vector3.zero, Vector, Color.red);
        Debug.DrawLine(Vector3.zero, -Vector, Color.green);
        
    }
}
