using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] List<AudioClip> shootingClips;
    [SerializeField][Range(0f, 1f)] float shootingVolume = 1f;
    [Header("Damage")]
    [SerializeField] List<AudioClip> damageClips;
    [SerializeField][Range(0f, 1f)] float damageVolumen = 1f;

    public void PlayShootingClip()
    {
        PlayClip(shootingClips, shootingVolume);
    }
    public void PlayDamageClip()
    {
        Debug.Log("Play Damageclip!!!");
        PlayClip(damageClips, damageVolumen);

    }
    void PlayClip(List<AudioClip> clips, float volumen)
    {
        if (clips != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clips[RandomIntegerRange(0, clips.Count - 1)],
                cameraPos, volumen);
        }
    }
    int RandomIntegerRange(int minValue, int maxValue)
    {
        return Random.Range(minValue, maxValue);
    }

}
