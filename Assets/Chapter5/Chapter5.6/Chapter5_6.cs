using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 标量与向量的乘法
/// 将向量的每个分量都与标量相乘即可
/// </summary>
public class Chapter5_6 : MonoBehaviour
{
    public Vector3 Vector;

    public float Scale;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector * Scale);
    }

    // Update is called once per frame
    void Update()
    {
        //几何解释
        //向量乘以标量k的效果是以因子k的绝对值缩放向量的长度
        Debug.DrawLine(Vector3.zero, Vector * Scale, Color.green);
    }
}
