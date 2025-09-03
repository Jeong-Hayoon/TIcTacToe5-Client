using System;
using DG.Tweening;
using UnityEngine;

// 필수 컴포넌트
[RequireComponent(typeof(CanvasGroup))]
public class PanelController : MonoBehaviour
{
    // 팝업창 RectTransform
    [SerializeField] private RectTransform panelRectTransform;

    // 클래스 안에 있는 멤버 변수라서 언더바
    private CanvasGroup _backgroundCanvasGroup;

    private void Awake()
    {
        // GetComponent도 성능이 조금 드는 함수
        _backgroundCanvasGroup = GetComponent<CanvasGroup>();
    }

    /// Panel 표시
    public void Show()
    {
        // 투명하고 사이즈를 0으로 초기화
        _backgroundCanvasGroup.alpha = 0;
        panelRectTransform.localScale = Vector3.zero;

        // Dotween 함수 활용하여 점점 커지면서 
        _backgroundCanvasGroup.DOFade(1, 0.3f).SetEase(Ease.Linear);
        panelRectTransform.DOScale(1, 0.3f).SetEase(Ease.OutBack);
    }

    /// Panel 숨기기
    public void Hide()
    {
        _backgroundCanvasGroup.alpha = 1;
        panelRectTransform.localScale = Vector3.one;

        _backgroundCanvasGroup.DOFade(0, 0.3f).SetEase(Ease.Linear);
        panelRectTransform.DOScale(0, 0.3f).SetEase(Ease.InBack);
    }
}