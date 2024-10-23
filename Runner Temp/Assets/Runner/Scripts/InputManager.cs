
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

namespace HyperCasual.Runner
{
    /// <summary>
    /// A simple Input Manager for a Runner game.
    /// </summary>
    public class InputManager : MonoBehaviour
    {
        /// <summary>
        /// Returns the InputManager.
        /// </summary>
        public static InputManager Instance => s_Instance;
        static InputManager s_Instance;

        [SerializeField]
        float m_InputSensitivity = 1.5f;

        bool m_HasInput;
        Vector3 m_InputPosition;
        Vector3 m_PreviousInputPosition;

        void Awake()
        {
            if (s_Instance != null && s_Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            s_Instance = this;
        }

        void OnEnable()
        {
            EnhancedTouchSupport.Enable();
        }

        void OnDisable()
        {
            EnhancedTouchSupport.Disable();
        }

        void Update()
        {
            if (PlayerController.Instance == null)
            {
                Debug.Log("Null");
                return;
            }


            /*   if (SystemInfo.deviceType == DeviceType.Desktop)
               {
                   // Use mouse and keyboard controls for PC
                   HandleMouseInput();
               }
               else if (SystemInfo.deviceType == DeviceType.Handheld)
               {
                   HandleTouchInput();
                   // Use touch controls for mobile devices
               }
               // Detect if running on mobile or editor
               if (Application.platform == RuntimePlatform.WebGLPlayer || Application.isEditor)
               {
                           Debug.Log("Webgl");
                  // HandleMouseInput();
               }
               else if (Application.isMobilePlatform)
               {
                           Debug.Log("Android");
                //   HandleTouchInput();
               }*/
            if (GameManager.Instance.IsMobile)
            {
                HandleTouchInput();
                           Debug.Log("Android");
                
            }
            else
            {
                           Debug.Log("Webgl");
                HandleMouseInput();
            }

            if (m_HasInput)
            {
                float normalizedDeltaPosition = (m_InputPosition.x - m_PreviousInputPosition.x) / Screen.width * m_InputSensitivity;
                PlayerController.Instance.SetDeltaPosition(normalizedDeltaPosition);
            }
            else
            {
                PlayerController.Instance.CancelMovement();
            }

            m_PreviousInputPosition = m_InputPosition;
        }
        // Handles input for mouse (for Editor)
        void HandleMouseInput()
        {
            m_InputPosition = Mouse.current.position.ReadValue();
            if (Mouse.current.leftButton.isPressed)
            {
                if (!m_HasInput)
                {
                    m_PreviousInputPosition = m_InputPosition;
                }
                m_HasInput = true;
            }
            else
            {
                m_HasInput = false;
            }
        }

        // Handles touch input for mobile devices
        void HandleTouchInput()
        {
            if (Touch.activeTouches.Count > 0)
            {
                // Get the first touch input (for single-finger control)
                m_InputPosition = Touch.activeTouches[0].screenPosition;

                if (!m_HasInput)
                {
                    m_PreviousInputPosition = m_InputPosition;
                }
                m_HasInput = true;
            }
            else
            {
                m_HasInput = false;
            }
        }
    }

}

