using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

public class RightHandController : MonoBehaviour
{
    [SerializeField] private HapticImpulsePlayer hapticPlayer;
    [SerializeField] private InputActionReference rightActivate;
    [SerializeField] private InputActionReference rightA, rightB;
    [SerializeField] private InputActionReference rightGrab;
    [SerializeField] private GameObject UI_A, UI_B;
    [SerializeField] private Transform fireTransform;
    [SerializeField] private GameObject[] particlePrefab;
    [SerializeField] private float fireInterval = 0.15f;

    private bool isFiring;
    private float fireTimer;

    private void OnEnable()
    {
        rightActivate.action.performed += OnClickStart;
        rightActivate.action.canceled += OnClickEnd;

        rightA.action.performed += OnPressA;
        rightA.action.canceled += OnExitA; 
        rightB.action.performed += OnPressB;

        rightGrab.action.performed += OnGrabButton;
    }

    private void OnDisable()
    {
        rightActivate.action.performed -= OnClickStart;    
        rightActivate.action.canceled -= OnClickEnd;

        rightA.action.performed -= OnPressA;
        rightA.action.canceled -= OnExitA;
        rightB.action.performed -= OnPressB;

        rightGrab.action.performed -= OnGrabButton;

    }

    private void OnPressA(InputAction.CallbackContext _) {
        UI_B.SetActive(true);
    }

    private void OnPressB(InputAction.CallbackContext _)
    {
        if (UI_A.activeSelf) {
            Time.timeScale = 1.0f;
            UI_A.SetActive(false);
            Spawner.MonsterHide(false);
            return;
        }


        Time.timeScale = 0;
        UI_A.SetActive(true);
        Spawner.MonsterHide(true);
    }
    //void OnClick(InputAction.CallbackContext cot) {
    //    Debug.Log("클릭됨");

    //}

    private void OnExitA(InputAction.CallbackContext _) {
        UI_B.SetActive(false);
    }

    private void OnGrabButton(InputAction.CallbackContext _) {
        if (UI_B.activeSelf)
        {
            UiImageMover.Instance.moveNext();
        }
    }

    private void Update()
    {
        if (!isFiring)
            return;
        fireTimer -= Time.deltaTime;
        if (fireTimer <= 0.0f) {
            Fire();
            fireTimer = fireInterval;
        }
    }

    void Fire()
    {
        if (particlePrefab == null || particlePrefab.Length == 0) return;
        if (UiImageMover.Instance == null) return;

        // particlePrefab의 실제 크기 안에서만 순환하도록 안전하게 % 연산 처리
        int index = UiImageMover.Instance.CurrentIndex() % particlePrefab.Length;

        if (particlePrefab[index] != null)
        {
            Instantiate(particlePrefab[index], fireTransform.position, fireTransform.rotation);
        }
        hapticPlayer.SendHapticImpulse(0.5f,0.1f);
    }

    void OnClickStart(InputAction.CallbackContext cot) {
       isFiring = true;
        fireTimer = 0.0f;
    }

    void OnClickEnd(InputAction.CallbackContext cot) {
        isFiring= false;
    }
}
