using System.Drawing;
using UIKit;

namespace CrossImage
{
    public partial class XImage
    {
        private readonly UIImage image;

        public XImage(UIImage image)
        {
            this.image = image;
            this.Size = new Size((int)image.Size.Width, (int)image.Size.Height);
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

        public UIImage ToUIImage()
        {
            return image;
        }
    }
}
