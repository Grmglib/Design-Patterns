namespace CommandExampleB
{
    class RotateCommand : IRobotCommand
    {
        private double _rotateLeft { get; set; }
        private readonly Robot _robot;

        public RotateCommand(double rotateLeft, Robot robot)
        {
            _rotateLeft = rotateLeft;
            _robot = robot;
        }

        public void Execute()
        {
            _robot.RotateLeft(_rotateLeft);
        }

        public void Undo()
        {
            _robot.RotateLeft(-_rotateLeft);
        }
    }
}
