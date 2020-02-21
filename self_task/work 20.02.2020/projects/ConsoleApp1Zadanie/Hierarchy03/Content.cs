using System;

namespace Hierarchy03
{
    abstract class Content
    {
        protected int id;
        protected string name;
        protected DateTime uploadDate;

        public Content(int id, string name, DateTime uploadDate)
        {
            this.id = id;
            this.name = name;
            this.uploadDate = uploadDate;
        }

        public override string ToString()
        {
            return $"Id: {id} \nName: {name} \nUpload date: {uploadDate.ToLongDateString()}";
        }
    }
}
