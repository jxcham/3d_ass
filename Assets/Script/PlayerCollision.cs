using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "leftdoor")
        //{
        //    other.gameObject.GetComponent<Transform>
        //}

        //if (other.gameObject.name == "matchbox")
        //{
        //    AudioSource audio = GetComponent<AudioSource>();
        //    audio.clip = batteryCollect;
        //    audio.Play();
        //    haveMatches = true;
        //    Destroy(other.gameObject);
        //    Instantiate(matchGUI, canvas.transform, false);
        //    matchGUI.name = "matchGUI";
        //}
    }
}
