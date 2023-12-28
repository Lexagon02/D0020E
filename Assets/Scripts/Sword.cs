using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEditor.Scripting.Python;
using UnityEditor;
using static System.Net.Mime.MediaTypeNames;



public class swordObject : MonoBehaviour
{
    public int redCoord=0;
    int i=0;
    public GameObject[] left;
    //redCoord = PythonSettings.createInstance(int);
    private void Start()
    {
        left = new GameObject[1];
    }

    private void Update()
    {
        if (i > 100) { 
            [MenuItem("Python Scripts/get")]
            static void get()
            {
                PythonRunner.RunFile($"C:/Users/oscar/My project/Assets/get.py");
            }
            get();

/*             [MenuItem("Python Scripts/setCoord")]
            static void setCoord()
                {
                 PythonRunner.RunString(@"
                    import UnityEngine;
                    UnityEngine.left.redCoord=3
                ");
                } */
            //setCoord();
            i = 0;

        }
        i = i + 1;

    }
}
