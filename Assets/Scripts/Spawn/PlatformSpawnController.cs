using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawn
{
    public class PlatformSpawnController : MonoBehaviour, ISpawn
    {
        [SerializeField] private GameObject[] _platforms;
        [SerializeField] private GameObject _startPlatform;

        private Vector2 _spawnPosition = Vector2.zero;
        private int _platformLenght = 2;
        private List<GameObject> _spawnedPlatforms = new List<GameObject>();

        public void Spawn()
        {
            int randomDirection = Random.Range(0, 3); 
            int randomPlatform = Random.Range(0, _platforms.Length);

            GameObject spawnedPlatform = Instantiate(_platforms[randomPlatform]);

            switch (randomDirection)
            {
                case 0:
                    spawnedPlatform.transform.position = _spawnPosition + new Vector2(_platformLenght, _platformLenght);
                    break;
                case 1:
                    spawnedPlatform.transform.position = _spawnPosition + new Vector2(_platformLenght, 0);
                    break;
                case 2:
                    spawnedPlatform.transform.position = _spawnPosition + new Vector2(_platformLenght, -_platformLenght);
                    break;
                
            }
            
            _spawnedPlatforms.Add(spawnedPlatform);
        }

        public void Delete()
        {
            foreach (GameObject platform in _spawnedPlatforms)
                Destroy(platform);
        }
    }
}
