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
    public int redCoord;
    //redCoord = PythonSettings.createInstance(int);
    private void Start()
    {
    }
    private void Update()
    {
         [MenuItem("Python Scripts/get")]
            static void get()
            {
                string path= UnityEngine.Application.dataPath;
                PythonRunner.RunFile(path + "/get.py");
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

    }
}
