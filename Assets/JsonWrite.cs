using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class JsonWrite : MonoBehaviour
{
    StreamWriter writer;
    // Start is called before the first frame update
    [SerializeField] 
    private GameObject Red;

    [SerializeField] 
    private GameObject Blue;
    void Start()
    {
        Player player = new Player ();
        player.name = Red.name;
        player.x = Red.transform.position.x.ToString();
        player.y = Red.transform.position.y.ToString();
        player.z = Red.transform.position.z.ToString();

        string jsonstr = JsonUtility.ToJson (player);
        Debug.Log (jsonstr);
        writer = new StreamWriter(@"Assets/Resources/sample.json", false);
        writer.Write (jsonstr);
        writer.Flush ();
        writer.Close ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

[System.Serializable]
public class Player
{
    public string name;
    public string x;
    public string y;
    public string z;
}