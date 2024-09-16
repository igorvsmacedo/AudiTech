// Services/ToastService.cs
using System;
using System.Collections.Generic;
using System.Timers;

public class ToastService
{
    public event Action<string, string, ToastLevel> OnShow;
    public event Action OnHide;

    public void ShowToast(string message, string heading, ToastLevel level)
    {
        OnShow?.Invoke(message, heading, level);
    }

    public void HideToast()
    {
        OnHide?.Invoke();
    }
}

public enum ToastLevel
{
    Info,
    Success,
    Warning,
    Error
}
