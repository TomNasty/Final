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
            SoundManager.instance.PlaySound3D("B_Charge", transform.position);
        }
        else if (Input.GetKeyDown("s"))
        {
            SoundManager.instance.PlaySound2D("B_Defeat");
        }
        else if (Input.GetKeyDown("d"))
        {
            SoundManager.instance.PlaySound2D("B_Steps");
        }
        else if (Input.GetKeyDown("f"))
        {
            SoundManager.instance.PlaySound2D("H_Steps");
        }
        else if (Input.GetKeyDown("g"))
        {
            SoundManager.instance.PlaySound2D("H_Heals");
        }
        else if (Input.GetKeyDown("h"))
        {
            SoundManager.instance.PlaySound2D("H_Swim");
        }
    }
}
