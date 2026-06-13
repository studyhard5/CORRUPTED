using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 5f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        
        bool isMoving = (x != 0 || z != 0);
        anim.SetBool("is_running", isMoving);

        Vector3 move = new Vector3(x, 0, z) * speed * Time.deltaTime;
        transform.Translate(move);
    }
}