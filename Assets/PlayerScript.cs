using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    /**
    This method controls basic character movement, the jumping 
    mechinism should be fixed
    */
    void MovePlayer() {
        float movement = speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(movement, 0f, 0f);
        } else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= new Vector3(movement, 0f, 0f);
        } else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0f, movement, 0f);
        }
    }
}
