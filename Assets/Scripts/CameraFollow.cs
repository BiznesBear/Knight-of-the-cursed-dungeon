using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraFollow : MonoBehaviour
    {
        public GameObject Object;
        private Vector3 offset;

        // Use this for initialization
        void Start()
        {
            offset = transform.position - Object.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = Object.transform.position +offset;
        }
    }
}