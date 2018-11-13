//look this up
using UnityEditor;
using UnityEngine;
[CustomEditor (typeof(meshCombiner))]
public class MeshCombinerEditor : Editor {
    private void OnSceneGUI()
    {
        meshCombiner mc = target as meshCombiner;

        //passing a position, a direction, size, pic size, and shape
        if (Handles.Button(mc.transform.position + Vector3.up * 5, Quaternion.LookRotation(Vector3.up), 1, 1, Handles.CylinderHandleCap))
        {
            mc.CombineMeshes();
        }
    }

}