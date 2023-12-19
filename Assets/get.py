import UnityEngine;
from shared_memory_dict import SharedMemoryDict
smd_config = SharedMemoryDict(name='config', size=1024) #Pip install shared-memory-dict first

red=smd_config["status"] #Get coordinates from shared memory
x=red[0]
y=red[1]
UnityEngine.Debug.Log(x) #Print to debug log
