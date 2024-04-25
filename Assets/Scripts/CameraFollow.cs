using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void LateUpdate (){
        var pos = transform.position;
        var posPlayer = target.position;
        var repos = offset;
        pos.x = posPlayer.x + repos.x;
        pos.z = posPlayer.z + repos.z;
        transform.position = pos;
    }
}
