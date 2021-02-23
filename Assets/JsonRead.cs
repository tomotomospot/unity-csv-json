using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

[System.Serializable]
public class InputJson
{
    public string name;
    public float x;
    public float y;
    public float z;
}


public class JsonRead : MonoBehaviour
{
    [SerializeField] 
    private GameObject Red;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 Redpos = Red.transform.position;
        string inputString = Resources.Load<TextAsset>("sample").ToString();
        // 上で作成したクラスへデシリアライズ
        InputJson inputJson = JsonUtility.FromJson<InputJson>(inputString);

        Redpos.x = inputJson.x;
        Redpos.y = inputJson.y;
        Redpos.z = inputJson.z;
            
        Red.transform.position = Redpos;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
