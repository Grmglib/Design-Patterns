namespace CommandExampleB
{
    public interface IRobotCommand
    {
        void Execute();

        void Undo();
    }
}