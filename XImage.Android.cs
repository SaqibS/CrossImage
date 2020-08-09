using System.Drawing;
using Bitmap = Android.Graphics.Bitmap;

namespace CrossImage
{
    public partial class XImage
    {
        private readonly Bitmap image;

        public XImage(Bitmap image)
        {
            this.image = image;
            this.Size = new Size(image.Width, image.Height);
        }

        public XImage Resize(Size newSize)
        {
            return this;
        }

        public XImage Crop(Rectangle region)
        {
            return this;
        }

        public XImage Rotate(int degrees)
        {
            return this;
        }

        public byte[] ToJpeg(float compressionQuality)
        {
            return new byte[0];
        }

        public Color[] GetPixels()
        {
            return new Color[0];
        }

        public Bitmap ToBitmap()
        {
            return image;
        }
    }
}
