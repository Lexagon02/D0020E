using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEditor.Scripting.Python;
using UnityEditor;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Specialized;





public class swordObject : MonoBehaviour
{
    public Rigidbody m_sword;
    public Vector3 trailOffset;

    private void Start()
    {
        m_sword = GetComponent<Rigidbody>();
        trailOffset = new Vector3(0, 0, 3);
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



    }
}
