import UnityEngine
import UnityEngine.UI

all_objects = UnityEngine.Object.FindObjectsOfType(UnityEngine.UI.Text)
for go in all_objects:
	go.text = "test"