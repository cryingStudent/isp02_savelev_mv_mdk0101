using System;


namespace Inheritance.Hierarchy02
{
    class Video : Content
    {
        public int Time { get; set; }


        public Video(int time, int id, string name, DateTime uploadDate)
            : base(id, name, uploadDate)
        {
            Time = time;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Длина видео-- {Time}";
        }


    }
}
