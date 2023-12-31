﻿using System;
using OpenGL.Platform;

namespace OpenGL.Game.Components
{
    /// <summary>
    /// Component that enables a gameobject to move with the Buttons WASD / EQ and rotate with mouse movements.
    /// Only one movement controller can be active at a time. Switch between MovementControllers with the SpaceBar.
    /// </summary>
    public class MovementController : Component
    {
        /// <summary>
        /// If this is true the controller uses the positive World Space X axis as right movement, positive World Space Y axis as up movement and positive World Space Z axis as forward movement. If false we use the local space axis based on the objects orientation.
        /// </summary>
        public bool UseWorldSpaceAxis { get; set; } = false;

        public bool MovementEnabled = false;
        public bool RotationEnabled = false;

        private bool moveForward;
        private bool moveBackwards;
        private bool moveLeft;
        private bool moveRight;
        private bool moveUp;
        private bool moveDown;

        private float movementSpeed = 3.0f;
        private float rotationSpeed = 5.0f;
        public float MovementSpeed { get => movementSpeed; set => movementSpeed = value; }
        public float RotationSpeed { get => rotationSpeed; set => rotationSpeed = value; }

        public MovementController(bool useWorldSpaceAxis = false)
        {
            UseWorldSpaceAxis = useWorldSpaceAxis;
        }

        public override void OnAwake()
        {
        }
        public override void OnStart()
        {
            //All movement controllers are added to the movementControllerManagers list
            MovementControllerManager.Instance.AddMovementController(this);
            SubscribeToEvents();
        }

        public override void OnDisable()
        {
            UnSubscribeToEvents();
        }
        public override void OnUpdate()
        {
            if (!MovementEnabled) return;

            if (!UseWorldSpaceAxis)
            {
                if (moveForward) ProcessForwardMovementLocal();
                if (moveBackwards) ProcessBackwardsMovementLocal();
                if (moveLeft) ProcessLeftMovementLocal();
                if (moveRight) ProcessRightMovementLocal();
                if (moveUp) ProcessUpMovementLocal();
                if (moveDown) ProcessDownMovementLocal();
            }
            else
            {
                if (moveForward) ProcessForwardMovementGlobal();
                if (moveBackwards) ProcessBackwardsMovementGlobal();
                if (moveLeft) ProcessLeftMovementGlobal();
                if (moveRight) ProcessRightMovementGlobal();
                if (moveUp) ProcessUpMovementGlobal();
                if (moveDown) ProcessDownMovementGlobal();
            }
        }

        public void SubscribeToEvents()
        {
            InputHelper.ButtonWPressedEvent += OnWPressed;
            InputHelper.ButtonSPressedEvent += OnSPressed;
            InputHelper.ButtonAPressedEvent += OnAPressed;
            InputHelper.ButtonDPressedEvent += OnDPressed;
            InputHelper.ButtonEPressedEvent += OnEPressed;
            InputHelper.ButtonQPressedEvent += OnQPressed;

            InputHelper.MouseMoveEvent += ProcessRotation;
        }
        public void UnSubscribeToEvents()
        {
            InputHelper.ButtonWPressedEvent -= OnWPressed;
            InputHelper.ButtonSPressedEvent -= OnSPressed;
            InputHelper.ButtonAPressedEvent -= OnAPressed;
            InputHelper.ButtonDPressedEvent -= OnDPressed;
            InputHelper.ButtonEPressedEvent -= OnEPressed;
            InputHelper.ButtonQPressedEvent -= OnQPressed;

            InputHelper.MouseMoveEvent -= ProcessRotation;
        }

        #region InputCallbacks
        private void OnWPressed(bool isPressed)
        {
            moveForward = isPressed;
        }

        private void OnSPressed(bool isPressed)
        {
            moveBackwards = isPressed;
        }
        private void OnAPressed(bool isPressed)
        {
            moveLeft = isPressed;
        }
        private void OnDPressed(bool isPressed)
        {
            moveRight = isPressed;
        }
        private void OnQPressed(bool isPressed)
        {
            moveDown = isPressed;
        }
        private void OnEPressed(bool isPressed)
        {
            moveUp = isPressed;
        }
        #endregion

        #region Movement

        private void ProcessForwardMovementLocal()
        {
            transform.Position += transform.Forward * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessForwardMovementGlobal()
        {
            transform.Position += new Vector3(0, 0, -1) * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessBackwardsMovementLocal()
        {
            transform.Position += -transform.Forward * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessBackwardsMovementGlobal()
        {
            transform.Position += new Vector3(0, 0, 1) * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessLeftMovementLocal()
        {
            transform.Position += -transform.Right * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessLeftMovementGlobal()
        {
            transform.Position += new Vector3(-1, 0, 0) * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessRightMovementLocal()
        {
            transform.Position += transform.Right * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessRightMovementGlobal()
        {
            transform.Position += new Vector3(1, 0, 0) * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessUpMovementLocal()
        {
            transform.Position += transform.Up * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessUpMovementGlobal()
        {
            transform.Position += new Vector3(0, 1, 0) * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessDownMovementLocal()
        {
            transform.Position += -transform.Up * Time.DeltaTime * MovementSpeed;
        }

        private void ProcessDownMovementGlobal()
        {
            transform.Position += new Vector3(0, -1, 0) * Time.DeltaTime * MovementSpeed;
        }

        #endregion Movement

        private void ProcessRotation(int xRotation, int yRotation)
        {
            if (!RotationEnabled) return;

            transform.Rotation += new Vector3(yRotation, xRotation, 0) * Time.DeltaTime * RotationSpeed;
        }

    }
}