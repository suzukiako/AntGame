using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    [SerializeField] float m_speed = 0f;
    [SerializeField] Transform[] m_gameObjects;
    [SerializeField] float m_stoppingDistance = 0.05f;
    Vector2 m_force;
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(this.transform.position, m_gameObjects[n].position);

        if (distance > m_stoppingDistance)  // ターゲットに到達するまで処理する
        {
            Vector3 dir = (m_gameObjects[n].transform.position - this.transform.position).normalized * m_speed; // 移動方向のベクトルを求める
            this.transform.Translate(dir * Time.deltaTime); // Update の中で移動する場合は、Time.deltaTime をかけることによりどの環境でも同じ速さで移動させることができる
        }
        else
        {
            n++;
            if (n >= m_gameObjects.Length)
            {
                n = 0;
            }
        }
    }
}
