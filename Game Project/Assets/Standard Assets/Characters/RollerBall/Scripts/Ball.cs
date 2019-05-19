using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float m_MovePower = 40; // The force added to the ball to move it.

        private Rigidbody m_Rigidbody;


        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            // Set the maximum angular velocity.
            //GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }


        public void Move()
        {
            Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, Input.acceleration.y);

            m_Rigidbody.velocity = movement * m_MovePower;
        }
    }
}
