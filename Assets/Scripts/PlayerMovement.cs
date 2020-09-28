using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] 
    public float _movementSpeed = 10f;
    public float _SideSpeed = 10f;

    //rigid body assign
    public Rigidbody _rigidbody;

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.AddForce(0,0,10*Time.deltaTime*_movementSpeed);

        //LeftMovement
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-Time.deltaTime * _SideSpeed,0,0,ForceMode.VelocityChange);
        }
        
        //RighMovement
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Time.deltaTime * _SideSpeed, 0, 0, ForceMode.VelocityChange);
        }

        if (_rigidbody.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
