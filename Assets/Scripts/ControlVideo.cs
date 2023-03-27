using UnityEngine;
using UnityEngine.Video;

public class ControlVideo : MonoBehaviour
{
    public GameObject videoPlayer;
    VideoPlayer player;

    void Start()
    {
        player = videoPlayer.GetComponent<VideoPlayer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Hit;
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayo, out Hit))
            {
                if (Hit.collider.tag == "VideoPlay")
                {
                    player.Play();
                }
                else if (Hit.collider.tag == "VideoPause")
                {
                    player.Pause();
                }
                else if (Hit.collider.tag == "VideoStop")
                {
                    player.Stop();
                }
            }
        }
    }
}
