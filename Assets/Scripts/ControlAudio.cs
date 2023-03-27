using UnityEngine;

public class ControlAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Hit;
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayo,out Hit))
            {
                if (Hit.collider.tag == "Play")
                {
                    audioSource.Play();
                } else if (Hit.collider.tag == "Pause")
                {
                    audioSource.Pause();
                } else if (Hit.collider.tag == "Stop")
                {
                    audioSource.Stop();
                }
            }
        }
    }
}
