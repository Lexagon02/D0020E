using UnityEditor;
using UnityEditor.Scripting.Python;

public class MenuItem_CR_Class
{
   [MenuItem("Python Scripts/CR")]
   public static void CR()
   {
       PythonRunner.RunFile("Assets/cr.py");
       }
};
