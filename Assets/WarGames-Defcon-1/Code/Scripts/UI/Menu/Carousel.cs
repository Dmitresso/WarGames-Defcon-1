using System.Collections.Generic;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.UI.Menu {
    public enum Axis {
        XY,
        XZ,
        YZ
    }

    public enum Loop {
        True,
        False
    }

    public enum Type {
        Round,
        Strip
    }
    

    [RequireComponent(typeof(Canvas),
                     typeof(CanvasGroup),
                     typeof(LineRenderer))]
    public class Carousel : MonoBehaviour {
        #region FIELDS
        [SerializeField] private Axis axis = Axis.XY;
        [SerializeField] private Loop loop = Loop.True;
        [SerializeField] private Type type = Type.Strip;
        [SerializeField, Range(3, 200)] private int points = 10;
        [SerializeField] private Vector3 center = Vector3.zero;
        [SerializeField, Range(50, 1000)] private float radius1;
        [SerializeField, Range(50, 1000)] private float radius2;
        
        [SerializeField] private RectTransform element;
        [SerializeField, Range(2, 10)] private int elementsCount;
        [SerializeField] private List<RectTransform> elements;


        //[SerializeField] private Vector3 startPoint;
        //[SerializeField] private Vector3 endPoint;
        // [SerializeField] private float radius;
        // [SerializeField] private float speed;
        // [SerializeField] private float elementWidth;
        // [SerializeField] private float elementHeight;

        private RectTransform rectTransform;
        private LineRenderer lineRenderer;
        #endregion



        #region BUILTIN METHODS
        private void Awake() {
            rectTransform = GetComponent<RectTransform>();
            lineRenderer = GetComponent<LineRenderer>();
            elements = new List<RectTransform>(elementsCount);

            lineRenderer.widthCurve = AnimationCurve.Constant(1f, 1f, 1f);
            lineRenderer.widthMultiplier = 10;
            lineRenderer.sharedMaterial = new Material(Shader.Find("Sprites/Default"));
            lineRenderer.startColor = lineRenderer.endColor = Color.red;
            lineRenderer.useWorldSpace = false;

            lineRenderer.loop = loop switch {
                Loop.False => false,
                Loop.True => true,
                _ => lineRenderer.loop
            };

            // if (element != null) {
            //     for (var i = 0; i < elements.Capacity; i++) {
            //         var e = Instantiate(element, transform, true);
            //         elements.Add(e);
            //     }
            // }

        }


        private void Start() {
            //DrawCircle(points, radius);
            DrawEllipse(points, radius1, radius2);
            //DrawPolygon(10, 5f, new Vector3(rectTransform.pivot.x, rectTransform.pivot.y, 0.0f), 1f, 1f);
        }
        #endregion
        
        
        
        #region CUSTOM METHODS
        private void DrawCircle(int points, float radius) {
            lineRenderer.positionCount = points;
            for (var point = 0; point < points; point++) {
                var circumferenceProgress = (float) point / points - 1;
                var currentRadian = circumferenceProgress * 2 * Mathf.PI;
                var xScaled = Mathf.Cos(currentRadian);
                var yScaled = Mathf.Sin(currentRadian);

                var x = xScaled * radius;
                var y = yScaled * radius;

                var currentPosition = new Vector3(x, y, 0);
                lineRenderer.SetPosition(point, currentPosition);
            }
        }


        private void DrawEllipse(int points, float r1, float r2) {
            lineRenderer.positionCount = points + 1;
            var position = new Vector3();
            float x, y, z = 0f, angle = 0f;
            
            for (var i = 0; i < points + 1; i++) {
                x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius1;
                y = Mathf.Cos(Mathf.Deg2Rad * angle) * radius2;

                position = axis switch {
                    Axis.XY => new Vector3(x, y, z),
                    Axis.XZ => new Vector3(x, z, y),
                    Axis.YZ => new Vector3(z, x, y),
                    _ => position
                };
                lineRenderer.SetPosition(i, position);

                angle += 360f / points;
            }
        }


        private void DrawPolygon(int vertexNumber, float radius, Vector3 centerPos, float startWidth, float endWidth) {
            lineRenderer.loop = loop switch {
                Loop.True => true,
                Loop.False => false,
                _ => lineRenderer.loop
            };

            lineRenderer.startWidth = startWidth;
            lineRenderer.endWidth = endWidth;
            var angle = 2 * Mathf.PI / vertexNumber;
            lineRenderer.positionCount = vertexNumber;

            
            
            // for (var i = 0; i < vertexNumber; i++) {
            //     var rotationMatrix = new Matrix4x4(new Vector4(Mathf.Cos(angle * i), Mathf.Sin(angle * i), 0, 0),
            //         new Vector4(-1 * Mathfдю6996щ.Sin(angle * i), Mathf.Cos(angle * i), 0, 0),
            //         new Vector4(0, 0, 1, 0),э
            //         new Vector4(0, 0, 0, 1));
            //     var э7гзо = new Vector3(0, radius, 0);
            //     lineRenderer.SetPosition(i, centerPos + rotationMatrix.MultiplyPoint(initialRelativePosition));
            // }
        }
        #endregion
    }
}