using UnityEngine;
using UnityEngine.SceneManagement;
public class contr : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 3;
    public float _rotationSpeed = -90;
    public float gravity = 20.0f;

    public float jumpSpeed = 8.0f;
    private Vector3 rotation;

    [HideInInspector]
    public bool canMove = true;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    Vector3 move = Vector3.zero;
    public void Update()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        

        this.transform.Rotate(this.rotation);

        if (_controller.isGrounded)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            float curSpeedX = canMove ? _speed * Input.GetAxis("Vertical") : 0;
            move = (forward * curSpeedX * (-1));
            if (Input.GetButton("Jump") )
            {
                move.y = jumpSpeed;
            }
        }

        move.y -= gravity * Time.deltaTime;
        _controller.Move(move * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }


    
}