namespace Infrastructure.GameState.Machine
{
    public interface IGameStateMachine
    {
        IExitableState ActiveState { get; }
        
        void Enter<TState>() where TState : class, IState;
        void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>;
    }
}