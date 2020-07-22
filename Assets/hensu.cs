using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hensu : MonoBehaviour
{
    int vx = 20;

    //順次処理、分岐処理、繰り返し処理
    public void ensyu71()  
    {
        int vx = 5;
        Debug.Log(vx);

        vx = 10;
        Debug.Log(vx);
        Debug.Log(vx);
    }

    public void ensyu72()

    {
        Debug.Log(vx);
    }
    public void ensyu74()
    {
        vx += 10;
        Debug.Log(vx);
    }

    // Start is called before the first frame update
    public void  proc()
    {
        int a= 10;
        float fw= 3.14f;
        string str= "こんにちは";
        bool bl= true;

        Debug.Log(a);
        Debug.Log(fw);
        Debug.Log(str);
        Debug.Log(bl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
