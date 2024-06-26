using Cysharp.Threading.Tasks;
using UI.Widgets.Casino;
using UI.Widgets.Controller;
using Zenject;

namespace InteractiveObjects.Casino
{
    public class CasinoInteractive : IInteractive
    {
        private IWidgetsController _widgetsController;

        [Inject]
        private void Construct(IWidgetsController widgetsController)
        {
            _widgetsController = widgetsController;
        }
        
        public UniTask Interact()
        {
            return _widgetsController.Open<CasinoWidget>();
        }
    }
}