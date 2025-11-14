using Unity.VisualScripting;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField] GameObject ground;
    [SerializeField] float boost;
    SurfaceEffector2D sF;
    float iniSpeed = 0f;
    void Start()
    {
        sF = ground.GetComponent<SurfaceEffector2D>();
        iniSpeed = sF.speed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            sF.speed = boost;
        }
        else
        {
            sF.speed = iniSpeed;
        }
    }
}