﻿using OpenGL.Mathematics;
using OpenGL.Platform;

namespace OpenGL.Game.Components
{
    public class Camera : Component
    {
        public float FOV = 45;

        public Camera() 
        {
        }
        public override void OnAwake()
        {
        }

        public override void OnStart()
        {
        }
        public override void OnUpdate()
        {
        }
        public override void OnDisable()
        {
        }

        public Matrix4 GetViewMatrix()
        {
            Matrix4 viewTranslation = Matrix4.Identity;
            Matrix4 viewRotation = Matrix4.Identity;
            Matrix4 viewScale = Matrix4.Identity;

            viewTranslation = Matrix4.CreateTranslation(transform.Position);
            Matrix4 viewRotationX = Matrix4.CreateRotation(new Vector3(1.0f, 0.0f, 0.0f), Mathf.ToRad(-transform.Rotation.X));
            Matrix4 viewRotationY = Matrix4.CreateRotation(new Vector3(0.0f, 1.0f, 0.0f), Mathf.ToRad(-transform.Rotation.Y));
            Matrix4 viewRotationZ = Matrix4.CreateRotation(new Vector3(0.0f, 0.0f, 1.0f), Mathf.ToRad(-transform.Rotation.Z));

            viewRotation = viewRotationY * viewRotationX;

            viewScale = Matrix4.CreateScaling(new Vector3(1.0f, 1.0f, 1.0f));

            Matrix4 view = viewTranslation * viewRotation * viewScale;// TRS matrix -> scale, rotate then translate -> All applied in LOCAL Coordinates

            return view;
        }

        public Matrix4 GetProjectionMatrix()
        {
            float aspectRatio = Window.Width / (float)Window.Height;
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(Mathf.ToRad(FOV), aspectRatio, 0.1f, 1000f);
            //Matrix4 projection = Matrix4.CreateOrthographic(1, 1, 0.1f, 100.0f);

            return projection;
        }

    }
}