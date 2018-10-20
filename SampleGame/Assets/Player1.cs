using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Rigidbody rd;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rd.AddForce(0, 0, 20);
            rd.AddForce(0, 0, 20);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rd.AddForce(20, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rd.AddForce(0, 0, -20);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rd.AddForce(-20, 0, 0);
        }
    }
}
