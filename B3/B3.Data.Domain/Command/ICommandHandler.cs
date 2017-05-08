namespace B3.Data.Domain.Command
{
    public interface ICommandHandler<in TCommand> where TCommand: ICommand
    {
        void Handle(TCommand command);
    }
}