using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
        transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
    }
}
