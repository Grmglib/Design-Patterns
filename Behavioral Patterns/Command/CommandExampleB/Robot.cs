namespace CommandExampleB
{
    internal class Robot
    {
        public void Move(int forward)
        {
            if (forward > 0)
            {
                Console.WriteLine("The robot was moved forward {0}mm", forward);
            }
            else
            {
                Console.WriteLine("The robot was moved backwards {0}mm.", -forward);
            }
        }

        public void RotateLeft(double rotateLeft)
        {
            if (rotateLeft > 0)
                Console.WriteLine("The robot was rotated left {0} degrees.", rotateLeft);
            else
                Console.WriteLine("The robot was rotated right {0} degrees.", -rotateLeft);
        }

        public void Excavate(bool upwards)
        {
            if (upwards)
                Console.WriteLine("The robot excavated the material from soil.");
            else
                Console.WriteLine("The robot dumped the material.");
        }
    }
}