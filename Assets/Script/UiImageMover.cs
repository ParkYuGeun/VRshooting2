/*using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class UiImageMover : MonoBehaviour
{
    public static UiImageMover Instance = null;

    public void Awake()
    {
        if (Instance == null) {
        Instance = this;
        }
    }
    public RectTransform movingImage;
    public RectTransform[] targetSlot;
    public float moveDuration = 0.25f;

    public int currentIndex = 0;
    private bool isMoving = false;

    public int CurrentIndex() {
        return currentIndex;
    }

    public void moveNext() {
        if(isMoving)
            return;
        currentIndex = (currentIndex + 1) % targetSlot.Length;
        StartCoroutine(moveToIndex(currentIndex));
    }

    private IEnumerator moveToIndex(int index)
    {
        isMoving = true;

        Vector3 startPos = movingImage.position;
        Vector3 endPos = targetSlot[index].position;

        float time = 0f;

        while (time < moveDuration)
        {
            time += Time.deltaTime;
            float t = time / moveDuration;

            t = math.smoothstep(0f, 1f, t);

            endPos = targetSlot[index].position;
            movingImage.position = Vector3.Lerp(startPos, endPos, t);
            yield return null;
        }
        movingImage.position = endPos;
        isMoving = false;
    }


}
*/

using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class UiImageMover : MonoBehaviour
{
    public static UiImageMover Instance = null;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public RectTransform movingImage;
    public RectTransform[] targetSlot;
    public float moveDuration = 0.25f;

    public int currentIndex = 0;
    private bool isMoving = false;

    private void OnEnable()
    {
        Debug.Log(currentIndex);
    }

    public int CurrentIndex()
    {
        return currentIndex;
    }

    public void moveNext()
    {
        if (isMoving)
            return;

        currentIndex = (currentIndex + 1) % targetSlot.Length;
        StartCoroutine(moveToIndex(currentIndex));
    }

    private IEnumerator moveToIndex(int index)
    {
        isMoving = true;

        // 고정된 endPos 대신 캔버스/부모 기준 localPosition이나 anchoredPosition을 활용
        Vector3 startLocalPos = movingImage.localPosition;
        float time = 0f;

        while (time < moveDuration)
        {
            time += Time.deltaTime;
            float t = time / moveDuration;
            t = math.smoothstep(0f, 1f, t);

            // 매 프레임 타겟의 최신 위치를 가져옴 (같은 부모 기준 localPosition)
            Vector3 currentTargetLocalPos = movingImage.parent.InverseTransformPoint(targetSlot[index].position);

            movingImage.localPosition = Vector3.Lerp(startLocalPos, currentTargetLocalPos, t);
            yield return null;
        }

        // 이동 완료 후 최신 월드 위치에 맞춤
        movingImage.position = targetSlot[index].position;
        isMoving = false;
    }
}