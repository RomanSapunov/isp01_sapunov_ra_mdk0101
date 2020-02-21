using System;

namespace Hierarchy03
{
    class Video : Content
    {
        private DateTime length;

        public Video(int id, string name, DateTime uploadDate, DateTime length) : base(id, name, uploadDate)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return $"Id: {id} \nName: {name} \nUpload date: {uploadDate.ToLongDateString()} \nLength: {length.ToLongTimeString()}";
        }
    }
}
