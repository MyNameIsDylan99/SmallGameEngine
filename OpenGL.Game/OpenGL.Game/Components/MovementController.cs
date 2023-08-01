﻿using OpenGL.Platform;
using System;
using System.Collections.Generic;

namespace OpenGL.Game.Components
{
    /// <summary>
    /// Component that enables a gameobject to move with the Buttons WASD / EQ and rotate with mouse movements.
    /// Only one movement controller can be active at a time. Switch between MovementControllers with the SpaceBar.
    /// </summary>
    public class MovementController : Component
    {
        private static int currentlySelectedMovementControllerIndex = 0;
        private static MovementController currentlySelectedMovementController;
        private static List<MovementController> allMovementControllers = new List<MovementController>();

        //Since this class has a static method that subscribes to an event in the constructor, we make sure we only subscribe to this event once.
        private static bool alreadySubscribedToStaticMethods = false;

        /// <summary>
        /// If this is true the controller uses the positive World Space X axis as right movement, positive World Space Y axis as up movement and positive World Space Z axis as forward movement. If false we use the local space axis based on the objects orientation.
        /// </summary>
        public bool UseWorldSpaceAxis { get; set;} = false;

        private bool movementEnabled = false;
        private bool rotationEnabled = false;

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


        public MovementController(GameObject gameObject, bool useWorldSpaceAxis = false) : base(gameObject)
        {
            UseWorldSpaceAxis = useWorldSpaceAxis;

            //All movement controllers are added to the static movement controller list
            allMovementControllers.Add(this);
            currentlySelectedMovementController = allMovementControllers[currentlySelectedMovementControllerIndex];

            //Make sure only the currently selected movement controller is activated;
            currentlySelectedMovementController.movementEnabled = true;
            currentlySelectedMovementController.rotationEnabled = true;

            SubscribeToEvents();
        }

        public override void OnUpdate()
        {
            if (!movementEnabled) return;

            if(!UseWorldSpaceAxis)
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
            InputHelper.ButtonWPressedEvent += (x) => moveForward = x;
            InputHelper.ButtonSPressedEvent += (x) => moveBackwards = x;
            InputHelper.ButtonAPressedEvent += (x) => moveLeft = x;
            InputHelper.ButtonDPressedEvent += (x) => moveRight = x;
            InputHelper.ButtonEPressedEvent += (x) => moveUp = x;
            InputHelper.ButtonQPressedEvent += (x) => moveDown = x;

            InputHelper.MouseMoveEvent += ProcessRotation;

            if(!alreadySubscribedToStaticMethods)
            {
            InputHelper.ButtonSpacePressedEvent += SelectNextMovementController;
            alreadySubscribedToStaticMethods = true;
            }
        }

        #region Movement
        private void ProcessForwardMovementLocal()
        {
            transform.Position += transform.Forward * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessForwardMovementGlobal()
        {
            transform.Position += new Vector3 (0,0,-1) * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessBackwardsMovementLocal()
        {
            transform.Position += -transform.Forward * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessBackwardsMovementGlobal()
        {
            transform.Position += new Vector3 (0,0,1) * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessLeftMovementLocal()
        {
            transform.Position += -transform.Right * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessLeftMovementGlobal()
        {
            transform.Position += new Vector3 (-1,0,0) * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessRightMovementLocal()
        {
            transform.Position += transform.Right * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessRightMovementGlobal()
        {
            transform.Position += new Vector3 (1,0,0) * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessUpMovementLocal()
        {
            transform.Position += transform.Up * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessUpMovementGlobal()
        {
            transform.Position += new Vector3 (0,1,0) * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessDownMovementLocal()
        {
            transform.Position += -transform.Up * Time.DeltaTime * MovementSpeed;
        }
        private void ProcessDownMovementGlobal()
        {
            transform.Position += new Vector3 (0,-1,0) * Time.DeltaTime * MovementSpeed;
        }
        #endregion

        private void ProcessRotation(int xRotation, int yRotation)
        {
            if (!rotationEnabled) return;

            transform.Rotation += new Vector3(yRotation, xRotation, 0) * Time.DeltaTime * RotationSpeed;
        }

        #region Selection
        public static void MakeControllerActive(MovementController controller)
        {
            //Disable the previously selected controller
            currentlySelectedMovementController.movementEnabled = false;
            currentlySelectedMovementController.rotationEnabled = false;

            //Set the controller as selected
            currentlySelectedMovementController = controller;
            currentlySelectedMovementControllerIndex = allMovementControllers.IndexOf(controller);

            //Activate the controller
            currentlySelectedMovementController.movementEnabled = true;
            currentlySelectedMovementController.rotationEnabled = true;
        }

        /// <summary>
        /// This method increments the currentlySelectedMovementControllerIndex by 1, selects and makes the next MovementController in the allMovementControllers List active.
        /// </summary>
        /// <param name="isPressed"></param>
        public static void SelectNextMovementController(bool isPressed)
        {
            if (!isPressed) return;

            currentlySelectedMovementController.movementEnabled = false;
            currentlySelectedMovementController.rotationEnabled = false;
            currentlySelectedMovementControllerIndex++;
            currentlySelectedMovementController = allMovementControllers[currentlySelectedMovementControllerIndex % allMovementControllers.Count];
            currentlySelectedMovementController.movementEnabled = true;
            currentlySelectedMovementController.rotationEnabled = true;
        }

        #endregion
    }
}