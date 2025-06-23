namespace CommandExampleB
{
    internal class MoveCommand : IRobotCommand
    {
        private readonly Robot _robot;
        private int _forward { get; set; }

        public MoveCommand(int forward, Robot robo)
        {
            _forward = forward;
            _robot = robo;
        }

        public void Execute()
        {
            _robot.Move(_forward);
        }

        public void Undo()
        {
            _robot.Move(-_forward);
        }
    }
}