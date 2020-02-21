using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 标准化向量
/// 对于许多向量 只关心她的方向而不是大小 可以使用单位向量 大小为1的向量
/// 运算法则
/// 对于任意非零向量V 将向量除以它的大小（模）即可
/// </summary>
public class Chapter5_7 : MonoBehaviour
{
    public Vector3 Vector3;

    // Start is called before the first frame update
    void Start()
    {
        float length = Vector3.magnitude;
        Debug.Log("Normalize :[" + Vector3.x / length + "," +  Vector3.y / length + "," +  Vector3.z / length + "]");
        Debug.Log("Normalize:" + Vector3.normalized);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Vector3.zero, Vector3, Color.green);
        Debug.DrawLine(Vector3.zero, Vector3.normalized, Color.black);
    }
}