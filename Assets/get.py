import UnityEngine;
from UnityEngine import GameObject, PrimitiveType, Vector3
from shared_memory_dict import SharedMemoryDict
smd_config = SharedMemoryDict(name='config', size=1024) #Pip install shared-memory-dict first

red=smd_config["status"] #Get coordinates from shared memory
x=red[0]
x=x/10-10
y=red[1]
y=y/10
sword = GameObject.Find("swordObject")
sword.transform.position= UnityEngine.Vector3(x,y,20)
UnityEngine.Debug.Log(x) #Print to debug log
#UnityEngine.gameObject.SendMessage("applyCoords", x)
