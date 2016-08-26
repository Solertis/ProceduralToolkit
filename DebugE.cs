﻿using UnityEngine;

namespace ProceduralToolkit
{
    public static class DebugE
    {
        private static readonly Draw.DebugDrawLine drawLine;

        static DebugE()
        {
            drawLine = Debug.DrawLine;
        }

        public static void DrawWireQuadXY(Vector3 position, Quaternion rotation, Vector2 scale)
        {
            DrawWireQuadXY(position, rotation, scale, Color.white);
        }

        public static void DrawWireQuadXY(
            Vector3 position,
            Quaternion rotation,
            Vector2 scale,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireQuadXY(drawLine, position, rotation, scale, color, duration, depthTest);
        }

        public static void DrawWireQuadXZ(Vector3 position, Quaternion rotation, Vector2 scale)
        {
            DrawWireQuadXZ(position, rotation, scale, Color.white);
        }

        public static void DrawWireQuadXZ(
            Vector3 position,
            Quaternion rotation,
            Vector2 scale,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireQuadXZ(drawLine, position, rotation, scale, color, duration, depthTest);
        }

        public static void DrawWireCube(Vector3 position, Quaternion rotation, Vector3 scale)
        {
            DrawWireCube(position, rotation, scale, Color.white);
        }

        public static void DrawWireCube(
            Vector3 position,
            Quaternion rotation,
            Vector3 scale,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireCube(drawLine, position, rotation, scale, color, duration, depthTest);
        }

        public static void DrawWireCircleXY(Vector3 position, float radius)
        {
            DrawWireCircleXY(position, radius, Color.white);
        }

        public static void DrawWireCircleXY(
            Vector3 position,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireCircleXY(drawLine, position, radius, color, duration, depthTest);
        }

        public static void DrawWireCircleXY(Vector3 position, Quaternion rotation, float radius)
        {
            DrawWireCircleXY(position, rotation, radius, Color.white);
        }

        public static void DrawWireCircleXY(
            Vector3 position,
            Quaternion rotation,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireCircleXY(drawLine, position, rotation, radius, color, duration, depthTest);
        }

        public static void DrawWireCircleXZ(Vector3 position, float radius)
        {
            DrawWireCircleXZ(position, radius, Color.white);
        }

        public static void DrawWireCircleXZ(
            Vector3 position,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireCircleXZ(drawLine, position, radius, color, duration, depthTest);
        }

        public static void DrawWireCircleXZ(Vector3 position, Quaternion rotation, float radius)
        {
            DrawWireCircleXZ(position, rotation, radius, Color.white);
        }

        public static void DrawWireCircleXZ(
            Vector3 position,
            Quaternion rotation,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireCircleXZ(drawLine, position, rotation, radius, color, duration, depthTest);
        }

        public static void DrawWireCircleYZ(Vector3 position, float radius)
        {
            DrawWireCircleYZ(position, radius, Color.white);
        }

        public static void DrawWireCircleYZ(
            Vector3 position,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireCircleYZ(drawLine, position, radius, color, duration, depthTest);
        }

        public static void DrawWireCircleYZ(Vector3 position, Quaternion rotation, float radius)
        {
            DrawWireCircleYZ(position, rotation, radius, Color.white);
        }

        public static void DrawWireCircleYZ(
            Vector3 position,
            Quaternion rotation,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireCircleYZ(drawLine, position, rotation, radius, color, duration, depthTest);
        }

        public static void DrawWireSphere(Vector3 position, Quaternion rotation, float radius)
        {
            DrawWireSphere(position, rotation, radius, Color.white);
        }

        public static void DrawWireSphere(
            Vector3 position,
            Quaternion rotation,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = true)
        {
            Draw.WireSphere(drawLine, position, rotation, radius, color, duration, depthTest);
        }
    }
}