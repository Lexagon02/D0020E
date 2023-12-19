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
    int i=0;

    private void Start()
    {
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
            i = 0;
        }
        i = i + 1;

    }
}
