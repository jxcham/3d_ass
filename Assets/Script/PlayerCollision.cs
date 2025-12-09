using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    private bool leftDoorIsOpen = false;
    private bool rightDoorIsOpen = false;
    private bool labDoorIsOpen = false;

    private float leftDoorTimer = 0.0f;
    private float rightDoorTimer = 0.0f;
    private float labDoorTimer = 0.0f;

    private GameObject currentRightDoor;
    private GameObject currentLeftDoor;
    private GameObject currentLabDoor;

    public float doorOpenTime = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leftDoorIsOpen)
        {
            leftDoorTimer += Time.deltaTime;
            if (leftDoorTimer > doorOpenTime)
            {
                currentLeftDoor.GetComponent<Animation>().Play("close");
                leftDoorIsOpen = false;
                leftDoorTimer = 0.0f;
            }
        }

        if (rightDoorIsOpen)
        {
            rightDoorTimer += Time.deltaTime;
            if (rightDoorTimer > doorOpenTime)
            {
                currentRightDoor.GetComponent<Animation>().Play("close");
                rightDoorIsOpen = false;
                rightDoorTimer = 0.0f;
            }
        }
        if (labDoorIsOpen)
        {
            labDoorTimer += Time.deltaTime;
            if (labDoorTimer > doorOpenTime)
            {
                currentLabDoor.GetComponent<Animation>().Play("close");
                labDoorIsOpen = false;
                labDoorTimer = 0.0f;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "leftdoor" && !leftDoorIsOpen)
        {
            currentLeftDoor = other.gameObject;
            currentLeftDoor.GetComponent<Animation>().Play("open");
            leftDoorIsOpen = true;

        }
      

        if (other.gameObject.tag == "rightdoor" && !rightDoorIsOpen)
        {
            currentRightDoor = other.gameObject;
            currentRightDoor.GetComponent<Animation>().Play("open");
            rightDoorIsOpen = true;
        }
        if (other.gameObject.tag == "door" && !labDoorIsOpen)
        {
            currentLabDoor = other.gameObject;
            currentLabDoor.GetComponent<Animation>().Play("open");
            labDoorIsOpen = true;
        }
    }
}
