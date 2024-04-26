using UnityEngine;

namespace Game
{
    public class PlayerCharacter : MonoBehaviour
    {
        private float MoveSpeed { get; set; }
        private Vector3 MoveDirection { get; set; }
        
        private Rigidbody _rigidbody;
        
        private void Awake()
        {
            MoveSpeed = 10f;
            MoveDirection = Vector3.zero;
            
            _rigidbody = GetComponent<Rigidbody>();
        }
        
        private void Update()
        {
            Move();
        }

        public void Move()
        {
            float h = PlayerController.Instance.horizontalInput;
            float v = PlayerController.Instance.verticalInput;

            MoveDirection = new Vector3(h, 0, v);
            
            Vector3 movement = MoveDirection * MoveSpeed * Time.deltaTime;
            _rigidbody.MovePosition(transform.position + movement);
        }
    }
}
