using System;
using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController Instance;
        
        public float horizontalInput;
        public float verticalInput;

        private void Awake()
        {
            Instance = this;
        }
        
        private void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        }
    }
}
