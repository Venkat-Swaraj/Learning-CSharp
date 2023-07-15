using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CXRlabs.Scripts
{
    public class PlayerBehaviour : MonoBehaviour
    {
        public float MoveSpeed = 10f;
        public float RotationSpeed = 100f;

        private float _horizontalInput;
        private float _verticalInput;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
            _horizontalInput = Input.GetAxis("Horizontal");
            _verticalInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed * _verticalInput);
            transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed * _horizontalInput);
        }
    }
}
