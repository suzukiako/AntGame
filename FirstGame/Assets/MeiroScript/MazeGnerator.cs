using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGnerator : MonoBehaviour
{
    //上から見て縦、Z軸のオブジェクトの量
    public int m_vertical = 15;

    //上から見て横、X軸のオブジェクトの量
    public int m_horizontal = 15;

    //Prefabを入れる欄を作る
    public GameObject m_gameObejectCube;

    //for文でオブジェクトを縦横に並べるための変数
    int m_vi;
    int m_hi;

    //MinerのPrefabを入れるための変数
    public GameObject m_gameObjectMiner;

    int ver1;
    int hor1;

    void Start()
    {
        //Cubeを並べるための基準になる位置
        Vector2 pos = new Vector2(0, 0);

        //Z軸にverticalの数だけ並べる
        for (m_vi = 0; m_vi < m_vertical; m_vi++)
        {
            //X軸にhorizontalの数だけ並べる
            for (m_hi = 0; m_hi < m_horizontal; m_hi++)
            {
                //PrefabのCubeを生成する
                GameObject copy = Instantiate(m_gameObejectCube,
                    //生成したものを配置する位置
                    new Vector2(
                        //X軸
                        pos.x - 36 + m_hi,
                        //Y軸
                        pos.y - 17 + m_vi
                    //Quaternion.identityは無回転を指定する
                    ), Quaternion.identity);

                //生成したオブジェクトに番号の名前をつける
                copy.name = m_vi + "-" + m_hi.ToString();
            }
        }

        //ランダムな数字を縦横分の2つ出す
        //0からだが、並ぶオブジェクトの内側から選びたいので1からにした
        while (ver1 % 2 == 0)
        {
            ver1 = Random.Range(1, m_vertical - 1);
        }

        while (hor1 % 2 == 0)
        {
            hor1 = Random.Range(1, m_horizontal - 1);
        }

        //ランダムな数字からオブジェクトを検索してDestroyで消す
        GameObject start = GameObject.Find(ver1 + "-" + hor1);
        Destroy(start);
        //その位置をコンソールに表示
        Debug.Log(start);

        //Minerを生成
        GameObject minerObj = Instantiate(m_gameObjectMiner, Vector2.zero, Quaternion.identity);
        //MinerオブジェクトのMinerスクリプトを取得
        Miner minerScr = minerObj.GetComponent<Miner>();
        //MinerスクリプトのMining関数に引数を送って実行させる
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
        minerScr.DoMining(ver1, hor1);
    }
}