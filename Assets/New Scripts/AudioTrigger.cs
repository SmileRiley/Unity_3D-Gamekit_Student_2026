using UnityEngine;

namespace New_Scripts
{
    public class AudioTrigger : MonoBehaviour
    {
        private AudioManager audioManager;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            audioManager=GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                audioManager.PlayMusic();
            }
        }
    }
}
