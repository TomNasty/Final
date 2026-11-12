using UnityEngine;

public class TestAudio : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")){
            MusicManager.instance.PlayMusic("MenuTheme");
        }
        else if (Input.GetKeyDown("w"))
        {
            MusicManager.instance.PlayMusic("GameOver");
        }
        else if (Input.GetKeyDown("e"))
        {
            MusicManager.instance.PlayMusic("Boss");
        }
        else if (Input.GetKeyDown("a"))
        {
            //SoundManager.instance.PlaySound3D("l", transform.position);
        }
        else if (Input.GetKeyDown("s"))
        {
            //SoundManager.instance.PlaySound2D("l");
        }
    }
}
