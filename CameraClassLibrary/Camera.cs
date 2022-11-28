namespace CameraClassLibrary
{
    public class Camera
    {
        public int Id { get; set; }
        public int PictureId { get; set; }

        public DateTime Date { get; set; }
        public byte[] Picture { get; set; }
    }
}