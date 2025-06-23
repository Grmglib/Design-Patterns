namespace CommandExampleB
{
    internal class ExcavateCommand : IRobotCommand
    {
        private bool _harvestMaterial { get; set; }
        private readonly Robot _robot;

        public ExcavateCommand(bool harvestMaterial, Robot robo)
        {
            _harvestMaterial = harvestMaterial;
            _robot = robo;
        }

        public void Execute()
        {
            _robot.Excavate(_harvestMaterial);
        }

        public void Undo()
        {
            _robot.Excavate(!_harvestMaterial);
        }
    }
}