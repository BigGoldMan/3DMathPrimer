using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 向量大小(长度或模)
/// 向量的大小就是向量各分量平方和的平方根
/// 
/// 
/// </summary>
public class Chapter5_5 : MonoBehaviour
{
    public Vector2 Vector2;

    public Vector3 Vector3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("2D Length:" + Mathf.Sqrt(Vector2.x * Vector2.x + Vector2.y * Vector2.y));
        Debug.Log("2D Length:" + Vector2.magnitude);
        Debug.Log("3D Length:" + Mathf.Sqrt((float) ((double) Vector3.x * (double) Vector3.x + (double) Vector3.y * (double) Vector3.y + (double) Vector3.z * (double) Vector3.z)));
        Debug.Log("3D Length:" + Vector3.magnitude);
    }

    // Update is called once per frame
    void Update()
    {
    }
}