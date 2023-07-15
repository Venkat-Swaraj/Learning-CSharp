using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CXRlabs.Scripts
{
    public class ItemRotation : MonoBehaviour
    {
        public float rotationSpeed = 100f;
        private Transform ItemTransform;
        // Start is called before the first frame update
        void Start()
        {
            this.ItemTransform = this.GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            ItemTransform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}

