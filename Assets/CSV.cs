using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class CSV : MonoBehaviour
{
    [SerializeField] 
    private GameObject Red;

    [SerializeField] 
    private GameObject Blue;
    // Start is called before the first frame update

    // Use this for initialization
    void Start()
    {
        StreamWriter sw = new StreamWriter(@"Assets/Resources/sample.csv", false, Encoding.GetEncoding("Shift_JIS"));
        //保存するデータの記入
        sw.WriteLine(Red.name + "," + Red.transform.position.x　+ "," +　+ Red.transform.position.y + "," + Red.transform.position.z);
        sw.WriteLine(Blue.name + "," + Blue.transform.position.x　+ "," +　+ Blue.transform.position.y + "," + Blue.transform.position.z);
        //終わったら閉じる
        sw.Close();
    }



// Update is called once per frame
    void Update()
    {
        
    }
}
