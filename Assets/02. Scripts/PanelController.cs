using System;
using DG.Tweening;
using UnityEngine;

// �ʼ� ������Ʈ
[RequireComponent(typeof(CanvasGroup))]
public class PanelController : MonoBehaviour
{
    // �˾�â RectTransform
    [SerializeField] private RectTransform panelRectTransform;

    // Ŭ���� �ȿ� �ִ� ��� ������ �����
    private CanvasGroup _backgroundCanvasGroup;

    private void Awake()
    {
        // GetComponent�� ������ ���� ��� �Լ�
        _backgroundCanvasGroup = GetComponent<CanvasGroup>();
    }

    /// Panel ǥ��
    public void Show()
    {
        // �����ϰ� ����� 0���� �ʱ�ȭ
        _backgroundCanvasGroup.alpha = 0;
        panelRectTransform.localScale = Vector3.zero;

        // Dotween �Լ� Ȱ���Ͽ� ���� Ŀ���鼭 
        _backgroundCanvasGroup.DOFade(1, 0.3f).SetEase(Ease.Linear);
        panelRectTransform.DOScale(1, 0.3f).SetEase(Ease.OutBack);
    }

    /// Panel �����
    public void Hide()
    {
        _backgroundCanvasGroup.alpha = 1;
        panelRectTransform.localScale = Vector3.one;

        _backgroundCanvasGroup.DOFade(0, 0.3f).SetEase(Ease.Linear);
        panelRectTransform.DOScale(0, 0.3f).SetEase(Ease.InBack);
    }
}