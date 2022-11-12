using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public abstract class Drawer
    {
        public abstract void DrawLine(Vector3 start, Vector3 end);

        public void DrawArrow(Vector3 center, Vector3 direction, Vector3 normal, float length, float paddleLength = .2f)
        {
            Quaternion rotation = Quaternion.LookRotation(direction, normal);

            Vector3 endPoint = center + rotation * Vector3.forward * length;
            DrawLine(center, endPoint);

            Vector3 paddleLeftPoint = endPoint + rotation * Quaternion.Euler(0, 30, 0) * Vector3.back * paddleLength;
            DrawLine(endPoint, paddleLeftPoint);

            Vector3 paddleRightPoint = endPoint + rotation * Quaternion.Euler(0, -30, 0) * Vector3.back * paddleLength;
            DrawLine(endPoint, paddleRightPoint);
        }

        public void DrawCube(Vector3 center, Vector3 direction, Vector3 normal, Vector3 size)
        {
            Quaternion rotation = Quaternion.LookRotation(direction, normal);

            Vector3 topRectangleCenter = center + rotation * Vector3.up * size.y * .5f;
            Vector3 bottomRectangleCenter = center + rotation * Vector3.down * size.y * .5f;

            Vector3[] topRectanglePoints = ShapePointCreator.GetRectanglePoints(topRectangleCenter, direction, normal, size.x, size.z);
            DrawPolyLine(topRectanglePoints, true);

            Vector3[] bottomRectanglePoints = ShapePointCreator.GetRectanglePoints(bottomRectangleCenter, direction, normal, size.x, size.z);
            DrawPolyLine(bottomRectanglePoints, true);

            ConnectPoints(topRectanglePoints, bottomRectanglePoints);
        }

        private void ConnectPoints(Vector3[] firstPoints, Vector3[] secondPoints)
        {
            for (int i = 0; i < firstPoints.Length; i++)
                DrawLine(firstPoints[i], secondPoints[i]);
        }

        public void DrawRectangle(Vector3 center, Vector3 direction, Vector3 normal, Vector2 size)
        {
            Vector3[] points = ShapePointCreator.GetRectanglePoints(center, direction, normal, size.x, size.y);
            DrawPolyLine(points, true);
        }

        public void DrawCapsule(Vector3 center, Vector3 direction, float height, float radius)
        {
            Vector3 topHemisphereCenter = center + direction * (height * .5f);
            DrawHemisphere(topHemisphereCenter, direction, radius);

            Vector3 topCircleCenter = center + direction * (height * .5f);
            Vector3[] topCircle = ShapePointCreator.GetCirclePoints(topCircleCenter, direction, radius, 4);

            Vector3 bottomCircleCenter = center - direction * (height * .5f);
            Vector3[] bottomCircle = ShapePointCreator.GetCirclePoints(bottomCircleCenter, direction, radius, 4);

            ConnectPoints(topCircle, bottomCircle);

            Vector3 bottomHemisphereCenter = center - direction * (height * .5f);
            DrawHemisphere(bottomHemisphereCenter, -direction, radius);
        }
        
        public void DrawSphere(Vector3 center, float radius)
        {
            int sample = 32;

            DrawCircle(center, Vector3.up, radius, sample);
            DrawCircle(center, Vector3.right, radius, sample);
            DrawCircle(center, Vector3.forward, radius, sample);
        }

        public void DrawHemisphere(Vector3 center, Vector3 direction, float radius)
        {
            int sample = 32;

            Vector3[] circlePoints = ShapePointCreator.GetCirclePoints(center, direction, radius, sample);
            DrawPolyLine(circlePoints, true);

            Quaternion rotation = Quaternion.LookRotation(direction);

            Vector3 horizontalArcNormal = rotation * Vector3.up;
            Vector3[] horizontalArc = ShapePointCreator.GetArcPoints(center, direction, horizontalArcNormal, radius, 180f, sample);
            DrawPolyLine(horizontalArc, false);


            Vector3 verticalArcNormal = rotation * Vector3.right;
            Vector3[] verticalArc = ShapePointCreator.GetArcPoints(center, direction, verticalArcNormal, radius, 180f, sample);
            DrawPolyLine(verticalArc, false);
        }

        public void DrawCylinder(Vector3 center, Vector3 direction, float height, float radius)
        {
            int sample = 32;
            
            Vector3 topCircleCenter = center + direction.normalized * (height * .5f);
            Vector3[] topCirclePoints = ShapePointCreator.GetCirclePoints(topCircleCenter, direction, radius, sample);
            DrawPolyLine(topCirclePoints, true);

            Vector3 bottomCircleCenter = center - direction.normalized * (height * .5f);
            Vector3[] bottomCirclePoints = ShapePointCreator.GetCirclePoints(bottomCircleCenter, direction, radius, sample);
            DrawPolyLine(bottomCirclePoints, true);

            DrawLine(topCirclePoints[0], bottomCirclePoints[0]);
            DrawLine(topCirclePoints[8], bottomCirclePoints[8]);
            DrawLine(topCirclePoints[16], bottomCirclePoints[16]);
            DrawLine(topCirclePoints[24], bottomCirclePoints[24]);
        }

        public void DrawCircle(Vector3 center, Vector3 normal, float radius, int sample = 32)
        {
            Vector3[] circlePoints = ShapePointCreator.GetCirclePoints(center, normal, radius, sample);
            DrawPolyLine(circlePoints, true);
        }

        public void DrawPolyLine(Vector3[] points, bool loop)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (!loop && i == points.Length - 1) break;

                DrawLine(points[i], points[(i + 1) % points.Length]);
            }
        }

        public void DrawCakeSlice(Vector3 center, Vector3 direction, Vector3 normal, float radius, float angle)
        {
            Vector3[] points = ShapePointCreator.GetArcPoints(center, direction, normal, radius, angle, 32);
            DrawPolyLine(points, false);
            DrawLine(center, points[0]);
            DrawLine(center, points[points.Length - 1]);
        }

        public void DrawArc(Vector3 center, Vector3 direction, Vector3 normal, float radius, float angle)
        {
            Vector3[] points = ShapePointCreator.GetArcPoints(center, direction, normal, radius, angle, 32);
            DrawPolyLine(points, false);
        }
    }
}