﻿using System;
using System.Runtime.InteropServices;

#if USE_NUMERICS
using System.Numerics;
#endif

namespace OpenGL
{
    /// <summary>
    /// Helper class that performs simple math on some types of Geometry as
    /// well as helps generate some simple objects such as cubes and quads.
    /// </summary>
    public class Geometry
    {
        /// <summary>
        /// Calculate the array of vertex normals based on vertex and face information (assuming triangle polygons).
        /// </summary>
        /// <param name="vertexData">The vertex data to find the normals for.</param>
        /// <param name="elementData">The element array describing the order in which vertices are drawn.</param>
        /// <returns>An array with the vertex normals.</returns>
        [Obsolete("Use uint[] instead of int[].")]
        public static Vector3[] CalculateNormals(Vector3[] vertexData, int[] elementData)
        {
            Span<uint> uintElementData = MemoryMarshal.Cast<int, uint>(elementData);
            return CalculateNormals(vertexData.AsSpan(), uintElementData);
        }

        /// <summary>
        /// Calculate the array of vertex normals based on vertex and face information (assuming triangle polygons).
        /// </summary>
        /// <param name="vertexData">The vertex data to find the normals for.</param>
        /// <param name="elementData">The element array describing the order in which vertices are drawn.</param>
        /// <returns>An array with the vertex normals.</returns>
        public static Vector3[] CalculateNormals(Vector3[] vertexData, uint[] elementData)
        {
            return CalculateNormals(vertexData.AsSpan(), elementData.AsSpan());
        }

        /// <summary>
        /// Calculate the array of vertex normals based on vertex and face information (assuming triangle polygons).
        /// </summary>
        /// <param name="vertexData">The vertex data to find the normals for.</param>
        /// <param name="elementData">The element array describing the order in which vertices are drawn.</param>
        /// <returns>An array with the vertex normals.</returns>
        public static Vector3[] CalculateNormals(ReadOnlySpan<Vector3> vertexData, ReadOnlySpan<uint> elementData)
        {
            Vector3[] normalData = new Vector3[vertexData.Length];
            CalculateNormals(vertexData, elementData, normalData);
            return normalData;
        }

        /// <summary>
        /// Calculate the array of vertex normals based on vertex and face information (assuming triangle polygons)
        /// and put the normals into the provided array.
        /// </summary>
        /// <param name="vertexData">The vertex data to find the normals for.</param>
        /// <param name="elementData">The element array describing the order in which vertices are drawn.</param>
        /// <param name="normalData">The array the normals will be put into. Has to be the same length as the vertex array</param>
        public static void CalculateNormals(ReadOnlySpan<Vector3> vertexData, ReadOnlySpan<uint> elementData, Span<Vector3> normalData)
        {
            if ((elementData.Length % 3) != 0)
            {
                throw new ArgumentException($"Expected {nameof(elementData)} to be a multiple of 3 as each triangle consists of 3 points.", nameof(elementData));
            }
            if (vertexData.Length != normalData.Length)
            {
                throw new ArgumentException($"Expected {nameof(vertexData)} and {nameof(normalData)} to have the same length.", nameof(vertexData));
            }

            for (int i = 0; i < elementData.Length; i += 3)
            {
                int cornerAIndex = (int)elementData[i + 0];
                int cornerBIndex = (int)elementData[i + 1];
                int cornerCIndex = (int)elementData[i + 2];

                Vector3 cornerA = vertexData[cornerAIndex];
                Vector3 cornerB = vertexData[cornerBIndex];
                Vector3 cornerC = vertexData[cornerCIndex];

                Vector3 ab = cornerB - cornerA;
                Vector3 ac = cornerC - cornerA;

                Vector3 normal = Vector3.Cross(ab, ac).Normalize();

                normalData[cornerAIndex] += normal;
                normalData[cornerBIndex] += normal;
                normalData[cornerCIndex] += normal;
            }

            for (int i = 0; i < normalData.Length; i++) normalData[i] = normalData[i].Normalize();
        }

        /// <summary>
        /// Create a basic quad by storing two triangles into a VAO.
        /// This quad includes UV co-ordinates from 0,0 to 1,1.
        /// </summary>
        /// <param name="program">The ShaderProgram assigned to this quad.</param>
        /// <param name="location">The location of the VAO (assigned to the vertices).</param>
        /// <param name="size">The size of the VAO (assigned to the vertices).</param>
        /// <returns>The VAO object representing this quad.</returns>
        public static VAO CreateQuad(ShaderProgram program, Vector2 location, Vector2 size)
        {
            Vector3[] vertices = new Vector3[] { new Vector3(location.X, location.Y, 0), new Vector3(location.X + size.X, location.Y, 0),
                new Vector3(location.X + size.X, location.Y + size.Y, 0), new Vector3(location.X, location.Y + size.Y, 0) };
            uint[] indices = new uint[] { 0, 1, 2, 2, 3, 0 };

            return new VAO(program, new VBO<Vector3>(vertices), new VBO<uint>(indices, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead));
        }

        /// <summary>
        /// Create a basic quad by storing two triangles into a VAO.
        /// This quad includes UV co-ordinates from uvloc to uvloc+uvsize.
        /// </summary>
        /// <param name="program">The ShaderProgram assigned to this quad.</param>
        /// <param name="location">The location of the VAO (assigned to the vertices).</param>
        /// <param name="size">The size of the VAO (assigned to the vertices).</param>
        /// <param name="uvloc">The origin of the UV co-ordinates.</param>
        /// <param name="uvsize">The size of the UV co-ordinates.</param>
        /// <returns>The VAO object representing this quad.</returns>
        public static VAO CreateQuad(ShaderProgram program, Vector2 location, Vector2 size, Vector2 uvloc, Vector2 uvsize)
        {
            Vector3[] vertices = new Vector3[] { new Vector3(location.X, location.Y, 0), new Vector3(location.X + size.X, location.Y, 0),
                new Vector3(location.X + size.X, location.Y + size.Y, 0), new Vector3(location.X, location.Y + size.Y, 0) };
            Vector2[] uvs = new Vector2[] { uvloc, new Vector2(uvloc.X + uvsize.X, uvloc.Y), new Vector2(uvloc.X + uvsize.X, uvloc.Y + uvsize.Y), new Vector2(uvloc.X, uvloc.Y + uvsize.Y) };
            uint[] indices = new uint[] { 0, 1, 2, 2, 3, 0 };

            return new VAO(program, new VBO<Vector3>(vertices), new VBO<Vector2>(uvs), new VBO<uint>(indices, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead));
        }

        /// <summary>
        /// Create a basic quad by storing two triangles into a VAO.
        /// This quad includes normals, and does not include UV co-ordinates.
        /// </summary>
        /// <param name="program">The ShaderProgram assigned to this quad.</param>
        /// <param name="location">The location of the VAO (assigned to the vertices).</param>
        /// <param name="size">The size of the VAO (assigned to the vertices).</param>
        /// <returns>The VAO object representing this quad.</returns>
        public static VAO CreateQuadWithNormals(ShaderProgram program, Vector2 location, Vector2 size)
        {
            Vector3[] vertex = new Vector3[] { new Vector3(location.X, location.Y, 0), new Vector3(location.X + size.X, location.Y, 0),
                new Vector3(location.X + size.X, location.Y + size.Y, 0), new Vector3(location.X, location.Y + size.Y, 0) };
            uint[] element = new uint[] { 0, 1, 2, 2, 3, 0 };
            Vector3[] normal = CalculateNormals(vertex, element);

            return new VAO(program, new VBO<Vector3>(vertex), new VBO<Vector3>(normal), new VBO<uint>(element, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead));
        }

        /// <summary>
        /// Create a basic cube and store into a VAO.
        /// This cube consists of 12 triangles and 6 faces.
        /// </summary>
        /// <param name="program">The ShaderProgram assigned to this cube.</param>
        /// <param name="min">The 3 minimum values of the cube (lower left back corner).</param>
        /// <param name="max">The 3 maximum values of the cube (top right front corner).</param>
        /// <returns></returns>
        public static VAO CreateCube(ShaderProgram program, Vector3 min, Vector3 max)
        {
            Vector3[] vertex = new Vector3[] {
                new Vector3(min.X, min.Y, max.Z),
                new Vector3(max.X, min.Y, max.Z),
                new Vector3(min.X, max.Y, max.Z),
                new Vector3(max.X, max.Y, max.Z),
                new Vector3(max.X, min.Y, min.Z),
                new Vector3(max.X, max.Y, min.Z),
                new Vector3(min.X, max.Y, min.Z),
                new Vector3(min.X, min.Y, min.Z)
            };

            uint[] element = new uint[] {
                0, 1, 2, 1, 3, 2,
                1, 4, 3, 4, 5, 3,
                4, 7, 5, 7, 6, 5,
                7, 0, 6, 0, 2, 6,
                7, 4, 0, 4, 1, 0,
                2, 3, 6, 3, 5, 6
            };

            return new VAO(program, new VBO<Vector3>(vertex), new VBO<uint>(element, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead));
        }

        /// <summary>
        /// Create a basic cube with normals and stores it in a VAO.
        /// This cube consists of 12 triangles and 6 faces.
        /// </summary>
        /// <param name="program">The ShaderProgram assigned to this cube.</param>
        /// <param name="min">The 3 minimum values of the cube (lower left back corner).</param>
        /// <param name="max">The 3 maximum values of the cube (top right front corner).</param>
        /// <returns></returns>
        public static VAO CreateCubeWithNormals(ShaderProgram program, Vector3 min, Vector3 max)
        {
            Vector3[] vertex = new Vector3[] {
                new Vector3(min.X, min.Y, max.Z),
                new Vector3(max.X, min.Y, max.Z),
                new Vector3(min.X, max.Y, max.Z),
                new Vector3(max.X, max.Y, max.Z),
                new Vector3(max.X, min.Y, min.Z),
                new Vector3(max.X, max.Y, min.Z),
                new Vector3(min.X, max.Y, min.Z),
                new Vector3(min.X, min.Y, min.Z)
            };

            uint[] element = new uint[] {
                0, 1, 2, 1, 3, 2,
                1, 4, 3, 4, 5, 3,
                4, 7, 5, 7, 6, 5,
                7, 0, 6, 0, 2, 6,
                7, 4, 0, 4, 1, 0,
                2, 3, 6, 3, 5, 6
            };

            Vector3[] normal = CalculateNormals(vertex, element);

            return new VAO(program, new VBO<Vector3>(vertex), new VBO<Vector3>(normal), new VBO<uint>(element, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead));
        }
    }
}