using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAnim : MonoBehaviour
{
    [SerializeField] private float _animTime;

    [SerializeField]
    public AudioClip _sfxSource;

    [SerializeField]
    public float _volume = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.PlayEffect(_sfxSource, _volume);
        Destroy(gameObject, _animTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
