using System;

namespace Hierarchy03
{
    class Photo : Content
    {
        private string whoIsOnPicture;

        public Photo(int id, string name, DateTime uploadDate, string whoIsOnPicture) : base(id, name, uploadDate)
        {
            this.whoIsOnPicture = whoIsOnPicture;
        }

        public override string ToString()
        {
            return $"Id: {id} \nName: {name} \nUpload date: {uploadDate.ToLongDateString()} \nWho Is On Picture: {whoIsOnPicture}";
        }
    }
}
