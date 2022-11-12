using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public static class ShapePointCreator
    {
        public static Vector3[] GetCirclePoints(Vector3 center, Vector3 normal, float radius, int sample = 32)
        {
            Vector3[] points = new Vector3[sample];

            float degreeBetweenVertex = 360f / sample;
            Quaternion rotation = Quaternion.LookRotation(normal);

            for (int i = 0; i < sample; i++)
            {
                points[i] = center + (rotation * Vector3.left * radius);
                rotation *= Quaternion.Euler(0, 0, degreeBetweenVertex);
            }

            return points;
        }

        public static Vector3[] GetRectanglePoints(Vector3 center, Vector3 direction, Vector3 normal, float width, float height)
        {
            Quaternion rotation = Quaternion.LookRotation(direction, normal);

            Vector3 leftTopCorner = center;
            leftTopCorner += rotation * Vector3.forward * height * .5f;
            leftTopCorner += rotation * Vector3.left * width * .5f;

            Vector3 rightTopCorner = center;
            rightTopCorner += rotation * Vector3.forward * height * .5f;
            rightTopCorner += rotation * Vector3.right * width * .5f;

            Vector3 leftBottomCorner = center;
            leftBottomCorner += rotation * Vector3.back * height * .5f;
            leftBottomCorner += rotation * Vector3.left * width * .5f;

            Vector3 rightBottomCorner = center;
            rightBottomCorner += rotation * Vector3.back * height * .5f;
            rightBottomCorner += rotation * Vector3.right * width * .5f;

            return new Vector3[] {
            leftTopCorner, rightTopCorner, rightBottomCorner, leftBottomCorner
        };
        }

        public static Vector3[] GetArcPoints(Vector3 center, Vector3 direction, Vector3 normal, float radius, float angle, int sample)
        {
            Vector3[] points = new Vector3[sample];

            float degreeBetweenVertex = angle / (sample - 1);
            Quaternion rotation = Quaternion.LookRotation(direction, normal);
            rotation *= Quaternion.Euler(0, -angle * .5f, 0);

            for (int i = 0; i < sample; i++)
            {
                points[i] = center + (rotation * Vector3.forward * radius);
                rotation *= Quaternion.Euler(0, degreeBetweenVertex, 0);
            }

            return points;
        }
    }
}