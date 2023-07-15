using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CXRlabs.Scripts
{
    public class CameraBehaviour : MonoBehaviour
    {
        public Vector3 Camoffset = new Vector3(0f, 1.2f, -2.6f);
        private Transform _playerTransform;
        // Start is called before the first frame update
        void Start()
        {
            _playerTransform = GameObject.Find("Player").transform;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            this.transform.position = _playerTransform.TransformPoint(Camoffset);
            this.transform.LookAt(_playerTransform);
        }
    }
}
