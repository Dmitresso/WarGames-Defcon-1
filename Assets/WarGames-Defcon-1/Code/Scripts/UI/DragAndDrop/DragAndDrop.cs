using UnityEngine;
using UnityEngine.EventSystems;


namespace WarGames_Defcon_1.Code.Scripts.UI.DragAndDrop {
    public class DragAndDrop : DragAndDropBase {
        #region FIELDS

        #endregion

        

        #region BUILTIN METHODS
        protected void Awake() {
            base.Awake();
        }
        
        
        protected void Start() {
            // SwitchBehavior(_OnDrag, OnDrag_Restricted);
            
            // SwitchBehavior(_OnDrag, OnDrag_Base);
            SwitchBehavior(_OnDrag, OnDrag_RestrictedByAxis);
            SwitchBehavior(_OnEndDrag, OnEndDrag_Base);
        }
        #endregion



        #region CUSTOM METHODS
        protected void OnDrag_Base(PointerEventData eventData) {
            if (RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObjectRectTransform, eventData.position, eventData.pressEventCamera, out var mousePosition)) {
                draggingObjectRectTransform.position = Vector3.SmoothDamp(draggingObjectRectTransform.position, mousePosition, ref velocity, dragDampSpeed);
            }
        }


        protected void OnEndDrag_Base(PointerEventData eventData) {
            draggable = false;
            endDragPoint = eventData.position;
            if (!restrictedByParentRectTransform) return;
            boundClosestPoint = parentBounds.ClosestPoint(eventData.position);

            if (parentBounds.Contains(eventData.position)) return;
            
            var direction = (boundClosestPoint - eventData.position).normalized;
            var targetPosition = boundClosestPoint + draggingObjectRectTransform.sizeDelta * direction;
            StartCoroutine(SmoothLerp(eventData.position, targetPosition, dampTime));
        }
        
        protected void OnDrag_Restricted(PointerEventData eventData) {
            if (RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObjectRectTransform, eventData.position, eventData.pressEventCamera, out var mousePosition)) {
                draggingObjectRectTransform.position = Vector3.SmoothDamp(draggingObjectRectTransform.position, mousePosition, ref velocity, dragDampSpeed);

                if (parentBounds.Contains(eventData.position)) return; 
                draggable = false;
            }
        }

        protected void OnDrag_RestrictedByAxis(PointerEventData eventData) {
            var offset = 10f;
            var currentDragPosition = eventData.position.x;
            var currentRectPosition = draggingObjectRectTransform.position.x;
            if (currentDragPosition != currentRectPosition + offset)
                draggingObjectRectTransform.position = new Vector3(eventData.position.x, draggingObjectRectTransform.position.y, 0);
        }
        #endregion
    }
}