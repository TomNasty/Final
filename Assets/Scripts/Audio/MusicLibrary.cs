using UnityEngine;

[System.Serializable]//enables it to be seen in inspector
public struct MusicTrack
{
    public string trackName;
    public AudioClip clip;
}
public class MusicLibrary : MonoBehaviour
{
    public MusicTrack[] tracks;//array containing all music
    public AudioClip GetClipFromName(string trackName)// return audio clip from passed in name
    {
        foreach (var track in tracks)// search array for tracks
        {
            if (track.trackName == trackName)
            {
                return track.clip; // return track clip if found
            }
        }
        return null; // return null if not found
    }
}