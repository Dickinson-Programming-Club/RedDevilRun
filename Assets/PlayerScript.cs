using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        } else if (Input.GetKey(KeyCode.A)) {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        } else if (Input.GetKey(KeyCode.W)) {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }
    }
}
