using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;


namespace WarGames_Defcon_1.Code.Scripts.UI.DragAndDrop {
    public class DragAndDropBase : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler {
        #region FIELDS
        [SerializeField] protected bool draggable = true;
        [SerializeField] protected bool restrictedByParentRectTransform = true;
        [Tooltip("The higher the value, the lower the speed")]
        [SerializeField, Range(0.01f, 2f)] protected float returnDampSpeed = 0.05f;
        [SerializeField, Range(0.1f, 5f)] protected float dampTime = 3f;


        protected UnityEvent<PointerEventData>[] dragEvents;
        protected UnityEvent<PointerEventData> _OnBeginDrag = new ();
        protected UnityEvent<PointerEventData> _OnDrag = new ();
        protected UnityEvent<PointerEventData> _OnEndDrag = new ();
        protected UnityEvent<PointerEventData> _OnDrop = new ();

        
        protected RectTransform draggingObjectRectTransform;
        protected RectTransform parentObjectRectTransform;
        protected Bounds parentBounds;
        protected Vector2 boundClosestPoint = Vector2.zero;
        protected Vector3 velocity = Vector3.zero;
        protected Vector3 endDragPoint = Vector3.zero;
        protected float dragDampSpeed = 0.05f;
        #endregion

        

        #region BUILTIN METHODS
        protected virtual void Awake() {
            dragEvents = new [] { _OnBeginDrag, _OnDrag, _OnEndDrag, _OnDrop };
            
            var t = transform;
            draggingObjectRectTransform = t as RectTransform;
            parentObjectRectTransform = t.parent as RectTransform;

            if (parentObjectRectTransform == null) return;
            var position = parentObjectRectTransform.position;
            var size = new Vector3(parentObjectRectTransform.rect.width, parentObjectRectTransform.rect.height);
            parentBounds = new Bounds(position, size);
        }


        protected virtual void OnDisable() {
            StopAllCoroutines();
            foreach (var @event in dragEvents) @event.RemoveAllListeners();
        }


        public void OnBeginDrag(PointerEventData eventData) {
            if (draggable) _OnBeginDrag?.Invoke(eventData);
        }

        
        public void OnDrag(PointerEventData eventData) {
            if (draggable) _OnDrag?.Invoke(eventData);
        }


        public void OnEndDrag(PointerEventData eventData) {
            _OnEndDrag?.Invoke(eventData);
        }
        
        
        public void OnDrop(PointerEventData eventData) {
            _OnDrop?.Invoke(eventData);
        }
        #endregion



        #region CUSTOM METHODS
        protected void SwitchBehavior(UnityEvent<PointerEventData> @event, UnityAction<PointerEventData> behavior) {
            @event.RemoveAllListeners();
            @event.AddListener(behavior);
        }


        protected IEnumerator SmoothLerp(Vector2 currentPosition, Vector2 targetPosition, float time) {
            if (draggable) draggable = false;
            var elapsedTime = 0f;
            while (elapsedTime < time) {
                draggingObjectRectTransform.position = Vector3.SmoothDamp(
                    draggingObjectRectTransform.position,
                    targetPosition,
                    ref velocity,
                    returnDampSpeed);
                
                elapsedTime += Time.deltaTime;
                yield return null;
            }
            draggable = true;
        }
        #endregion
    }
}