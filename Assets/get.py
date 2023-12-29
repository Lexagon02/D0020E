import UnityEngine;
from UnityEngine import GameObject, PrimitiveType, Vector3
from shared_memory_dict import SharedMemoryDict
smd_config = SharedMemoryDict(name='config', size=1024) #Pip install shared-memory-dict first
import math

red=smd_config["status"] #Get coordinates from shared memory
x=red[0]
y=-red[1]
w=red[2]
h=red[3]
angle=red[4]
if(x!=0 or y!=0):
    x=x/5-60-(angle-180)/2
    y=y/5+50
    rel=h/w
    sword = GameObject.Find("swordObject")
    sword.transform.rotation= UnityEngine.Quaternion.Euler(0,0,angle)
    sword.transform.position= UnityEngine.Vector3(x,y,19)
