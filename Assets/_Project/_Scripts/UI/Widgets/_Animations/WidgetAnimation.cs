using Cysharp.Threading.Tasks;
using UnityEngine;

namespace UI.Widgets.Animations
{
    public abstract class WidgetAnimation : MonoBehaviour
    {
        public abstract UniTask AnimateOpen(Widget widget);
        public abstract UniTask AnimateClose(Widget widget);
    }
}