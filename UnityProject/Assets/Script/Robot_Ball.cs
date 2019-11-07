using UnityEngine;

public class Robot_Ball : MonoBehaviour {

    //移動
    [Header("移動速度"), Range(0.0f, 50.0f)]
    public float Speed;

    //跳耀
    [Header("跳躍距離"), Range(0.0f, 100.0f)]
    public float Jump;

    //是否在地板
    public bool inGround;

    private Vector3 moveDirection = Vector3.zero;

    private Rigidbody Rob3D;

    void Start ()
    {
        Rob3D = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().position = Vector3.zero;
    }
	
	
	void Update ()
    {
		
	}

    //Time //呼叫副程式
    private void FixedUpdate()
    {
        RobWalk();
        RobJump();
    }


    /// <summary>
    /// 移動
    /// </summary>
    private void RobWalk()
    {
        Rob3D.AddForce(new Vector3(Speed * Input.GetAxis("Vertical") , 0, Speed * Input.GetAxis("Horizontal")));        
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void RobJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inGround == true)
        {
            inGround = false;
            Rob3D.AddForce(new Vector3(0, Jump, 0));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        inGround = true;
    }

}
