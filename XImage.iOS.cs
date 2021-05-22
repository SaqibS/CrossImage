using System;
using System.Drawing;
using CoreGraphics;
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
            nfloat scale = this.image.CurrentScale;
            var scaledRect = new CGRect(region.X * scale, region.Y * scale, region.Size.Width * scale, region.Size.Height * scale);
            using CGImage croppedCgImage = image.CGImage.WithImageInRect(scaledRect);
            return new XImage(UIImage.FromImage(croppedCgImage));
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
