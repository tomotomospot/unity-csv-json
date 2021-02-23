using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadCSV : MonoBehaviour
{
    [SerializeField] 
    private GameObject Red;

    [SerializeField] 
    private GameObject Blue;
    TextAsset csvFile; // CSVファイル
    List<string[]> csvDatas = new List<string[]>(); 
    // Start is called before the first frame update
    void Start()
    {
        csvFile = Resources.Load("sample") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);
        Vector3 Redpos = Red.transform.position;
        Vector3 Bluepos = Blue.transform.position;
        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        Debug.Log(csvDatas[0][0]); Debug.Log(csvDatas[0][1]); Debug.Log(csvDatas[0][2]); Debug.Log(csvDatas[0][3]); 
        Debug.Log(csvDatas[1][0]); Debug.Log(csvDatas[1][1]); Debug.Log(csvDatas[1][2]); Debug.Log(csvDatas[1][3]);
        Redpos.x = float.Parse(csvDatas[0][1]);
        Redpos.y = float.Parse(csvDatas[0][2]);
        Redpos.z = float.Parse(csvDatas[0][3]);
        Red.transform.position = Redpos;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
