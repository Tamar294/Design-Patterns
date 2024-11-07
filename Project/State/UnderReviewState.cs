﻿namespace Project.State
{
    class UnderReviewState : MyState
    {
        public override void Delete()
        {
            Console.Write("You can delete this file.\n");
        }

        public override void Read()
        {
            Console.Write("You can read from this file.\n");
        }
        public void Write()
        {
            Console.Write("you can write to this file.\n");
        }
        public void Merge(string filePath, string filePathupdated)
        {
            Console.WriteLine("You cannot merge files in this state. Change state to MergedState.\n");
        }

        public override void Merge()
        {
            Console.WriteLine("You cannot merge files in this state. Change state to MergedState.\n");
        }
    }

}
