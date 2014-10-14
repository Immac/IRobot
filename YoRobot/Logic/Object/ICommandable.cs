namespace YoRobot.Logic.Object
{
    public interface ICommandable
    {
        bool RunCommand(IGameCommand command);
    }
}