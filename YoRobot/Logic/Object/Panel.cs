using System;

namespace YoRobot.Logic.Object
{
    class Panel : ICommandable,IGameObject
    {
        public IGameObject MyGameObject { get; set; }

        public bool RunCommand(IGameCommand command)
        {
            throw new NotImplementedException();
        }
        public string Id { get; set; }
    }
}
